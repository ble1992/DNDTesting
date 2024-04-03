using D_DTesting.Domain.Abstractions;
using D_DTesting.Domain.Enums;
using D_DTesting.Domain.Model.Misc;

namespace D_DTesting.Domain.Model.Inventory
{
    public class Weapon : IEquipable, IItem, IAction
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Quantity { get; set; }
        public Dice DamageDice { get; set; }
        public int MinRange { get; set; }
        public int MaxRange { get; set; }
        public int Modifier { get; set; }
        public DamageType DamageType { get; set; }

        public List<Property> Properties { get; set; } = new List<Property>();
        public void Use(IInteractableObject target, bool criticalRoll)
        {
            throw new NotImplementedException();
        }
    }
}
