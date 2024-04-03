using D_DTesting.Domain.Model.Misc;

namespace D_DTesting.Domain.Abstractions
{
    public interface IAbilitiyScore : IType
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public int TotalScore { get; }
        public int AbilityModifier { get; }
        public int ItemScore { get; set; }
    }
}
