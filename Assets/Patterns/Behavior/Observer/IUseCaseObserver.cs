using Patterns.Factory;
using System;

namespace Patterns.Observer
{
    public interface IUseCaseObserver : TypeFactory, IItemFactory
    { 
        Action OnObserverEvent { get; set; }

        void InvokeObserverEvent();

        string GetNameUseCaseObserver();

        void CleanObserverEvent();
    }
}