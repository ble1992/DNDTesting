using D_DTesting.Domain.Abstractions;

namespace D_DTesting.Domain.Model.Misc
{
    public class SavingThrow : ISavingThrow
    {
        public string Name { get; set; }
        public int DC { get; set; }
        public Dice Dice { get; set; } = new Dice() { DiceSize = 20, DieAmount = 1 };
        public bool Advantage { get; set; } = false;
        public bool Disadvantage { get; set; } = false;
        public int Roll()
        {
            if (Advantage) return Dice.RollAdvantage();
            else if (Disadvantage && !Advantage) return Dice.RollDisadvantage();
            return Dice.Roll();
        }
    }
}
