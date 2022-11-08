// System Libraries
#include <iostream>
#include <winsock2.h>
#include <winnt.h>
#include <process.h>
#include <windows.h>
#include <string.h>

using namespace std;

// Project Libraries
#include "Printcomm.h"
#include "TCPIPComm.h"


//Objects
PrintComm* OPrintcomm = new PrintComm;
TCPIPComm* OTCPIPComm = new TCPIPComm;

//HMI
int main(void)
{
	bool bSucc = false;

	//Initialization of the Zanasi 4700 TCP/IP communication 
	bSucc = OTCPIPComm->Init();
	//Create Socket
	if(bSucc) 
		bSucc = OTCPIPComm->CreateSocket();
	//Connect
	if(bSucc) 
		bSucc = OTCPIPComm->Connect();
	//TCP/IP Communication Thread
	if(bSucc) 
		bSucc = OTCPIPComm->Startup(THREAD_PRIORITY_NORMAL);
	//TCP/IP Communication is ready
	bSucc &= OTCPIPComm->TCPIPRunning;
	//Zanasi 4700 Command sequence
	for(int i=0; i<1; i++)
	{
		if(bSucc) 
		OTCPIPComm->BuildZanasiCommand();	
		Sleep(2000);
	}

	OTCPIPComm->TCPIPRunning = false;

	//Initialization of the Zanasi 4700 RS232 communication 
	//Virtual Serial port COM 2
	//bSucc &= OPrintcomm->Connect();
	//RS232 Communication thread
	//if(bSucc) OPrintcomm->PrintCommRunning = OPrintcomm->Startup(THREAD_PRIORITY_NORMAL);
	//Zanasi 4700 Command sequence
	//if(OPrintcomm->PrintCommRunning) OPrintcomm->BuildZanasiCommand();
	

	system("pause");
	return 0;
}