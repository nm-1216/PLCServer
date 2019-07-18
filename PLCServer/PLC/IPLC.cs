using System;
using System.Collections.Generic;
using System.Text;
using HslCommunication;
using HslCommunication.Core;
using HslCommunication.LogNet;

namespace PLCServer.PLC
{
    public interface IPLC
    {
        event PLCEvent_DataChangeEventHandler DataChange;
        event PLCEvent_DataReaderEventHandler DataReader;
        event PLCEvent_StatusChangeEventHandler StatusChange;

        ILogNet LogNet { get; set; }

        //Dictionary<string, object> KeyValues { get; set; }

        /// <summary>
        /// PLC 名称
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// 开始扫描
        /// </summary>
        void StartScan();

        #region Read
        OperateResult<byte[]> Read(string address, ushort length);
        OperateResult<bool> ReadBool(string address);
        OperateResult<Int16> ReadInt16(string address);
        OperateResult<Int32> ReadInt32(string address);
        OperateResult<Int64> ReadInt64(string address);
        OperateResult<float> ReadFloat(string address);
        OperateResult<double> ReadDouble(string address);
        OperateResult<string> ReadString(string address, ushort length);
        OperateResult<string> ReadString(string address, ushort length, Encoding encoding);

        #endregion

        #region Write

        OperateResult Write(string address, bool value);
        OperateResult Write(string address, short value);
        OperateResult Write(string address, int value);
        OperateResult Write(string address, float value);
        OperateResult Write(string address, double value);
        OperateResult Write(string address, string value);

        #endregion

        //bool ConnectionState { get; set; }

        OperateResult ConnectServer();

        IByteTransform ByteTransform { get; }

    }
}