using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using HslCommunication;
using HslCommunication.Core;
using HslCommunication.Profinet.AllenBradley;
using PLCServer.Config;

namespace PLCServer.Provider
{
    public class DoraAllenBradleyNet : AllenBradleyNet, IPLC
    {
        // ReSharper disable once UnusedMember.Global
        public DoraAllenBradleyNet(string ip, int port) : base(ip, port)
        {
        }

        public DoraAllenBradleyNet(PLCServerConfig config) : base(config.IpAddress, config.Port)
        {
            Config = config;
            Slot = config.Slot;
            Name = config.Name;
        }

        public new IByteTransform ByteTransform => base.ByteTransform;

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
            return null != tmp ? base.Write(tmp.Address, value) : new OperateResult($"Tag Name {name} can't find");
        }

        public new OperateResult Write(string name, short value)
        {
            var tmp = Config.List.Find(b => b.Name == name);
            return null != tmp ? base.Write(tmp.Address, value) : new OperateResult($"Tag Name {name} can't find");
        }

        public new OperateResult Write(string name, int value)
        {
            var tmp = Config.List.Find(b => b.Name == name);
            return null != tmp ? base.Write(tmp.Address, value) : new OperateResult($"Tag Name {name} can't find");
        }

        public new OperateResult Write(string name, long value)
        {
            var tmp = Config.List.Find(b => b.Name == name);
            return null != tmp ? base.Write(tmp.Address, value) : new OperateResult($"Tag Name {name} can't find");
        }

        public new OperateResult Write(string name, float value)
        {
            var tmp = Config.List.Find(b => b.Name == name);
            return null != tmp ? base.Write(tmp.Address, value) : new OperateResult($"Tag Name {name} can't find");
        }

        public new OperateResult Write(string name, double value)
        {
            var tmp = Config.List.Find(b => b.Name == name);
            return null != tmp ? base.Write(tmp.Address, value) : new OperateResult($"Tag Name {name} can't find");
        }

        public new OperateResult Write(string name, string value)
        {
            var tmp = Config.List.Find(b => b.Name == name);
            return null != tmp ? base.Write(tmp.Address, value) : new OperateResult($"Tag Name {name} can't find");
        }

        #endregion

    }
}