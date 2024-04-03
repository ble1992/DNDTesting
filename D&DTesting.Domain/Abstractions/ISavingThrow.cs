using D_DTesting.Domain.Model.Misc;

namespace D_DTesting.Domain.Abstractions
{
    public interface ISavingThrow
    {
        public string Name { get; set; }
        public Dice Dice { get; set; }
        public int DC { get; set; }
        public bool Advantage { get; set; }
        public bool Disadvantage { get; set; }
        public int Roll();
    }
}
