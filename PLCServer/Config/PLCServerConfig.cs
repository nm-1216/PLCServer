using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using HslCommunication.Profinet.Siemens;
using Newtonsoft.Json;

namespace PLCServer.Config
{
    public class PLCServerConfig
    {
        private static IList<PLCServerConfig> _list;

        public static IList<PLCServerConfig> list { get {

                if (null == _list)
                {
                    StreamReader sr = new StreamReader($"{AppDomain.CurrentDomain.BaseDirectory}PLCConfig.json", Encoding.Default);
                    var tmp = sr.ReadToEnd();

                    _list = JsonConvert.DeserializeObject<IList<PLCServerConfig>>(tmp);
                }

                return _list;
            }
        }


        /// <summary>
        /// PLC名称 <不能重名>
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// IP 地址
        /// </summary>
        public string IpAddress { get; set; }

        /// <summary>
        /// 端口
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// AB要用
        /// </summary>
        public Byte Slot { get; set; }

        /// <summary>
        /// 西门子PLC类型
        /// </summary>
        public SiemensPLCS Siemens { get; set; }
        
        /// <summary>
        /// 驱动程序
        /// </summary>
        public string ProviderName { get; set; }

        /// <summary>
        /// PLC地址表
        /// </summary>
        public List<PLCItem> List { get; set; }
    }
}