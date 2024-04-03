using D_DTesting.Domain.Model.Misc;

namespace D_DTesting.Domain.Abstractions
{
    public interface IEquipable
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public List<Property> Properties { get; set; }
    }
}
