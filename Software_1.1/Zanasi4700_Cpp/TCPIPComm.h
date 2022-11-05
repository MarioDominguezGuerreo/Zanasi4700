//System Libraries
#include <iostream>
#include <winsock2.h>
#include <winnt.h>
#include <process.h>
#include <windows.h>
#include <string.h>
#include <stdlib.h>
#include <stdio.h>

class TCPIPComm
{
public:
	TCPIPComm(void);
	~TCPIPComm(void);
public:
	/*TCP/IP Configuration*/
	WSADATA wsa;
	SOCKET s;
	struct sockaddr_in server;
	char server_reply[2000];
	int Recibir;
	int Enviar;
	char IP[80];
	int Port;
public: 
	/*THREAD*/
	BOOL Startup(int nPriority);
	void Kill();
	void Tick();
	HANDLE hThread;
	unsigned int nThreadId;
	/*CONNECTION*/
	bool Init();
	bool CreateSocket();
	bool Connect();
	void Disconnect();
	/*COMMUNICATION*/
	void Send(const char* SCPI_cmd);
	void Recv();
	void Commands(const char* Command);
public:
	bool TCPIPRunning;
	/*SCPI Commands*/
	struct SCPI_Msg {char Command[100];};
	SCPI_Msg mSCPI[5];
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
unsigned __stdcall CTCPIPCommStart(void *vptr);

