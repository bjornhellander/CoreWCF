using System;
using System.ServiceModel;
using Contract;

namespace NetCoreClient
{
    [ServiceContract]
    public class EchoServiceCallback : IEchoServiceCallback
    {
        public void Done()
        {
            Console.WriteLine("Received callback from server");
        }
    }
}
