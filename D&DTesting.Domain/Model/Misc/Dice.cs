using D_DTesting.Domain.Abstractions;

namespace D_DTesting.Domain.Model.Misc
{
    public class Dice : IRoll
    {
        public int DiceSize { get; set; }
        public int DieAmount { get; set; }

        private Random _randomizer = new Random(Guid.NewGuid().GetHashCode());

        public int Roll()
        {
            int total = 0;
            for (int i = 0; i < DieAmount; i++)
            {
                total += _randomizer.Next(1, DiceSize + 1);
            }
            return total;
        }

        public int RollAdvantage()
        {
            int roll1 = _randomizer.Next(1, DiceSize + 1);
            int roll2 = _randomizer.Next(1, DiceSize + 1);

            return Math.Max(roll1, roll2);
        }

        public int RollDisadvantage()
        {
            int roll1 = _randomizer.Next(1, DiceSize + 1);
            int roll2 = _randomizer.Next(1, DiceSize + 1);

            return Math.Min(roll1, roll2);
        }

        public int RollCritical()
        {
            return Roll() + Roll();
        }
    }
}
