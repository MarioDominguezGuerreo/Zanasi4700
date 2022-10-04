//Mario A. Dominguez Guerrero 
//July - 2020

#region System Libraries
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

#region project Libraries

#endregion

namespace Zanasi4700
{
    class machcomm
    {
        #region Variables
        //Result Codes
        public string[] ResultCodes = new string[]
        {
            "No Result",
            "Good",
            "No Read 2D Code",
            "Prior Op",
            "Low Limit Force",
            "High Limit Force",
            "Low Limit Dis",
            "High Limit Disp",
            "Wrong 2D Code Label",
            "Machine Failure",
            "Low Limit Temp",
            "High Limit Temp",
            "Error Measurement",
            "Check Components",
            "Assign Components"
        };
        #endregion

        #region Functions
        //Manage the Result Codes
        public string ResultCode(int Code)
        {
            string msg = ResultCodes[Code];
            return msg;
        }
        #endregion
    }

    #region LotManager
    enum LotManager_parameters
    {
        LotActive
    }
    #endregion

    #region Production Process Parameters

    enum ProcessNumber
    {
        Process1,
        Process2,
        Process3
    }

    enum StepNumber
    {
        Step1,
        Step2,
        Step3,
        Step4,
        Step5,
        Step6,
        Step7,
        Step8,
        //A14832, DOGMA, 30/June/2021
        StepTempChk,
        //A14172-CP, DOGMA, 16/August/2021
        Step_CheckComponents,
        Step_AssignComponents
    }

    enum StatusNo
    {
        NG,
        OK,
        Omitted,
        Rework,
        Wait,
        InProcess,
        Done
    }

    #region Master Parameters
    enum MasterProcessStatus
    {
        Ommitted,
        Waiting,
        Done,
        Fail,
        Good,
    }

    ///Masters
    /// [0] = Serial
    /// [1] = Device ID
    /// [2] = Station
    /// [3] = Status
    /// [4] = Expected Value
    /// [5] = Sequence Number
    /// [6] = Nest
    enum MastersParameters
    {
        SequenceNo,
        Satus,
        ExpecValue
    }
    #endregion

    //Result Codes for Production
    enum ResultCodes
    {
        NoResult,
        Good,
        NoRead2D,
        PriorOp,
        LowLimitForce,
        HighLimitForce,
        LowLimitDisplacement,
        HighLimitDisplacement,
        Wrong2DLabel,
        MachineFailure,
        LowLimitTemp,
        HighLimitTemp,
        //A14832, DOGMA, 30/June/2021
        ErrorMeas,
        CheckComponents,
        AssignComponents
    }

    enum Measurements
    {
        Force,
        Displacement,
        CanTemp
    }

    #endregion

    #region CSV File Machine Settings
    enum CSV_MachConfig
    {
        SoftwareVersion,
        SoftwareVersionDate,
        MachineName,
        StationID,
        EquipmentID,
        PartListID,
        ElectricalDrawingID,
        SerialMachine,
        SQLServerName,
        SQLDBName,
        SQLUser,
        AppRoleUser,
        PriorOpCheck,
        UpdateDeviceStatus,
        DeviceIDTable,
        StationName,
        PLCEnable,
        PLCIP,
        PLCProgramVersion,
        PLCProgramVersionDate,
        PLCProgramName,
        SafetyPLCEnable,
        SafetyPLCIP,
        SafetyPLCPort,
        SafetyPLCProgramVersion,
        SafetyPLCProgramDateVersion,
        SafetyPLCProgramName,
        PCName,
        PCIP,
        PCDNS,
        ScannerIP,
        ScannerPort,
        Instrument1IP,
        Instrument1Port,
        MachineNumber,
        LimitsOperParams,
        ResultsHistory,
        MasterPartsSeqView,
        DeviceFamily,
        UltraFlexCOM,
        UltraFlexBaud,
        FestoControllerIP,
        FestoControllerPort,
        FestoControllerProgramVersion,
        FestoControllerProgramDateVersion,
        FestoControllerProgramName,
        CheckComponents,
        AssignComponents
    }

    enum Devices
    {
        PLC,
        SafetyPLC,
        Scanner,
        Kistler,
        ThermalCamera,
        InductiveHeater,
        ServoPress
    }
    #endregion

    #region SQL Server & Batabase Parameters
    //Lot & Production
    enum Prod_Lot
    {
        DeviceID,
        LotID,
        PartStatus
    }
    //Instrument 1
    enum Instrument_1
    {
        DeviceID,
        ChXmin,
        ChXmax,
        LimitTol,
        ChYmin,
        ChYmax,
        //A14832, DOGMA, 30/June/2021
        CanTemp_min,
        CanTemp_max,
        HeaterTemp,
        ServoPress_Prog,
    }
    enum Printing
    {
        DeviceID,
        Format,
        LayoutNo,
        Parameter1,
        Parameter2,
        Parameter3,
    }

    #endregion

    #region PLC & Safety PLC Parameters
    /// PLC Communicacion parameters[#]
    /// 0 = Communication Status (Disconnected = 0, Connected = 1)
    /// 1 = Read / Write Coils, (Read = 0, Write = 1)
    /// 2 = Control (Disable = 0 / Enable = 1)
    enum PLC_Comm
    {
        CommStatus,
        RW_Coils,
        Control
    }

    #endregion

    #region Scanner
    /// 0 = Communication Status (Disconnected = 0, Connected = 1)
    /// 1 = 
    /// 2 = Control (Disable = 0 / Enable = 1)
    enum Scanner_Comm
    {
        CommStatus,
        RW_Coils,
        Control
    }

    #endregion

    #region Instrument
    /// 0 = Communication Status (Disconnected = 0, Connected = 1)
    /// 1 = 
    /// 2 = Control (Disable = 0 / Enable = 1)
    enum Instrument_Comm
    {
        CommStatus,
        RW_Coils,
        Control
    }
    //A14832, DOGMA, 30/June/2021
    enum ThermalCam
    {
        PIF,
        Flag,
        Flag1,
        CamSN,          //Serial Number
        Temperature,    //Temperature
        FrameCnt,
        IPC             //Status of the Interoperability communication with the PIX App
    }
    enum UltraFlex_ReqCMD
    {
        GetStatus,
        GetError,
        GetFreq,
        GetVoltage,
        GetCurrent,
    }
    enum UltraFlex_ResCMD
    {
        HeatON,
        HeatOFF,
    }

    #region Servo Press
    enum ServoPos
    {
        Pos1 = 256,
        Pos2 = 512,
        Pos3 = 768,
        Pos4 = 1024,
        Home = 0
    }
    enum Servo_SCON_SPOS
    {
        Halt,
        ACK,
        MC,
        Teach,
        Move,
        FoError,
        Still,
        Ref,
        Enable,
        Open,
        Warning,
        Fault,
        VLoad,
        FCTMMI,
        OPM1,
        OPM2
    }
    enum Servo_CCON_CPOS
    {
        Halt,
        Start,
        Home,
        JogUp,
        JogDown,
        Teach,
        Clear,
        Reserved1,
        Enable,
        Stop,
        Brake,
        Reset,
        Reserved2,
        Lock,
        OPM1,
        OPM2
    }
    #endregion

    #endregion
}
