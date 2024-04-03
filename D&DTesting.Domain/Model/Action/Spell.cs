using D_DTesting.Domain.Abstractions;
using D_DTesting.Domain.Enums;
using D_DTesting.Domain.Model.Misc;

namespace D_DTesting.Domain.Model.Action
{
    public class Spell : ISpell
    {
        public string Name { get; set; }
        public int Modifier { get; set; }
        public Dice DamageDice { get; set; }
        public int MinRange { get; set; }
        public int MaxRange { get; set; }
        public DamageType DamageType { get; set; }
        public SpellLevel SpellLevel { get; set; }
        public void Use(IInteractableObject target, bool criticalRoll)
        {
            if(DamageType == DamageType.Healing)
            {
                if(criticalRoll) target.CurrentHealth += DamageDice.RollCritical();
                else target.CurrentHealth += DamageDice.Roll();
            }
            else
            {
                if (criticalRoll) target.CurrentHealth += DamageDice.RollCritical();
                else target.CurrentHealth += DamageDice.Roll();
            }
        }
    }
}
