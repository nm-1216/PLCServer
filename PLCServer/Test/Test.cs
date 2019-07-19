using PLCServer.Config;

namespace PLCServer.Test
{
    public class Test
    {
        public void MelsecMcNet()
        {
            ServerFactory.CreatePLCServer(new PLCServerConfig() {IpAddress = "192.168.0.1"});
        }
    }
}