using HslCommunication.Core;
using PLCServer.Config;
using PLCServer.PLC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLCServer
{
    public class Utils
    {

        public static bool _ReadObject<T>(T plc, PLCItem item) where T: IPLC
        {
            var tmp = false;

            if (item.Type.ToLower() == "bool")
            {
                var read = plc.ReadBool(item.Address);
                tmp = read.IsSuccess;
                if (read.IsSuccess)
                {
                    PLCServers.AddKeyValue($"{item.Name}", read.Content);
                }
                else
                {
                    PLCServers.AddKeyValue($"{item.Name}", null);
                    plc.LogNet.WriteError($"读取地址失败:{item.Address},{item.Type}");
                }
            }

            if (item.Type.ToLower() == "int16")
            {
                var read = plc.ReadInt16(item.Address);

                tmp = read.IsSuccess;
                if (read.IsSuccess)
                {
                    PLCServers.AddKeyValue($"{item.Name}", read.Content);

                }
                else
                {
                    PLCServers.AddKeyValue($"{item.Name}", null);
                    plc.LogNet.WriteError($"读取地址失败:{item.Address},{item.Type}");

                }
            }


            if (item.Type.ToLower() == "int32")
            {
                var read = plc.ReadInt32(item.Address);

                tmp = read.IsSuccess;
                if (read.IsSuccess)
                {
                    PLCServers.AddKeyValue($"{item.Name}", read.Content);
                }
                else
                {
                    PLCServers.AddKeyValue($"{item.Name}", null);
                    plc.LogNet.WriteError($"读取地址失败:{item.Address},{item.Type}");

                }
            }


            if (item.Type.ToLower() == "int64")
            {
                var read = plc.ReadInt32(item.Address);

                tmp = read.IsSuccess;
                if (read.IsSuccess)
                {
                    PLCServers.AddKeyValue($"{item.Name}", read.Content);
                }
                else
                {
                    PLCServers.AddKeyValue($"{item.Name}", null);
                    plc.LogNet.WriteError($"读取地址失败:{item.Address},{item.Type}");

                }
            }


            if (item.Type.ToLower() == "float")
            {
                var read = plc.ReadFloat(item.Address);

                tmp = read.IsSuccess;
                if (read.IsSuccess)
                {
                    PLCServers.AddKeyValue($"{item.Name}", read.Content);
                }
                else
                {
                    PLCServers.AddKeyValue($"{item.Name}", null);
                    plc.LogNet.WriteError($"读取地址失败:{item.Address},{item.Type}");

                }
            }

            if (item.Type.ToLower() == "string")
            {
                var read = plc.ReadString(item.Address, item.Length);

                tmp = read.IsSuccess;
                if (read.IsSuccess)
                {
                    PLCServers.AddKeyValue($"{item.Name}", read.Content);
                }
                else
                {
                    PLCServers.AddKeyValue($"{item.Name}", null);
                    plc.LogNet.WriteError($"读取地址失败:{item.Address},{item.Type}");

                }
            }

            return tmp;

            //状态变更
            //if (plc.ConnectionState != tmp)
            //{
            //    plc.ConnectionState = tmp;
            //    plc.StatusChange?.Invoke(this);
            //}
        }


    }
}
