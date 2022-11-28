namespace Patterns.Factory.Examples
{
    public abstract class BaseSwordFactory : TypeFactory
    {
        public abstract IItemFactory GetItemFactory();
    }
}
