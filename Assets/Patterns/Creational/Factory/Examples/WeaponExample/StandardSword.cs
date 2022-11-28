namespace Patterns.Factory.Examples
{
    public class StandardSword : IItemFactory
    {
        private int _damage;
        private int _cost;

        public int Damage { get => _damage; set => _damage = value; }
        public int CostSword { get => _cost; set => _cost = value; }
    }
}
