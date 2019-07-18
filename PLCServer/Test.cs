using HslCommunication.Core.Net;
using HslCommunication.Profinet.Melsec;
using PLCServer.Config;

namespace PLCServer
{
    public class Test
    {
        public void MelsecMcNet()
        {
            var tmp = ServerFactory.CreatePLCServer(new PLCServerConfig() {IpAddress = "192.168.0.1"});
        }
    }
}