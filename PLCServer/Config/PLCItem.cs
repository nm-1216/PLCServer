namespace PLCServer.Config
{
    // ReSharper disable once InconsistentNaming
    public class PLCItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string Address { get; set; }

        public string Name { get; set; }
        
/*
        bool             布尔量 就是开关量 只有 0，1
        byte             字节
        word             字 16位整数
        dword            双字 32位整数
        short            带符号16位整数
        dint             带符号32位整数
        real             浮点数 实数 32位
*/
        /// <summary>
        /// 值类型
        /// </summary>
        public string Type { get; set; }


        public ushort Length { get; set; } = 0;


    }
}