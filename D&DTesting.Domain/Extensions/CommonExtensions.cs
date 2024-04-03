namespace D_DTesting.Domain.Extensions
{
    public static class CommonExtensions
    {

        public static int CalculateModifier(int score)
        {
            return (score - 10) / 2;
        }
    }
}
