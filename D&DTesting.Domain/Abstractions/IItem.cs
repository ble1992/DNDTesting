namespace D_DTesting.Domain.Abstractions
{
    public interface IItem
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Quantity { get; set; }
    }
}
