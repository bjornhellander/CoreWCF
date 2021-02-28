using CoreWCF;

namespace Contract
{
    [ServiceContract]
    public interface IEchoServiceCallback
    {
        [OperationContract(IsOneWay = true)]
        void Done();
    }
}
