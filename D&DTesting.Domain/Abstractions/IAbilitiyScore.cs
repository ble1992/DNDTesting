using D_DTesting.Domain.Model.Misc;

namespace D_DTesting.Domain.Abstractions
{
    public interface IAbilitiyScore
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public int Modifier { get; set; }
        public Dice Dice { get; set; }
        public bool Advantage { get; set; }
        public bool Disadvantage { get; set; }
        public int Roll();
    }
}
