//System Libraries
//#include "StdAfx.h"
#ifndef _WINSOCKAPI_
#define _WINSOCKAPI_
#endif
#include <winsock2.h>
#include <string.h>
#include <process.h>
#include <windows.h>
#include <iostream>
#include <winnt.h>
#include <stdlib.h>
#include <stdio.h>

//Project Libraries
#include "machcomm.h"
#include "TCPIPComm.h"

#pragma comment (lib,"ws2_32.Lib")
#pragma comment (lib,"Mswsock.Lib")
#pragma comment (lib,"AdvApi32.Lib")


TCPIPComm::TCPIPComm(void)
{

}


TCPIPComm::~TCPIPComm(void)
{

}

bool TCPIPComm::Init()
{
	bool bSucc =  false;
	printf_s("\nTCP/IP-Initilazing winsock\n");
	if(WSAStartup(MAKEWORD(2,2),&wsa)!=0)
		printf_s("\nTCP/IP-Winsock Error: %d\n",WSAGetLastError());
	else
	{
		printf_s("\nTCP/IP-Winsock Ready\n");	
		bSucc = true;
	}
	return bSucc;
}
bool TCPIPComm::CreateSocket()
{
	bool bSucc =  false;
	if((s = socket(AF_INET,SOCK_STREAM,0))== INVALID_SOCKET)
		printf_s("\nTCP/IP-Socket Error: %d\n",WSAGetLastError());
	else
	{
		printf_s("\nTCP/IP-Socket Ready\n");	
		bSucc = true;
	}
	return bSucc;
}
bool TCPIPComm::Connect()
{
	bool bSucc = false;
	//strcpy_s(IP,"192.168.1.20");	//IP
	strcpy_s(IP,"127.0.0.1");		//IP
	Port = 5025;					//Port
	//Server Parameters
	server.sin_addr.s_addr = inet_addr(IP);
	server.sin_family = AF_INET;
	server.sin_port = htons(Port);
	//Server Connection
	int ConnectionStatus =  connect(s,(struct sockaddr*)& server, sizeof(server));
	if(ConnectionStatus > 0)
	{
		printf_s("\nTCP/IP-Connection Error\n");
		TCPIPRunning = false;
	}
	else
	{
		printf_s("\nTCP/IP-Connected\n");
		TCPIPRunning = true;
	}
	return bSucc = TCPIPRunning;
}
void TCPIPComm::Disconnect()
{
	closesocket(s);
	WSACleanup();
	Kill();
	TCPIPRunning = false;
}

//TCP/IP Send Data 
void TCPIPComm::Send(const char* SCPI_cmd)
{
	printf_s("\nTCP/IP-Data sent: %s\n",SCPI_cmd);
	//Send
	Enviar = send(s,SCPI_cmd,strlen(SCPI_cmd),0);
	if(Enviar == SOCKET_ERROR)
	{
		printf_s("\nTCP/IP-Data sent Error\n");
		closesocket(s);
		WSACleanup();
	}
}
//TCP/IP Receive Data
void TCPIPComm::Recv()
{
	//Receive
	Recibir = recv(s,server_reply,2000,0);
	if(Recibir > 0)
		printf_s("TCP/IP: %s",server_reply);
	else
	{
		if(strcmp(server_reply,"exit")==0)
		{
			printf_s("\nTCP/IP-Data received Error\n");
			Recibir = 0;
			Disconnect();
		}
	}
}
//SCPI Commands
void TCPIPComm::Commands(const char* Command)
{
	switch(Command[0])
	{
		case 's':
			switch(Command[1])
			{
				case '1':
					break;
				default:
					break;
			}
			break;
		default:
			break;
	}
}

//Zanasi Command Functions
// Build Zanasi Command process
void TCPIPComm::BuildZanasiCommand()
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
		   Send(Line_Command);
		   printf("Sent: %17.5s ->",Line_Command);
		   //Wait 100 ms
		   Sleep(200); 
		}
		//Trigger to Print
		printf("Trigger to Print\n");
	}
}
// Send the information to the Printer
void TCPIPComm::SendInfoToPrinter(int oLine)
{
	//Random Serial Number 10000-20100
	int random = 10000 + (rand() % 20100);
	//Convert to String Random serial number
	itoa(random, mLine[eLine3].Command,10);
	//Get the information from Lines 1,2,3 of the current fixture
	WrapMsgLine_To_ZanasiCommand(mLine[oLine].Command ,oLine);
	//Convert to ASCII characteres
	for(int i=0;i<sizeof(msgWrapped); i++){Line_Command[i] = (char)msgWrapped[i];}
}
// Wrap the message to Zanasi Command
void TCPIPComm::WrapMsgLine_To_ZanasiCommand(const char* msg, int Line)
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
	for(int i=0;i<MsgMaxSize; i++) {byteMessage[i] = (byte)msg[i];}

	//Control Bytes (0-4)
	msgWrapped[eHead]		= Head;
	msgWrapped[eSetQuery]	= SetQuery; 
	msgWrapped[eLineIndex]	= mLine; 
	msgWrapped[eMsgIndex]	= MsgIndex; 
	msgWrapped[eMsgSize]	= MsgSize; 
	//Message in Bytes (5-16)
	for(int j=0; j<MsgMaxSize; j++) {msgWrapped[j+5] = byteMessage[j];}
}

//Thread definition
unsigned __stdcall CTCPIPCommStart(void *vptr)
{
	TCPIPComm *pTCPIPCommTHREAD = (TCPIPComm*)vptr;
	pTCPIPCommTHREAD->Tick();
	return 0;
}
//Thread initialization
BOOL TCPIPComm::Startup(int nPriority)
{
	bool bSucc =false;
	hThread = (HANDLE) _beginthreadex(NULL,0,&CTCPIPCommStart,this,0,&nThreadId);
	if(hThread != NULL)
	{
		SetThreadPriority(hThread,nPriority);
		bSucc = true;
	}
	return bSucc;
}
//Thread Loop
void TCPIPComm::Tick()
{
	while(TCPIPRunning)
	{
		Recv();
	}
}
//Stop Thread
void TCPIPComm::Kill()
{
	WaitForSingleObject(hThread,2000);
}
