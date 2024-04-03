using D_DTesting.Domain.Abstractions;
using D_DTesting.Domain.Enums;

namespace D_DTesting.Domain.Model.Inventory
{
    public class Armor : IEquipable, IItem
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public ArmorType ArmorType { get; set; }
        public int ArmorValue { get; set; }
        public int Quantity { get; set; } = 1;
    }
}
