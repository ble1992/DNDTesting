using D_DTesting.Domain.Model.Action;
using D_DTesting.Domain.Model.Misc;
using D_DTesting.Domain.Model.Objects;

namespace D_DTesting.Domain.Extensions
{
    public static class AbilitiyManager
    {
        private static readonly Dictionary<string, string> _skillKeyAbilityValue = new Dictionary<string, string>()
        {
            { "Acrobatics", "Dexterity" },
            { "Animal Handling", "Wisdom" },
            { "Arcana", "Intelligence" },
            { "Athletics", "Strength" },
            { "Deception", "Charisma" },
            { "History", "Intelligence" },
            { "Insight", "Wisdom" },
            { "Intimidation", "Charisma" },
            { "Investigation", "Intelligence" },
            { "Medicine", "Wisdom" },
            { "Nature", "Intelligence" },
            { "Perception", "Wisdom" },
            { "Performance", "Charisma" },
            { "Persuasion", "Charisma" },
            { "Religion", "Intelligence" },
            { "Sleight of Hand", "Dexterity" },
            { "Stealth", "Dexterity" },
            { "Survival", "Wisdom" }
        };
        public static void SetSavingThrows(this PlayableCharacter pc)
        {
            var AbilityScores = pc.Abilities;

            foreach(var ability in AbilityScores)
            {
                var modifier = CalculateModifier(ability.Score);
                pc.SavingThrow.Add(new SavingThrow
                {
                    Name = ability.Name,
                    DC = modifier
                });
            }
        }

        private static int CalculateModifier(int score)
        {
            return (score - 10) / 2;
        }

        public static void SetSkills(this PlayableCharacter pc)
        {
            foreach(KeyValuePair<string,string> kvp in _skillKeyAbilityValue)
            {
                pc.Skills.Add(new Skill()
                {
                    Name = kvp.Key,
                    ModifierBonus = CalculateModifier(pc.Abilities.Find(x => x.Name == kvp.Value).Score),
                });
            }
        }
    }
}
