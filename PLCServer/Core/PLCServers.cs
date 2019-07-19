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
            _KeyValues = new Dictionary<string, object>();
            List = new Dictionary<string, IPLC>();
        }

        /// <summary>
        /// PLC 集合
        /// </summary>
        // ReSharper disable once MemberCanBePrivate.Global
        public static Dictionary<string, IPLC> List { get; internal set; }

        /// <summary>
        /// PLC 值集合
        /// </summary>
        // ReSharper disable once InconsistentNaming
        private static Dictionary<string, object> _KeyValues { get; set; }

        public static Dictionary<string, object> KeyValues
        {
            //为什么要 ToArray 由于集合序列化的时候 存在被其他线程修改，需要 ToArray创建副本
            get { return _KeyValues; }
        }

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
            if (_KeyValues.ContainsKey(key))
            {
                _KeyValues[key] = value;
            }
            else
            {
                _KeyValues.Add(key, value);
            }
        }

        public static void AddKeyValue(string key, object value, ref Dictionary<string, object> changeData)
        {
            if (_KeyValues.ContainsKey(key))
            {
                if (!_KeyValues[key].Equals(value))
                {
                    changeData.Add(key, value);
                    _KeyValues[key] = value;
                }
            }
            else
            {
                changeData.Add(key, value);
                _KeyValues.Add(key, value);
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
                if (_KeyValues.ContainsKey(item))
                {
                    obj.Add(_KeyValues[item]);
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