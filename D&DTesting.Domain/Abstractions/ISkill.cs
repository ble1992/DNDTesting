using D_DTesting.Domain.Enums;
using D_DTesting.Domain.Model.Misc;

namespace D_DTesting.Domain.Abstractions
{
    public interface ISkill
    {
        public string Name { get; set; }
        public int ModifierBonus { get; set; }
        public ProficiencyBonusType ProficiencyBonus { get; set; }
        public Dice Dice { get; set; }
        public int UseSkill();
        public int UseSkill(IInteractableObject target);
    }
}
