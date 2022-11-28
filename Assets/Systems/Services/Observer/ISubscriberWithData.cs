using System;

namespace Observers.Core
{
    public interface ISubscriberWithData<ReturnDataType> : ISubscriber
    {
        Action<ReturnDataType> OnReceiveData { get; set; }
    }
}