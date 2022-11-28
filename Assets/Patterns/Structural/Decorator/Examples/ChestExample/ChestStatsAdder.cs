namespace Patterns.Decorator
{
    public abstract class ChestStatsAdder : ChestData
    {
        private ChestData _chestDataToAdd;

        public ChestStatsAdder(ChestData chestDataToAdd)
        {
            _chestDataToAdd = chestDataToAdd;
        }

        public override int GetArmor()
        {
            return _chestDataToAdd.GetArmor() + _armorChest;
        }

        public override string GetDescription()
        {
            return _chestDataToAdd.GetArmor() + _description;
        }
    }
}
