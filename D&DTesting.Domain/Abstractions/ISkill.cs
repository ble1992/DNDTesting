using D_DTesting.Domain.Enums;
using D_DTesting.Domain.Model.Misc;

namespace D_DTesting.Domain.Abstractions
{
    public interface ISkill : IType
    {
        public string Name { get; set; }
        public int TotalModifer { get; }
        public int AbiliitiesModifer { get; set; }
        public int ItemModifier { get; set; }
        public ProficiencyBonusType ProficiencyBonus { get; set; }
        public bool Advantage { get; set; }
        public bool Disadvantage { get; set; }
        public Dice Dice { get; set; }
        public int UseSkill();
        public int UseSkill(IInteractableObject target);
    }
}
