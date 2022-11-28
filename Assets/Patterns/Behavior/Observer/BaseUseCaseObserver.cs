using Patterns.Factory;
using System;

namespace Patterns.Observer
{
    public abstract class BaseUseCaseObserver : IUseCaseObserver
    {
        public Action OnObserverEvent { get; set; }
        private DataTypeObserverPattern _dataTypeObserverPattern;

        public IItemFactory GetItemFactory() => this;

        public void InvokeObserverEvent()
        {
            OnObserverEvent?.Invoke();
        }

        public string GetNameUseCaseObserver() => _dataTypeObserverPattern.GetTypeNameObserver();

        public void CleanObserverEvent()
        {
            OnObserverEvent = null;
        }
    }
}