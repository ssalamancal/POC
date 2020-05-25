using System.ServiceModel;

namespace MessageService
{
    public interface IMyMessageCallbak
    {
        [OperationContract(IsOneWay = true)]
        void OnCallback(string message);
    }

    [ServiceContract(CallbackContract = typeof(IMyMessageCallbak))]
    public interface IMyMessage
    {
        [OperationContract]
        void MessageToServer(string message);
    }
}

