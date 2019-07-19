using System.Collections.Generic;
using System.Linq;
using System.Threading;
using HslCommunication;
using HslCommunication.Core;
using HslCommunication.Profinet.Melsec;
using PLCServer.Config;

namespace PLCServer.Provider
{
    public class DoraMelsecMcNet : MelsecMcNet, IPLC
    {
       
        // ReSharper disable once UnusedMember.Global
        public DoraMelsecMcNet(string ip, int port) : base(ip, port)
        {
        }

        public DoraMelsecMcNet(PLCServerConfig config) : base(config.IpAddress, config.Port)
        {
            Config = config;
            Name = config.Name;
        }

        public new IByteTransform ByteTransform
        {
            get { return base.ByteTransform; }
        }

        public event PLCEvent_DataChangeEventHandler DataChange;
        public event PLCEvent_DataReaderEventHandler DataReader;
        public event PLCEvent_StatusChangeEventHandler StatusChange;

        public string Name { get; set; }

        private bool _connectionState = true;

        public PLCServerConfig Config { get; private set; }

        public void StartReader()
        {
            DataReader?.Invoke(this);
        }

        public void StartScan()
        {
            Thread myThread = new Thread(() =>
            {
                while (true)
                {
                    Thread.Sleep(100);
                    var data = new Dictionary<string, object>();

                    foreach (var item in Config.List)
                    {
                        var tmp = Utils._ReadObject(this, item, ref data);
                        if (_connectionState != tmp)
                        {
                            _connectionState = tmp;
                            StatusChange?.Invoke(this, tmp);
                        }
                    }

                    if (data.Any())
                    {
                        DataChange?.Invoke(this, data);
                        data.Clear();
                    }
                }

                // ReSharper disable once FunctionNeverReturns
            }) {IsBackground = true};
            myThread.Start();
        }

        #region Write

        public new OperateResult Write(string name, bool value)
        {
            var tmp = Config.List.Find(b => b.Name == name);
            if (null != tmp)
                return base.Write(tmp.Address, value);
            else
                return new OperateResult($"Tag Name {name} can't find");
        }

        public new OperateResult Write(string name, short value)
        {
            var tmp = Config.List.Find(b => b.Name == name);
            if (null != tmp)
                return base.Write(tmp.Address, value);
            else
                return new OperateResult($"Tag Name {name} can't find");
        }

        public new OperateResult Write(string name, int value)
        {
            var tmp = Config.List.Find(b => b.Name == name);
            if (null != tmp)
                return base.Write(tmp.Address, value);
            else
                return new OperateResult($"Tag Name {name} can't find");
        }

        public new OperateResult Write(string name, long value)
        {
            var tmp = Config.List.Find(b => b.Name == name);
            if (null != tmp)
                return base.Write(tmp.Address, value);
            else
                return new OperateResult($"Tag Name {name} can't find");
        }

        public new OperateResult Write(string name, float value)
        {
            var tmp = Config.List.Find(b => b.Name == name);
            if (null != tmp)
                return base.Write(tmp.Address, value);
            else
                return new OperateResult($"Tag Name {name} can't find");
        }

        public new OperateResult Write(string name, double value)
        {
            var tmp = Config.List.Find(b => b.Name == name);
            if (null != tmp)
                return base.Write(tmp.Address, value);
            else
                return new OperateResult($"Tag Name {name} can't find");
        }

        public new OperateResult Write(string name, string value)
        {
            var tmp = Config.List.Find(b => b.Name == name);
            if (null != tmp)
                return base.Write(tmp.Address, value);
            else
                return new OperateResult($"Tag Name {name} can't find");
        }

        #endregion

    }
}