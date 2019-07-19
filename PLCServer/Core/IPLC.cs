using HslCommunication;
using HslCommunication.Core;
using HslCommunication.LogNet;
using PLCServer.Config;

// ReSharper disable once CheckNamespace
namespace PLCServer
{
    // ReSharper disable once InconsistentNaming
    public interface IPLC : IReadWriteNet
    {
        event PLCEvent_DataChangeEventHandler DataChange;
        event PLCEvent_DataReaderEventHandler DataReader;
        event PLCEvent_StatusChangeEventHandler StatusChange;

        ILogNet LogNet { get; set; }

        /// <summary>
        /// PLC名称
        /// </summary>
        string Name { get; set; }

        PLCServerConfig Config { get; }

        /// <summary>
        /// 开始扫描
        /// </summary>
        void StartScan();

        void StartReader();

        #region Read

        //OperateResult<string> ReadString(string address, ushort length, Encoding encoding);

        #endregion

        OperateResult ConnectServer();

        void SetPersistentConnection();

        IByteTransform ByteTransform { get; }
    }
}