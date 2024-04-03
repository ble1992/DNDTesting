using D_DTesting.Domain.Abstractions;
using D_DTesting.Domain.Extensions;

namespace D_DTesting.Domain.Model.Misc
{
    public class AbilityScores : IAbilitiyScore
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public int TotalScore { get { return Score + ItemScore; } }
        public int AbilityModifier { 
            get {
                return CommonExtensions.CalculateModifier(TotalScore);
            } 
        }
        public int ItemScore { get; set; }
        public Dice Dice { get; set; } = new Dice() { DieAmount = 1, DiceSize = 20 };
        public bool Advantage { get; set; }
        public bool Disadvantage { get; set; }
        public int Roll()
        {
            if (Advantage && !Disadvantage) return Dice.RollAdvantage();
            else if(Disadvantage && !Advantage) return Dice.RollDisadvantage();
            return Dice.Roll();
        }
    }
}
