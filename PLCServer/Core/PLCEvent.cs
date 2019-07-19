// ReSharper disable once CheckNamespace
namespace PLCServer
{
    /// <summary>
    /// 数据变更
    /// </summary>
    /// <param name="sender"></param>
    // ReSharper disable once InconsistentNaming
    public delegate void PLCEvent_DataChangeEventHandler(IPLC sender, object args);

    /// <summary>
    /// 数据读取
    /// </summary>
    /// <param name="sender"></param>
    // ReSharper disable once InconsistentNaming
    public delegate void PLCEvent_DataReaderEventHandler(IPLC sender);

    /// <summary>
    /// 联机状态
    /// </summary>
    /// <param name="sender"></param>
    // ReSharper disable once InconsistentNaming
    public delegate void PLCEvent_StatusChangeEventHandler(IPLC sender, bool rst);
}
