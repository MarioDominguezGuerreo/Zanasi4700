// SerialComm.h: interface for the SerialComm class.



class SerialComm  
{
	protected:
		HANDLE hFile;
		char szCommLineName[20];
		char szCommDef[ 100];
		//OVERLAPPED  wol, rol, evol;
   		DWORD dwOlWriteCnt, dwOlReadCnt, dwWaitResult;
		DWORD EventFlag;
		char szInputBuff[ 256];
		DWORD dwNextBuf, dwNextUser;
		char TermChar, NullChar, SubChar;
		BOOL bResetRequired;
		COMMTIMEOUTS commtime;
	protected:
		BOOL InitCommLine( void );
		BOOL Transfer( LPSTR  lpBuffer, DWORD dwMaxChar);

	public:
		SerialComm();
		~SerialComm();
	public:

		BOOL OpenComm( 	LPCTSTR lpszName, LPCTSTR lpszDef,char EndOfLine = '\r');
		void CloseComm( void);
		void Purge( void);
		BOOL WriteComm( LPCVOID  lpBuffer, DWORD  nNumberOfBytesToWrite = 0);
		BOOL ReadComm( 	LPSTR  lpBuffer,
						DWORD nNumberOfByteToRead,
						LPDWORD nNumberOfBytesRead,
						DWORD MinCharsExpected = 1);
		BOOL SetReadTimeouts(	DWORD CharInterval,
								DWORD CharMult,
								DWORD Total);
		BOOL SetWriteTimeouts(	DWORD CharMult,
								DWORD Total);
		BOOL IsOpen( void);
};
