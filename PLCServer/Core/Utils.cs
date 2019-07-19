using System.Collections.Generic;
using HslCommunication;
using PLCServer.Config;

// ReSharper disable once CheckNamespace
namespace PLCServer
{
    public class Utils
    {
        public static bool _ReadObject<T>(T plc, PLCItem item, ref Dictionary<string, object> changeData) where T : IPLC
        {
            bool tmp;
            object value = null;
            OperateResult rst;

            switch (item.Type.ToLower())
            {
                case "bool":
                {
                    var read = plc.ReadBool(item.Address);
                    value = read.Content;
                    rst = read;
                    break;
                }
                case "int16":
                {
                    var read = plc.ReadInt16(item.Address);
                    value = read.Content;
                    rst = read;
                    break;
                }
                case "int32":
                {
                    var read = plc.ReadInt32(item.Address);
                    value = read.Content;
                    rst = read;
                    break;
                }
                case "int64":
                {
                    var read = plc.ReadInt64(item.Address);
                    value = read.Content;
                    rst = read;
                    break;
                }
                case "float":
                {
                    var read = plc.ReadFloat(item.Address);
                    value = read.Content;
                    rst = read;
                    break;
                }
                case "string":
                {
                    var read = plc.ReadString(item.Address, item.Length);
                    value = read.Content;
                    rst = read;
                    break;
                }
                default:
                {
                    rst = new OperateResult() {IsSuccess = false, Message = "封装暂不支持此类型"};
                    break;
                }
            }

            tmp = rst.IsSuccess;
            if (rst.IsSuccess)
            {
                PLCServers.AddKeyValue($"{item.Name}", value, ref changeData);
            }
            else
            {
                PLCServers.AddKeyValue($"{item.Name}", null, ref changeData);
                plc.LogNet.WriteError($"读取地址失败:{item.Address},{item.Type},{rst.Message}");
            }

            return tmp;
        }
    }
}
