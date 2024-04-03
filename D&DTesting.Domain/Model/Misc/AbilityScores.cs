using D_DTesting.Domain.Abstractions;

namespace D_DTesting.Domain.Model.Misc
{
    public class AbilityScores : IAbilitiyScore
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public int Modifier { get; set; }
        public Dice Dice { get; set; } = new Dice() { DieAmount = 1, DiceSize = 20 };
        public bool Advantage { get; set; }
        public bool Disadvantage { get; set; }
        public int Roll()
        {
            if (Advantage) return Dice.RollAdvantage();
            else if(Disadvantage && !Advantage) return Dice.RollDisadvantage();
            return Dice.Roll();
        }
    }
}
