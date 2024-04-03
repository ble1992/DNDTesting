using D_DTesting.Domain.Enums;

namespace D_DTesting.Domain.Abstractions
{
    public interface IInteractableObject
    {
        public string Name { get; set; }
        public int CurrentHealth { get; set; }
        public Size Size { get; set; }
        public Status Status { get; set; }
        public int Weight { get; set; }
        public int Armor { get; set; }
    }
}
