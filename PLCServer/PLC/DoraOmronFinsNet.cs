using HslCommunication.Core;
using HslCommunication.Profinet.Omron;
using System.Collections.Generic;

namespace PLCServer.PLC
{
    public class DoraOmronFinsNet : OmronFinsNet, IPLC
    {
        public DoraOmronFinsNet() : base()
        {
            KeyValues = new Dictionary<string, object>();

        }

        public DoraOmronFinsNet(string ipAddress, int port) : base(ipAddress, port)
        {
            KeyValues = new Dictionary<string, object>();

        }

        public event PLCEvent_DataChangeEventHandler DataChange;
        public event PLCEvent_DataReaderEventHandler DataReader;
        public event PLCEvent_StatusChangeEventHandler StatusChange;
        public string Name { get; set; }
        public new IByteTransform ByteTransform { get { return base.ByteTransform; } }
        public Dictionary<string, object> KeyValues { get; set; }

        public void StartScan()
        {
            throw new System.NotImplementedException();
        }
    }
}