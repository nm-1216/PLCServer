using HslCommunication;
using HslCommunication.Core;
using HslCommunication.Profinet.Siemens;
using PLCServer.Config;
using System.Collections.Generic;
using System.Threading;

namespace PLCServer.PLC
{
    public class DoraSiemensS7Net : SiemensS7Net, IPLC
    {
        public DoraSiemensS7Net(SiemensPLCS siemens) : base(siemens)
        {
        }

        public DoraSiemensS7Net(PLCServerConfig config) : base(config.Siemens, config.IpAddress)
        {
            _config = config;
            Name = config.Name;
        }

        public new IByteTransform ByteTransform { get { return base.ByteTransform; } }
        public event PLCEvent_DataChangeEventHandler DataChange;
        public event PLCEvent_DataReaderEventHandler DataReader;
        public event PLCEvent_StatusChangeEventHandler StatusChange;

        public string Name { get; set; }

        internal bool ConnectionState = true;
        private readonly PLCServerConfig _config;
        public Dictionary<string, object> KeyValues { get; set; }

        public void StartReader()
        {
            DataReader?.Invoke(this);
        }

        public void StartScan()
        {
            Thread oGetArgThread = new Thread(new System.Threading.ThreadStart(() =>
            {
                while (true)
                {
                    Thread.Sleep(100);

                    foreach (var item in _config.List)
                    {
                        var tmp= Utils._ReadObject(this, item);
                        if (ConnectionState != tmp)
                        {
                            ConnectionState = tmp;
                            StatusChange?.Invoke(this, tmp);
                        }
                    }
                }
            }));
            oGetArgThread.IsBackground = true;
            oGetArgThread.Start();
        }


        #region Write

        public new OperateResult Write(string address, bool value)
        {
            var tmp = _config.List.Find(b => b.Name == address);
            if (null != tmp)
                return base.Write(tmp.Address, value);
            else
                return new OperateResult(address + "标签不存在");
        }

        public new OperateResult Write(string address, short value)
        {
            var tmp = _config.List.Find(b => b.Name == address);
            if (null != tmp)
                return base.Write(tmp.Address, value);
            else
                return new OperateResult(address + "标签不存在");
        }

        public new OperateResult Write(string address, int value)
        {
            var tmp = _config.List.Find(b => b.Name == address);
            if (null != tmp)
                return base.Write(tmp.Address, value);
            else
                return new OperateResult(address + "标签不存在");
        }

        public new OperateResult Write(string address, float value)
        {
            var tmp = _config.List.Find(b => b.Name == address);
            if (null != tmp)
                return base.Write(tmp.Address, value);
            else
                return new OperateResult(address + "标签不存在");
        }

        public new OperateResult Write(string address, double value)
        {
            var tmp = _config.List.Find(b => b.Name == address);
            if (null != tmp)
                return base.Write(tmp.Address, value);
            else
                return new OperateResult(address + "标签不存在");
        }

        public new OperateResult Write(string address, string value)
        {
            var tmp = _config.List.Find(b => b.Name == address);
            if (null != tmp)
                return base.Write(tmp.Address, value);
            else
                return new OperateResult(address + "标签不存在");
        }

        #endregion

    }
}