using System.ServiceModel;

namespace DesktopServer
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class EchoService : Contract.IEchoService
    {
        public string Echo(string text)
        {
            System.Console.WriteLine($"Received {text} from client!");

            var callback = OperationContext.Current.GetCallbackChannel<Contract.IEchoServiceCallback>();
            callback.Done();

            return text;
        }

        public string ComplexEcho(Contract.EchoMessage text)
        {
            System.Console.WriteLine($"Received {text.Text} from client!");
            return text.Text;
        }
    }
}
