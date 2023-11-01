using Patterns.Factory;
using System;

namespace Patterns.Observer
{
    public abstract class BaseUseCaseObserver : IUseCaseObserver
    {
        public Action OnObserverEvent { get; set; }
        private INameObserverGetter _nameObserverGetter;

        protected BaseUseCaseObserver(INameObserverGetter dataTypeObserverPattern)
        {
            _nameObserverGetter = dataTypeObserverPattern;
        }

        public IItemFactory GetItemFactory() => this;

        public void InvokeObserverEvent()
        {
            OnObserverEvent?.Invoke();
        }

        public string GetNameUseCaseObserver() => _nameObserverGetter.GetTypeNameObserver();

        public void CleanObserverEvent()
        {
            OnObserverEvent = null;
        }
    }
}