using Patterns.Factory;

namespace Patterns.Observer
{
    public class ObserverService : Factory<string, IUseCaseObserver>
    {
        public ObserverService(IUseCaseObserver[] useCaseObservers)
        {
            for (int i = 0; i < useCaseObservers.Length; i++)
            {
                AddObjectToFactory(useCaseObservers[i].GetNameUseCaseObserver(), useCaseObservers[i]);
            }
        }

        public IUseCaseObserver GetObserver(string nameObserver)
        {
            return GetObjectType(nameObserver);
        }
    }
}