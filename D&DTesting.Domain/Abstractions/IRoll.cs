namespace D_DTesting.Domain.Abstractions
{
    public interface IRoll
    {
        public int DiceSize { get; set; }
        public int DieAmount { get; set; }
        public int Roll();
    }
}
