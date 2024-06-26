﻿using D_DTesting.Domain.Abstractions;

namespace D_DTesting.Domain.Model.Misc
{
    public class SavingThrow : ISavingThrow
    {
        public string Name { get; set; }
        public int TotalModifier { get { return AbilitiyModifier + ItemModifier; } }
        public int AbilitiyModifier { get; set; }
        public int ItemModifier { get; set; }
        public Dice Dice { get; set; } = new Dice() { DiceSize = 20, DieAmount = 1 };
        public bool Advantage { get; set; } = false;
        public bool Disadvantage { get; set; } = false;
        public int Roll()
        {
            if (Advantage && !Disadvantage) return Dice.RollAdvantage();
            else if (Disadvantage && !Advantage) return Dice.RollDisadvantage();
            return Dice.Roll();
        }
    }
}
