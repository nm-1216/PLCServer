using HslCommunication.Core;
using PLCServer.PLC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    public partial class FrmMain : Form
    {

        public FrmMain()
        {
            InitializeComponent();
        }

        PLC _Plc;
        void abc(IReadWriteNet my){}

        private void FrmMain_Load(object sender, EventArgs e)
        {
            _Plc = PLC.CreateInstance();

            var aaaaaa = PLCServer.PLCServers.KeyValues;

            //PLC 写
            _Plc.myPlcA.Write("M1", true);
            _Plc.myPlcB.Write("M2", true);

            //PLC 事件
            //_Plc.myPlcA.DataChange += new PLCServer.PLC.PLCEvent_DataChangeEventHandler(abc);
            //_Plc.myPlcA.DataReader += new PLCEvent_DataReaderEventHandler(abc);
            //_Plc.myPlcA.StatusChange += new PLCEvent_StatusChangeEventHandler(abc);

            //PLC 读取
            //var m1 = PLCServer.PLCServers.KeyValues["A.M1"];
            //var BDB100 = PLCServer.PLCServers.KeyValues["B.DB1.0.0"];

            //string _error;
            //var values = PLCServer.PLCServers.ReturnValue(new string[] { "A.M1", "B.DB1.0.0" }, out _error);
            //var v1 = values[0];
            //var v2 = values[1];

            ////PLC 读取
            //var tmp1 = _Plc.myPlcA.ReadBool("M1");
            //var tmp2 = _Plc.myPlcA.ReadInt32("M2");
            //var tmp3 = _Plc.myPlcA.ReadFloat("M3");
        }
    }
}
