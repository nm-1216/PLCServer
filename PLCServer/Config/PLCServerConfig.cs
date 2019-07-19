using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using HslCommunication.Profinet.Siemens;
using Newtonsoft.Json;

namespace PLCServer.Config
{
    // ReSharper disable once InconsistentNaming
    public class PLCServerConfig
    {
        private static IList<PLCServerConfig> _plc;

        public static IList<PLCServerConfig> PlcList
        {
            get
            {

                if (null == _plc)
                {
                    StreamReader sr = new StreamReader($"{AppDomain.CurrentDomain.BaseDirectory}PLCConfig.json", Encoding.Default);
                    var tmp = sr.ReadToEnd();

                    _plc = JsonConvert.DeserializeObject<IList<PLCServerConfig>>(tmp);
                }

                return _plc;
            }
        }


        /// <summary>
        /// PLC名称 不能重名
        /// </summary>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public string Name { get; set; }
        
        /// <summary>
        /// IP 地址
        /// </summary>
        public string IpAddress { get; set; }

        /// <summary>
        /// 端口
        /// </summary>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public int Port { get; set; }

        /// <summary>
        /// AB要用
        /// </summary>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public Byte Slot { get; set; }

        /// <summary>
        /// 西门子PLC类型
        /// </summary>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public SiemensPLCS Siemens { get; set; }
        
        /// <summary>
        /// 驱动程序
        /// </summary>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public string ProviderName { get; set; }

        /// <summary>
        /// PLC地址表
        /// </summary>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        // ReSharper disable once CollectionNeverUpdated.Global
        public List<PLCItem> List { get; set; }
    }
}