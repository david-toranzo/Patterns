using System;

namespace Observers.Core
{
    public interface ISubscriber : IDisposable
    {
        void Subscribe();
    }
}