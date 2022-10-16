// PrintComm.h: interface for the PrintComm class.

//System Libraries
#include <iostream>
#include <winnt.h>
#include <process.h>
#include <windows.h>
#include <string.h>
#include <stdlib.h>
#include <stdio.h>

//Project Libraries
#include "SerialComm.h"

class PrintComm:public SerialComm
{
	public:
		PrintComm(void);
		~PrintComm(void);
	public:
		/*THREAD*/
		bool Startup(int nPriority);
		void Kill();
		void Tick();
		HANDLE hThread;
		unsigned int nThreadId;
		bool PrintCommRunning;

	public: 
		/*Serial Communication(RS232)*/
		bool Connect();
		bool Disconnect();
		void Send();
		void Received();
		char RS232_Name[10];
		char RS232_Config[200];
		//Zanasi Commands
		char ZanasiCMD_Connected[20];

	public:
		/*Zanasi 4700: Structure Command*/

		int FixSize;		
		int LineSize;	
		int MsgMaxSize;	
					
		BYTE Head;			
		BYTE SetQuery;		
		BYTE LineIndex0;	
		BYTE LineIndex1;	
		BYTE LineIndex2;	
		BYTE MsgIndex;		
		BYTE MsgSize;		
		BYTE Space;		

		/*Zanasi 47000 definitions*/
		// Line  Hex:		[0x23]	[0xA3]	[0x00]	[0x00]	[0x0C]	Message converted to bytes
		// Line	 Position:	[0]		[1]		[2]		[3]		[4]		[5-16]
		BYTE msgWrapped[17];
		BYTE byteMessage[12];
		char Line_Command[17];
		struct cmdLine { char Command[100];};
		cmdLine mLine[3];

		void BuildZanasiCommand();
		void SendInfoToPrinter(int Line);
		void WrapMsgLine_To_ZanasiCommand(const char* msg, int Line);
			
};

unsigned __stdcall CPrintCommStart(void *vptr);

