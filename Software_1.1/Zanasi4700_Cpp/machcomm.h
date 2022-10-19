
/*ODBC Datasource x32Bits*/

#define oDBC_Name			= "ZanasiDB"
#define DeviceIDListQuery	= "SELECT * FROM ZanasiTable"
#define PrintLinesQuery		= "SELECT * FROM ZanasiTable WHERE DeviceID"

enum eODBCLimits 
{
	eLine1,
	eLine2,
	eLine3
};

enum ZanasiCMD 
{
	eHead,
	eSetQuery,
	eLineIndex,
	eMsgIndex,
	eMsgSize
};
