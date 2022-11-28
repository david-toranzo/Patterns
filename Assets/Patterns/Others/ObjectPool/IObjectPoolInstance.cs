using System;

namespace Toranzo.ObjectPool
{
    public interface IObjectPoolInstance<Type> : IDisposable
    {
        void AddNewDisposeType(IDisposeType<Type> disposeType);
    }
}