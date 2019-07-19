using System;
using PLCServer.Config;
using PLCServer.Provider;

// ReSharper disable once CheckNamespace
namespace PLCServer
{
    public class ServerFactory
    {
        private const string ErrorOnline = "联机PLC失败: IP:{0},PORT:{1},Message:{2}";

        private const string ProviderMelsecMcNet = "MELSECMCNET";
        private const string ProviderMelsecMcAsciiNet = "MELSECMCASCIINET";
        private const string ProviderMelsecA1ENet = "MELSECA1ENET";
        private const string ProviderSiemensS7Net = "SIEMENSS7NET";
        private const string ProviderSiemensFetchWriteNet = "SIEMENSFETCHWRITENET";
        private const string ProviderOmronFinsNet = "OMRONFINSNET";
        private const string ProviderAllenBradleyNet = "ALLENBRADLEYNET";

        public static void CreatePlcServer()
        {
            PLCServers.List.Clear();
            var tmp = PLCServerConfig.PlcList;
            foreach (var item in tmp)
            {
                PLCServers.List.Add(item.Name, CreatePLCServer(item));
            }
        }

        internal static string DebugFile
        {
            get { return $"{AppDomain.CurrentDomain.BaseDirectory}/{DateTime.Now.ToString("yyyyMMdd")}.txt"; }
        }

        // ReSharper disable once InconsistentNaming
        public static IPLC CreatePLCServer(PLCServerConfig config)
        {
            IPLC tmp;
            switch (config.ProviderName.ToUpper())
            {
                case ProviderMelsecMcNet:
                {
                    tmp = new DoraMelsecMcNet(config);
                    break;
                }
                case ProviderMelsecMcAsciiNet:
                {
                    tmp = new DoraMelsecMcAsciiNet(config);
                    break;
                }
                case ProviderMelsecA1ENet:
                {
                    tmp = new DoraMelsecA1ENet(config);
                    break;
                }
                case ProviderSiemensS7Net:
                {
                    tmp = new DoraSiemensS7Net(config);
                    break;
                }
                case ProviderSiemensFetchWriteNet:
                {
                    tmp = new DoraSiemensFetchWriteNet(config);
                    break;
                }
                case ProviderOmronFinsNet:
                {
                    tmp = new DoraOmronFinsNet(config);
                    break;
                }
                case ProviderAllenBradleyNet:
                {
                    tmp = new DoraAllenBradleyNet(config);
                    break;
                }
                default:
                {
                    tmp = null;
                    break;
                }
            }

            if (null != tmp)
            {
                tmp.LogNet = new HslCommunication.LogNet.LogNetSingle(DebugFile);

                tmp.SetPersistentConnection();
                var rst = tmp.ConnectServer();

                if (!rst.IsSuccess)
                    tmp.LogNet.WriteError(string.Format(ErrorOnline, config.IpAddress, config.Port, rst.Message));

                return tmp;
            }
            else
            {
                return null;
            }
        }
    }
}