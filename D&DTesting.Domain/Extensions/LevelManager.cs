using D_DTesting.Domain.Model.Objects;

namespace D_DTesting.Domain.Extensions
{
    public static class LevelManager
    {
        private static readonly Dictionary<int, int> ProficiencyBonus = new()
        {
            {4, 2},
            {8, 3},
            {12, 4},
            {16, 5},
            {20, 6}
        };

        public static int SetProficiencyBonus(this PlayableCharacter player, int level)
        {
            return ProficiencyBonus.FirstOrDefault(x => level <= x.Key).Value;
        }
    }
}
