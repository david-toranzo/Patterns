namespace Patterns.Factory.Examples
{
    public class FactoryWeapons : Factory<string, BaseSwordFactory>
    {
        public FactoryWeapons(BaseSwordFactory[] typeFactories)
        {
            for (int i = 0; i < typeFactories.Length; i++)
            {
                AddObjectToFactory(typeFactories.ToString(), typeFactories[i]);
            }
        }
    }
}
