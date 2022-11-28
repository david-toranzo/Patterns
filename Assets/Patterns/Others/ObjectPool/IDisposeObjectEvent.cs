using System;

namespace Toranzo.ObjectPool
{
    public interface IDisposeObjectEvent
    {
        Action OnDisposeObject { get; set; }
    }
}