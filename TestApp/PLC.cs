using HslCommunication.Core;
using PLCServer;
using PLCServer.PLC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class PLC
    {
        public IPLC myPlcA;
        public IPLC myPlcB;
        public IPLC myPlcC;

        private PLC()
        {
            ServerFactory.CreatePLCServer();

            myPlcA = PLCServers.GetServer("Crane1");
            myPlcA.StartScan();

            myPlcB = PLCServers.GetServer("Crane2");
            myPlcB.StartScan(); 

            myPlcC = PLCServers.GetServer("C");
            //myPlcC.StartScan();
        }

        private static PLC _Singleton = null;
        private static object Singleton_Lock = new object();
        public static PLC CreateInstance()
        {
            if (_Singleton == null)
            {
                lock (Singleton_Lock)
                {
                    if (_Singleton == null)
                    {
                        _Singleton = new PLC();
                    }
                }
            }
            return _Singleton;
        }
    }
}
