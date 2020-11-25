// namespace PLCServer.Test
// {
//     public class Serves
//     {
//         public IPLC MyPlcA;
//         public IPLC MyPlcB;
//         public IPLC MyPlcC;
//
//         private Serves()
//         {
//             ServerFactory.CreatePlcServer();
//
//             MyPlcA = PLCServers.GetServer("A");
//             MyPlcB = PLCServers.GetServer("B");
//             MyPlcC = PLCServers.GetServer("C");
//
//
//         }
//
//         private static Serves _singleton;
//
//         private static readonly object SingletonLock = new object();
//
//         public static Serves CreateInstance()
//         {
//             if (_singleton != null) return _singleton;
//
//             lock (SingletonLock)
//             {
//                 _singleton = new Serves();
//             }
//
//             return _singleton;
//         }
//     }
// }