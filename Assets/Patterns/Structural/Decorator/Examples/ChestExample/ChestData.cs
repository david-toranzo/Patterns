namespace Patterns.Decorator
{
    public abstract class ChestData : IChest
    {
        protected int _armorChest;
        protected string _description;

        public virtual int GetArmor()
        {
            return _armorChest;
        }

        public virtual string GetDescription()
        {
            return _description;
        }
    }
}
