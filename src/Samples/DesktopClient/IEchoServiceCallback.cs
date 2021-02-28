using System.ServiceModel;

namespace Contract
{
    [ServiceContract]
    public interface IEchoServiceCallback
    {
        [OperationContract(IsOneWay = true)]
        void Done();
    }
}
