using System.Collections.Generic;
using System.Linq;
using HslCommunication.Core;
using PLCServer.PLC;

namespace PLCServer
{
    // ReSharper disable once InconsistentNaming
    public class PLCServers
    {
        internal static Dictionary<string, IPLC> List = new Dictionary<string, IPLC>();

        public static Dictionary<string, object> KeyValues = new Dictionary<string, object>();

        public static IPLC GetServer(string name)
        {
            if (!List.Any())
                ServerFactory.CreatePLCServer();

            return List.FirstOrDefault(b => b.Key == name).Value;
        }

        public static void AddKeyValue(string key,object value)
        {
            if (KeyValues.ContainsKey(key))
            {
                KeyValues[key] = value;
            }
            else
            {
                KeyValues.Add(key, value);
            }
        }

        /// <summary>
        /// 读取下位机通用方法
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Exceptionstr"></param>
        /// <returns></returns>
        public static object[] ReturnValue(string[] Value, out string Exceptionstr)
        {
            Exceptionstr = string.Empty;
            IList<object> obj = new List<object>();

            foreach(var item in Value){
                if (KeyValues.ContainsKey(item))
                {
                    var tmp = PLCServers.KeyValues[item];
                    obj.Add(tmp);
                }
                else
                {
                    obj.Add(null);
                    Exceptionstr += item;
                }
            }
       
            return obj.ToArray();
        }
    }
}