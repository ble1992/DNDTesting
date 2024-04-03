using D_DTesting.Domain.Abstractions;
using D_DTesting.Domain.Enums;
using D_DTesting.Domain.Model.Action;
using D_DTesting.Domain.Model.Objects;

namespace D_DTesting.Domain.Extensions
{
    public static class SkillManager
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

        public static void SetSkills(this PlayableCharacter pc)
        {
            foreach (KeyValuePair<string, string> kvp in _skillKeyAbilityValue)
            {
                pc.Skills.Add(new Skill()
                {
                    Name = kvp.Key,
                    AbiliitiesModifer = CommonExtensions.CalculateModifier(pc.Abilities.FirstOrDefault(x => x.Name == kvp.Value).Score),
                });
            }
        }

        public static void SetSkillFromItems(this PlayableCharacter pc, IEquipable item)
        {
            if(item.Properties.Any(p => p.Type is ISkill))
            {
                var skillProperty = item.Properties.FirstOrDefault(p => p.Type is ISkill);
                var skill = pc.Skills.FirstOrDefault(s => s.Name == skillProperty.Name);

                skill.ItemModifier += skillProperty.Modifier;

                if(Enum.IsDefined(typeof(ProficiencyBonusType), (int)skill.ProficiencyBonus + skillProperty.Proficiency))
                    skill.ProficiencyBonus = (ProficiencyBonusType)((int)skill.ProficiencyBonus + skillProperty.Proficiency);

                if (skillProperty.Advantage)
                    skill.Advantage = skillProperty.Advantage;

                if (skillProperty.Disadvantage)
                    skill.Disadvantage = skillProperty.Disadvantage;
            }
        }
    }
}
