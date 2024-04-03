using D_DTesting.Domain.Model.Misc;

namespace D_DTesting.Domain.Abstractions
{
    public interface ISavingThrow : IType
    {
        public string Name { get; set; }
        public Dice Dice { get; set; }
        public int TotalModifier { get; }
        public int AbilitiyModifier { get; set; }
        public int ItemModifier { get; set; }
        public bool Advantage { get; set; }
        public bool Disadvantage { get; set; }
        public int Roll();
    }
}
