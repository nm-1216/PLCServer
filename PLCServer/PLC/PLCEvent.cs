using HslCommunication.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLCServer.PLC
{
    /// <summary>
    /// 数据变更
    /// </summary>
    /// <param name="sender"></param>
    public delegate void PLCEvent_DataChangeEventHandler(IPLC sender);

    /// <summary>
    /// 数据读取
    /// </summary>
    /// <param name="sender"></param>
    public delegate void PLCEvent_DataReaderEventHandler(IPLC sender);

    /// <summary>
    /// 联机状态
    /// </summary>
    /// <param name="sender"></param>
    public delegate void PLCEvent_StatusChangeEventHandler(IPLC sender, bool rst);
}
