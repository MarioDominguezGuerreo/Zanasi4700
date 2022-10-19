// PrintComm.cpp: implementation of the PrintComm class.
//
//////////////////////////////////////////////////////////////////////
//System Libraries
#include <string.h>
#include <process.h>
#include <windows.h>
#include <iostream>
#include <winnt.h>
#include <stdlib.h>
#include <stdio.h>


//Project Libraries
#include "PrintComm.h"
#include "machcomm.h"


//////////////////////////////////////////////////////////////////////
// Construction/Destruction
//////////////////////////////////////////////////////////////////////

PrintComm::PrintComm()
{
	//Serial communication data
	//NOTE: COM name must be 0-9. 
	strcpy_s(RS232_Name, "COM1");
	strcpy_s(RS232_Config, "baud=19200 parity=N data=8 stop=1");
	//Initialize command
	strcpy_s(ZanasiCMD_Connected, "Zanasi_Connected");

	//Printer Status
	PrintCommRunning = false;
	//Zanasi 4700 data
	FixSize		= 12;
	LineSize	= 3;
	MsgMaxSize	= 12;
				
	Head		= 0x23;
	SetQuery	= 0xA3;
	LineIndex0	= 0x00; // Line Index: 0, into the Zanasi Message
	LineIndex1	= 0x01;	// Line Index: 1, into the Zanasi Message
	LineIndex2	= 0x02;	// Line Index: 2, into the Zanasi Message
	MsgIndex	= 0x00;	// Message Index: 0, into the Zanasi Software
	MsgSize		= 0x0C;	// 12 characters
	Space		= 0x20;	// Space

	//Customer ID
	strcpy_s(mLine[eLine1].Command,"CSE-SENSATA");
	//Device ID	
	strcpy_s(mLine[eLine2].Command,"15102020TEW");
}

PrintComm::~PrintComm()
{

}

//Serial communication (RS232)
// Connect to COM port
bool PrintComm::Connect()
{
	bool bSucc = false;

	bSucc = OpenComm(RS232_Name,RS232_Config);
	bSucc &= SetReadTimeouts(100,0,2500);

	if(bSucc) 
	{
		printf("Printer Connected\n");
		WriteComm(ZanasiCMD_Connected,sizeof(ZanasiCMD_Connected));
	}
	else	
		printf("Printer Connection Failed \n");

	return bSucc;
}
// Disconnect from COM port
bool PrintComm::Disconnect()
{
	bool bSucc = false;

	return bSucc;
}
// Send command to COM port
void PrintComm::Send()
{
	
}
// Receive from COM port
void PrintComm::Received()
{
	
}

//Zanasi Command Functions
// Build Zanasi Command process
void PrintComm::BuildZanasiCommand()
{
	//Clear
	for(int j=0; j<MsgMaxSize; j++)
	{
		msgWrapped[j] = 0x00;
	}
	//Printing sequence
	//Fixtures
	for(int i=0; i<FixSize; i++) 
	{
		//Lines
		for(int k=0; k<LineSize; k++) 
		{
		   //Prepare the Zanasi Command
		   SendInfoToPrinter(k);
		   //Send Zanasi Command to Serial Port
		   WriteComm(Line_Command,sizeof(Line_Command));
		   printf("Write: %17.5s ->",Line_Command);
		   //Wait 100 ms
		   Sleep(1000); 
		}
		//Trigger to Print
		printf("Trigger to Print\n");
	}
}
// Send the information to the Printer
void PrintComm::SendInfoToPrinter(int oLine)
{
	//Random Serial Number 10000-20100
	int random = 10000 + (rand() % 20100);
	//Convert to String Random serial number
	itoa(random, mLine[eLine3].Command,10);
	//Get the information from Lines 1,2,3 of the current fixture
	WrapMsgLine_To_ZanasiCommand(mLine[oLine].Command ,oLine);
	//Convert to ASCII characteres
	for(int i=0;i<sizeof(msgWrapped); i++)
	{
		Line_Command[i] = (char)msgWrapped[i];
	}
}
// Wrap the message to Zanasi Command
void PrintComm::WrapMsgLine_To_ZanasiCommand(const char* msg, int Line)
{
	//Clear
	BYTE mLine = LineIndex0;
	//Select the Line Index
	switch(Line)
	{
		case 0:
			mLine = LineIndex0;break;
		case 1:
			mLine = LineIndex1;break;
		case 2:
			mLine = LineIndex2;break;
		default:
			mLine = LineIndex0;break;
	}
	//Conversion Char[] to Bytes[]
	for(int i=0;i<MsgMaxSize; i++)
	{
		byteMessage[i] = (byte)msg[i];
	}
	//Control Bytes (0-4)
	msgWrapped[eHead]		= Head;
	msgWrapped[eSetQuery]	= SetQuery; 
	msgWrapped[eLineIndex]	= mLine; 
	msgWrapped[eMsgIndex]	= MsgIndex; 
	msgWrapped[eMsgSize]	= MsgSize; 
	//Message in Bytes (5-16)
	for(int j=0; j<MsgMaxSize; j++)
	{
		msgWrapped[j+5] = byteMessage[j];
	}
}


//Thread definition
unsigned __stdcall CPrintCommStart(void *vptr)
{
	PrintComm *pPrintCommTHREAD = (PrintComm*)vptr;
	pPrintCommTHREAD->Tick();
	return 0;
}
//Thread startup
bool PrintComm::Startup(int nPriority)
{
	bool bSucc = false;
	

	hThread = (HANDLE) _beginthreadex(NULL,0,&CPrintCommStart,this,0,&nThreadId);

	if(hThread != NULL)
	{
	  SetThreadPriority(hThread, nPriority);
	  bSucc = true;
	}

	return bSucc;	
}
//Thread loop
void PrintComm::Tick()
{
	
	while(PrintCommRunning)
	{
		//Do something bro
		
		Sleep(50);
	}
}
//Stop Thread
void PrintComm::Kill()
{
	WaitForSingleObject(hThread,2000);
}
