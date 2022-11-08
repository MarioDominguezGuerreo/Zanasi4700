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
	//Printer Status
	TCPIPRunning = false;
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

	for(int i= 0;i<12,i++;)
	{
		for(int i= 0;i<3,i++;)
		{
			strcpy_s( mFix[i].mLine[eLine1].Command,"0");
		}	
	}
	
	for(int i= 0;i<12,i++;)
	{
		//Customer ID
		strcpy_s( mFix[i].mLine[eLine1].Command,"CSE-SENSATA");
		//Device ID	
		strcpy_s( mFix[i].mLine[eLine2].Command,"Nov102020TEW");
	}
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
	Port = 9999;					//Port
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
bool TCPIPComm::Send(const char* comando)
{
	bool bSucc = false;
	//Send
	Enviar = send(s,comando,strlen(comando),0);
	if(Enviar == SOCKET_ERROR)
	{
		printf_s("\nTCP/IP-Data sent Error\n");
		closesocket(s);
		WSACleanup();
	}
	else
		bSucc = true;

	return bSucc;
}
bool TCPIPComm::Send(int nFix, int nline)
{
	bool bSucc = false;
	//Send
	Enviar = send(s,mFix[nFix].mLine[nline].Command,strlen(mFix[nFix].mLine[nline].Command),0);
	if(Enviar == SOCKET_ERROR)
	{
		printf_s("\nTCP/IP-Data sent Error\n");
		closesocket(s);
		WSACleanup();
	}
	else
		bSucc = true;

	return bSucc;
}
bool TCPIPComm::Send()
{
	bool bSucc = false;
	//Send
	Enviar = send(s,Line_Command,strlen(Line_Command),0);
	if(Enviar == SOCKET_ERROR)
	{
		printf_s("\nTCP/IP-Data sent Error\n");
		closesocket(s);
		WSACleanup();
	}
	else
		bSucc = true;

	return bSucc;
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
void TCPIPComm::ClearPackage()
{
	/*
	for(int i= 0;i<12;i++)
	{
		for(int j= 0;j<3,j++;)
		{
			strcpy_s(mFix[i].mLine[j].Command,"0");
		}	
	}
	*/
	for(int i= 0;i<12;i++)
	{
		//Customer ID
		strcpy_s( mFix[i].mLine[eLine1].Command,"CSE-SENSATA");
		//Device ID	
		strcpy_s( mFix[i].mLine[eLine2].Command,"Nov102020TEW");
	}
	//Clear
	for(int k=0; k<MsgMaxSize; k++)
	{
		msgWrapped[k] = 0x00;
	}
}
//Zanasi Command Functions
// Build Zanasi Command process
void TCPIPComm::BuildZanasiCommand()
{
	bool bSucc = false;
	char szMsg[100]; //12,3
	ClearPackage();
	//Printing sequence
	//Fixtures
	for(int i=0; i<FixSize; i++) 
	{
		//strcpy(szMsg,""); 
		//Lines
		for(int k=0; k<LineSize; k++) 
		{
		   //Prepare the Zanasi Command
		   PrepareInfoToPrinter(i,k);
		   
		   sprintf(szMsg,"%d,%d,",i,k); //Add Fix number and Line Number
		   strcat(szMsg,mFix[i].mLine[k].Command); //Wrap complete message
		   strcpy(mFix[i].mLine[k].Command,szMsg); //swap

		   bSucc = Send(i,k);
		   if(bSucc) printf(" ->TCP/IP Printer: %s",szMsg/*Line_Command*/);
		   Sleep(100);
		}
		//Trigger to Print
		printf("Trigger to Print\n");
	}
	Send("Ready");		
}
// Send the information to the Printer
void TCPIPComm::PrepareInfoToPrinter(int nFix, int nLine)
{
	//Random Serial Number 10000-20100
	int random = 10000 + (rand() % 210150);
	//Convert to String Random serial number
	itoa(random, mFix[nFix].mLine[eLine3].Command,10);
	//Get the information from Lines 1,2,3 of the current fixture
	WrapMsgLine_To_ZanasiCommand(mFix[nFix].mLine[nLine].Command ,nLine);
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
