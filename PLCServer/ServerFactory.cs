using System;
using System.Collections.Generic;
using HslCommunication.Core;
using PLCServer.Config;
using PLCServer.PLC;

namespace PLCServer
{
    public class ServerFactory
    {
        public static void CreatePLCServer()
        {

            PLCServers.List.Clear();

            var tmp = PLCServerConfig.list;

            foreach (var item in tmp)
            {
                PLCServers.List.Add(item.Name, CreatePLCServer(item));
            }
        }

        // ReSharper disable once InconsistentNaming
        public static IPLC CreatePLCServer(PLCServerConfig config)
        {
            switch (config.ProviderName.ToUpper())
            {
                case "MELSECMCNET":
                    {
                        var tmp = new DoraMelsecMcNet(config.IpAddress, config.Port);
                        tmp.LogNet = new HslCommunication.LogNet.LogNetSingle($"{AppDomain.CurrentDomain.BaseDirectory}/{DateTime.Now.ToString("yyyyMMdd")}.txt");
                        tmp.SetPersistentConnection();
                        var rst = tmp.ConnectServer();

                        if (!rst.IsSuccess)
                            tmp.LogNet.WriteError($"初始化PLC服务器失败，IP:{config.IpAddress},PORT:{config.Port},Message:{rst.Message}");

                        return tmp;
                    }

                case "MELSECMCASCIINET":
                    {
                        var tmp = new DoraMelsecMcAsciiNet(config.IpAddress, config.Port);
                        tmp.LogNet = new HslCommunication.LogNet.LogNetSingle($"{AppDomain.CurrentDomain.BaseDirectory}/{DateTime.Now.ToString("yyyyMMdd")}.txt");

                        tmp.SetPersistentConnection();
                        var rst = tmp.ConnectServer();
                        if (!rst.IsSuccess)
                            tmp.LogNet.WriteError($"初始化PLC服务器失败，IP:{config.IpAddress},PORT:{config.Port},Message:{rst.Message}");

                        return tmp;
                    }

                case "MELSECA1ENET":
                    {
                        var tmp = new DoraMelsecA1ENet(config.IpAddress, config.Port);
                        tmp.LogNet = new HslCommunication.LogNet.LogNetSingle($"{AppDomain.CurrentDomain.BaseDirectory}/{DateTime.Now.ToString("yyyyMMdd")}.txt");
                        tmp.SetPersistentConnection();
                        var rst = tmp.ConnectServer();
                        if (!rst.IsSuccess)
                            tmp.LogNet.WriteError($"初始化PLC服务器失败，IP:{config.IpAddress},PORT:{config.Port},Message:{rst.Message}");

                        return tmp;
                    }

                case "SIEMENSS7NET":
                    {
                        var tmp = new DoraSiemensS7Net(config);
                        tmp.LogNet = new HslCommunication.LogNet.LogNetSingle($"{AppDomain.CurrentDomain.BaseDirectory}/{DateTime.Now.ToString("yyyyMMdd")}.txt");
                        tmp.SetPersistentConnection();
                        var rst = tmp.ConnectServer();
                        if (!rst.IsSuccess)
                            tmp.LogNet.WriteError($"初始化PLC服务器失败，IP:{config.IpAddress},PORT:{config.Port},Message:{rst.Message}");

                        return tmp;
                    }

                case "SIEMENSFETCHWRITENET":
                    {
                        var tmp = new DoraSiemensFetchWriteNet(config.IpAddress, config.Port);
                        tmp.LogNet = new HslCommunication.LogNet.LogNetSingle($"{AppDomain.CurrentDomain.BaseDirectory}/{DateTime.Now.ToString("yyyyMMdd")}.txt");
                        tmp.SetPersistentConnection();
                        var rst = tmp.ConnectServer();
                        if (!rst.IsSuccess)
                            tmp.LogNet.WriteError($"初始化PLC服务器失败，IP:{config.IpAddress},PORT:{config.Port},Message:{rst.Message}");

                        return tmp;
                    }

                case "OMRONFINSNET":
                    {
                        var tmp = new DoraOmronFinsNet(config.IpAddress, config.Port);
                        tmp.LogNet = new HslCommunication.LogNet.LogNetSingle($"{AppDomain.CurrentDomain.BaseDirectory}/{DateTime.Now.ToString("yyyyMMdd")}.txt");
                        tmp.SetPersistentConnection();
                        var rst = tmp.ConnectServer();
                        if (!rst.IsSuccess)
                            tmp.LogNet.WriteError($"初始化PLC服务器失败，IP:{config.IpAddress},PORT:{config.Port},Message:{rst.Message}");

                        return tmp;
                    }

                case "ALLENBRADLEYNET":
                    {
                        var tmp = new DoraAllenBradleyNet(config);
                        tmp.SetPersistentConnection();
                        var rst = tmp.ConnectServer();


                        if (!rst.IsSuccess)
                            tmp.LogNet.WriteError($"初始化PLC服务器失败，IP:{config.IpAddress},PORT:{config.Port},Message:{rst.Message}");

                        return tmp;
                    }

                default: return null;
            }
        }
    }
}