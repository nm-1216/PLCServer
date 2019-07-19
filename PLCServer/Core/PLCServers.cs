using System.Collections.Generic;
using System.Linq;

// ReSharper disable once CheckNamespace
namespace PLCServer
{
    // ReSharper disable once InconsistentNaming
    public static class PLCServers
    {
        static PLCServers()
        {
            KeyValues = new Dictionary<string, object>();
            List = new Dictionary<string, IPLC>();
        }

        /// <summary>
        /// PLC 集合
        /// </summary>
        public static Dictionary<string, IPLC> List { get; internal set; }

        /// <summary>
        /// PLC 值集合
        /// </summary>
        public static Dictionary<string, object> KeyValues { get; internal set; }
        
        /// <summary>
        /// 获取PLC
        /// </summary>
        /// <param name="name">PLC name</param>
        /// <returns></returns>
        public static IPLC GetServer(string name)
        {
            return List.FirstOrDefault(b => b.Key == name).Value;
        }

        /// <summary>
        /// 添加键值对
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="value">value</param>
        public static void AddKeyValue(string key, object value)
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
        /// 读取数组
        /// </summary>
        /// <param name="keys">标签名 集合</param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static object[] ReturnValue(string[] keys, out string msg)
        {
            msg = string.Empty;
            var obj = new List<object>();
            var error = new List<string>();

            foreach (var item in keys)
            {
                if (KeyValues.ContainsKey(item))
                {
                    obj.Add(KeyValues[item]);
                }
                else
                {
                    obj.Add(null);
                    error.Add(item);
                }
            }

            if (error.Any())
                msg = $"{string.Join(",", error)} can't find Keys";

            return obj.ToArray();
        }
    }
}