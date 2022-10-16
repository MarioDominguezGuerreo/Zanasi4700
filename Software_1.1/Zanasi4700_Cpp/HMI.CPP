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


//Objects
PrintComm* OPrintcomm = new PrintComm;

//HMI
int main(void)
{
	bool bSucc = false;

	//Printer Connect
	bSucc = OPrintcomm->Connect();
	
	if(bSucc)
	{
		//Printer thread
		OPrintcomm->PrintCommRunning = OPrintcomm->Startup(THREAD_PRIORITY_NORMAL);
		//Start Sequence
		OPrintcomm->BuildZanasiCommand();
	}

	system("pause");
	return 0;
}