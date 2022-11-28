using System;
using UnityEngine;

namespace Toranzo.ObjectPool
{
    public abstract class ObjectPoolInstance<Type> : MonoBehaviour, IObjectPoolInstance<Type>, IDisposeObjectEvent
    {
        public Action OnDisposeObject { get; set; }

        private IDisposeType<Type> _disposeType;

        public void AddNewDisposeType(IDisposeType<Type> disposeType)
        {
            _disposeType = disposeType;
        }

        public void Dispose()
        {
            BeforeReturnThisInstanceToPool();

            OnDisposeObject?.Invoke();
            _disposeType.DisposeType(GetTypeDiscardObject());
        }

        protected abstract void BeforeReturnThisInstanceToPool();

        protected abstract Type GetTypeDiscardObject();
    }
}
