// SerialComm.cpp: implementation of the SerialComm class.
//
//////////////////////////////////////////////////////////////////////
// System Libraries
#include "Windows.h"

// Project Libraries
#include "SerialComm.h"

//////////////////////////////////////////////////////////////////////
// Construction/Destruction
//////////////////////////////////////////////////////////////////////

SerialComm::SerialComm()
{
	hFile = INVALID_HANDLE_VALUE;
	szCommLineName[0] = '\x00';
	szCommDef[0] = '\x00';
	EventFlag = 0;
	szInputBuff[0] = '\x00';
	TermChar = '\r';
	NullChar = '\x00';
	SubChar = ' ';
	dwNextBuf = 0;
	bResetRequired = FALSE;
	return ;
}

SerialComm::~SerialComm()
{
	CloseComm();
	return ;
}
void SerialComm::CloseComm( void)
{
	if (hFile == INVALID_HANDLE_VALUE) return;
	if (CloseHandle( hFile)) hFile = INVALID_HANDLE_VALUE;
	return ;
}	//end of CSerialComm::CloseComm 

void SerialComm::Purge( void)
{
	BOOL bSuccess;
	DWORD LastErr;
	bSuccess = PurgeComm( hFile, 
		PURGE_TXABORT | PURGE_RXABORT | PURGE_TXCLEAR | PURGE_RXCLEAR );
	szInputBuff[ 0]= NullChar;// set local buffer empty
	dwNextBuf = 0;
	if (!bSuccess)
		LastErr = GetLastError();
}	//end of CSerialComm::Purge

//	lpszName should look like "COM1:" etc
//	lpszDef should match the formats for then NT "mode" command
//		try "help mode" at the command line
//	EndOfLine is the character you want to terminate lines with
BOOL SerialComm::OpenComm( LPCTSTR lpszName, LPCTSTR lpszDef, char EndOfLine )
{
	BOOL bSuccess = FALSE;
	BOOL bSucc2 = FALSE;
	BOOL bSucc3 = FALSE;
	DWORD LastErr;
	if (strlen( lpszName)<19) strcpy( szCommLineName, lpszName);
	if (strlen( lpszDef)>0 && strlen( lpszDef)<99)
			strcpy(  szCommDef, lpszDef);
		else strcpy( szCommDef,
	"baud=19200 parity=N data=8 stop=1 to=off xon=off odsr=off octs=off dtr=on rts=off idsr=off");
	TermChar = EndOfLine;
	
	hFile = CreateFile( szCommLineName, GENERIC_READ + GENERIC_WRITE, 
	 			0, NULL, OPEN_EXISTING, FILE_ATTRIBUTE_NORMAL, NULL); 
	if (hFile != INVALID_HANDLE_VALUE) {
		bSuccess = InitCommLine();
		bSucc3 = SetupComm( hFile, 512,512);
		if (!bSucc3)
			LastErr = GetLastError();
	}
	else
		LastErr = GetLastError();
	//EventFlag = EV_RXFLAG;
	EventFlag = 0;
	bSucc2 = SetCommMask( hFile, EventFlag);
	if (!bSucc2)
		LastErr = GetLastError();
	return bSuccess;
}	//end of CSerialComm::OpenComm

BOOL SerialComm::InitCommLine( void)
	{
	DCB	DevCntl;
	BOOL bSuccess = FALSE;
	BOOL bSucc2 = FALSE;
	BOOL bSucc3 = FALSE;
	BOOL bSucc4 = FALSE;
	BOOL bSucc5 = FALSE;
	BOOL bSucc6 = FALSE;	
	DWORD dwLastErr = 0;
	
	bSuccess = GetCommState( hFile, &DevCntl ); 
	if (bSuccess)
		{
		bSucc2 = BuildCommDCB( szCommDef, &DevCntl);
		if (!bSucc2)
			dwLastErr = GetLastError();

		DevCntl.EvtChar= TermChar;
		
		bSucc3 = SetCommState( hFile, &DevCntl);
		if (!bSucc3)
			dwLastErr = GetLastError();
		}
		else
			dwLastErr = GetLastError();

	//todo understand  better how we want to set these
	//or change them
	bSucc4 = GetCommTimeouts( hFile, &commtime);
	if (bSucc4)
		{
		bSucc5 = SetReadTimeouts( 100, 0, 10000);
		bSucc5 = bSucc5 && SetWriteTimeouts( 10, 2500);
	}
		else
			dwLastErr = GetLastError();
	bSucc6 = PurgeComm( hFile, 
		PURGE_TXABORT | PURGE_RXABORT | PURGE_TXCLEAR | PURGE_RXCLEAR );
	if(!bSucc6)
		dwLastErr = GetLastError();
	bSuccess = bSuccess && bSucc2 && bSucc3 && bSucc4 && bSucc5;
	return bSuccess;
}//end of CSerialComm::InitCommLine

BOOL SerialComm::SetReadTimeouts(	DWORD CharInterval,
									DWORD CharMult,
									DWORD Total)
{
	BOOL bSucc;
	commtime.ReadIntervalTimeout = CharInterval;
	commtime.ReadTotalTimeoutMultiplier = CharMult;
	commtime.ReadTotalTimeoutConstant =  Total;
	bSucc = SetCommTimeouts( hFile, &commtime);
	return bSucc;
}//end of CSerialComm::SetReadTimeouts

BOOL SerialComm::SetWriteTimeouts(	DWORD CharMult,
							DWORD Total)
{
	BOOL bSucc;
	commtime.WriteTotalTimeoutMultiplier = CharMult;
	commtime.WriteTotalTimeoutConstant =  Total;
	bSucc = SetCommTimeouts( hFile, &commtime);
	return bSucc;

}//end of CSerialComm::SetWriteTimeouts


BOOL SerialComm::WriteComm( LPCVOID  lpBuffer, DWORD  nNumberOfBytesToWrite)
{
 	BOOL bSucc1;
	DWORD dwCnt;
	DWORD dwLastErr = 0;

	if(!nNumberOfBytesToWrite) nNumberOfBytesToWrite = strlen( (char *) lpBuffer);
	bSucc1 = WriteFile( hFile, lpBuffer, nNumberOfBytesToWrite, &dwCnt, NULL);
	if (!bSucc1)
		dwLastErr = GetLastError();
	if(nNumberOfBytesToWrite != dwCnt)
		return FALSE;//no error if it times out!!!!
	return (bSucc1);
}//end of CSerialComm::WriteComm

// internaly used routine only, not available to a "user" of the class
BOOL SerialComm::Transfer( LPSTR lpBuffer, DWORD dwMaxChar)
{
 	BOOL bDone = FALSE;
	char k;

	while (!bDone && dwNextBuf < strlen( szInputBuff))
		{
		k =	szInputBuff[ dwNextBuf];
		lpBuffer[ dwNextUser]= k;
		dwNextUser++;
		dwNextBuf++;
		bDone = (k ==TermChar) || (dwNextUser == dwMaxChar);
		};
	return bDone;
}// end of CSerialComm::Transfer

BOOL SerialComm::ReadComm( LPSTR  lpBuffer,
							DWORD nNumberOfByteToRead,
							LPDWORD nNumberOfBytesRead,
							DWORD MinCharsExpected)
{
 	BOOL bSucc1, bSucc2, bSucc3;
	DWORD dwReadCnt = 0;
	DWORD dwReadCnt2 = 0;
 	DWORD dwLastErr = 0;
	BOOL bDone = FALSE;
	BOOL bTimeout = FALSE;
	DWORD dwErrors = 0;
	DWORD loop;
	DWORD	ReqChars;
	COMSTAT ComStat;
	char	*pNextRead;
	
	dwNextUser = 0;
	bDone = Transfer( lpBuffer, nNumberOfByteToRead);//Check if we have chars left in our buffer
	if (!bDone) {
		bSucc1 = ClearCommError( hFile, &dwErrors, &ComStat);
		dwReadCnt = 0;
		if( ComStat.cbInQue>0 && bSucc1) //anything in the input buffer?
			{
			if (ComStat.cbInQue>255)
				ComStat.cbInQue = 255;
			bSucc2 = ReadFile( hFile, szInputBuff, ComStat.cbInQue, &dwReadCnt, NULL);
			}
		if( dwReadCnt>0) {
			for ( loop = 0; loop<dwReadCnt; loop++) //substitute for nulls
				if (szInputBuff[loop]==NullChar) szInputBuff[loop]= SubChar;
			szInputBuff[ dwReadCnt]= NullChar;
			dwNextBuf = 0;
			bDone = Transfer( lpBuffer, nNumberOfByteToRead);
			}
		if(dwErrors)
			loop = 0;//trap for breakpoint
		};
	while (!bDone && !bTimeout) {
		ReqChars =  MinCharsExpected-dwNextUser;
		if(MinCharsExpected>dwNextUser) ReqChars = MinCharsExpected-dwNextUser;
		else ReqChars = 1;
		bSucc3 = ReadFile( hFile, szInputBuff,ReqChars, &dwReadCnt, NULL);
		if (bSucc3 && dwReadCnt>0) {
			pNextRead = szInputBuff;
			pNextRead += dwReadCnt;
			dwReadCnt2=0;
			bSucc1 = ClearCommError( hFile, &dwErrors, &ComStat);
			if( ComStat.cbInQue>0 && bSucc1) { //anything in the input buffer?
				if (ComStat.cbInQue>255) ComStat.cbInQue = 255;
				bSucc2 = ReadFile( hFile, pNextRead, ComStat.cbInQue, &dwReadCnt2, NULL);
				if(!bSucc2)
					dwLastErr = GetLastError();
			}
			for ( loop = 0; loop<dwReadCnt+dwReadCnt2; loop++) //substitute for nulls
				if (szInputBuff[loop]==NullChar) szInputBuff[loop]= SubChar;
			szInputBuff[ dwReadCnt+dwReadCnt2]= NullChar;
			dwNextBuf = 0;
			bDone = Transfer( lpBuffer, nNumberOfByteToRead);
		}
		else
			bTimeout = TRUE;
	}//while not done and not timeout


	lpBuffer[ dwNextUser]= NullChar;//terminate the string!
	*nNumberOfBytesRead= dwNextUser;
	if(dwNextUser==0)
		loop = 0;//trap for debugger
	return bDone;
}//end of CSerialComm::ReadComm

BOOL SerialComm::IsOpen( void)
{
	//this function return true if a valid file handle exists, 
	//false if not  to be used so user code can detect if comm
	//port does not exist or other problems
	BOOL bValidHandle = hFile != INVALID_HANDLE_VALUE;
	return bValidHandle;
};//end of CSerialComm::IsOpen