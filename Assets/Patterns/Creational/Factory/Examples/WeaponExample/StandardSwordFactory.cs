namespace Patterns.Factory.Examples
{
    public class StandardSwordFactory : BaseSwordFactory
    {
        public override IItemFactory GetItemFactory()
        {
            return new StandardSword();
        }
    }
}
