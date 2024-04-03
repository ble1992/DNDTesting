using D_DTesting.Domain.Abstractions;
using D_DTesting.Domain.Enums;
using D_DTesting.Domain.Model.Misc;

namespace D_DTesting.Domain.Model.Action
{
    public class Skill : ISkill
    {
        public string Name { get; set; }
        public int ModifierBonus { get; set; }
        public ProficiencyBonusType ProficiencyBonus { get; set; }
        public Dice Dice { get; set; } = new Dice() { DiceSize = 20, DieAmount = 1};

        public int UseSkill()
        {
            return Dice.Roll() + ModifierBonus;
        }

        public int UseSkill(IInteractableObject target)
        {
            return Dice.Roll() + ModifierBonus;
        }
    }
}
