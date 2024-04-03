using D_DTesting.Domain.Enums;
using D_DTesting.Domain.Model.Misc;

namespace D_DTesting.Domain.Abstractions
{
    public interface ISpell
    {
        public string Name { get; set; }
        public Dice DamageDice { get; set; }
        public int MinRange { get; set; }
        public int MaxRange { get; set; }
        public int Modifier { get; set; }
        public DamageType DamageType { get; set; }
        public SpellLevel SpellLevel { get; set; }
        public void Use(IInteractableObject target);
    }
}
