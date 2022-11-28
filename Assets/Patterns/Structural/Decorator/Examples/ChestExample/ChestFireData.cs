namespace Patterns.Decorator
{
    public class ChestFireData : ChestStatsAdder
    {
        public ChestFireData(ChestData chestDataToAdd) : base(chestDataToAdd)
        {
            _armorChest = 50;
            _description = " And, also added this chest with more protection, it is a fire chest!";
        }
    }
}
