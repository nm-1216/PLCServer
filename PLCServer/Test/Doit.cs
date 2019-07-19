using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Newtonsoft.Json;

namespace PLCServer.Test
{
    public class Doit
    {
        private Serves PlcServes;

        public Doit()
        {
            PlcServes = Serves.CreateInstance();
        }

        private void DataChangeStatus(IPLC sender, object args)
        {
            var tmp = args as Dictionary<string, object>;

            if (tmp != null && tmp.Any())
            {
                if (tmp.ContainsKey("Status"))
                {
                    //...do()
                }
            }
        }

        private void DataChangePrice(IPLC sender, object args)
        {
            var tmp = args as Dictionary<string, object>;

            if (tmp != null && tmp.Any())
            {
                if (tmp.ContainsKey("Price"))
                {
                    //...do()
                }
            }
        }

        private void StatusChange(IPLC sender, bool rst)
        {
        }

        private void DataReader(IPLC sender)
        {
        }

        public void Init()
        {
            //按照配置文件顺序扫描     ======> 顺序扫描与自定义读取方式二选一
            PlcServes.MyPlcA.StartScan();
            //自定义数据读取方式       ======> 顺序扫描与自定义读取方式二选一
            PlcServes.MyPlcA.DataReader += DataReader;
            //自定义数据读取方式 需要配合 StartReader 使用。
            PlcServes.MyPlcA.StartReader();

            //数据改变
            PlcServes.MyPlcA.DataChange += DataChangeStatus;
            PlcServes.MyPlcA.DataChange += DataChangePrice;

            //状态改变
            PlcServes.MyPlcA.StatusChange += StatusChange;

            Thread.Sleep(2000);
            while (true)
            {
                Thread.Sleep(1000);
                Console.Write(JsonConvert.SerializeObject(PLCServers.KeyValues));
                Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            }

            // ReSharper disable once FunctionNeverReturns
        }
    }
}