using Patterns.Factory;

namespace Patterns.Observer
{
    public class Observer : Factory<string, IUseCaseObserver>
    {
        public Observer(IUseCaseObserver[] useCaseObservers)
        {
            for (int i = 0; i < useCaseObservers.Length; i++)
            {
                AddObjectToFactory(useCaseObservers[i].GetNameUseCaseObserver(), useCaseObservers[i]);
            }
        }
    }
}