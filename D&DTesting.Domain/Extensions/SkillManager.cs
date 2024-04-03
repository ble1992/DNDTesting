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

        public static void UnSetSkillsFromItems(this PlayableCharacter pc, IEquipable item)
        {
            if (item.Properties.Any(p => p.Type is ISkill))
            {
                item.Properties.ForEach(p =>
                {
                    var skill = pc.Skills.FirstOrDefault(s => s.Name == p.Name);
                    skill.ItemModifier -= p.Modifier;

                    if (Enum.IsDefined(typeof(ProficiencyBonusType), (int)skill.ProficiencyBonus - p.Proficiency))
                        skill.ProficiencyBonus = (ProficiencyBonusType)((int)skill.ProficiencyBonus - p.Proficiency);

                    if (!pc.Equipments.Any(i => ItemHasSameProperties(item, i)))
                    {
                        if (p.Advantage)
                            skill.Advantage = !skill.Advantage;

                        if (p.Disadvantage)
                            skill.Disadvantage = !skill.Disadvantage;
                    }
                });
            }
        }

        public static void SetSkillFromItems(this PlayableCharacter pc, IEquipable item)
        {
            if(item.Properties.Any(p => p.Type is ISkill))
            {
                item.Properties.ForEach(p =>
                {
                    var skill = pc.Skills.FirstOrDefault(s => s.Name == p.Name);

                    skill.ItemModifier += p.Modifier;

                    if (Enum.IsDefined(typeof(ProficiencyBonusType), (int)skill.ProficiencyBonus + p.Proficiency))
                        skill.ProficiencyBonus = (ProficiencyBonusType)((int)skill.ProficiencyBonus + p.Proficiency);

                    if (p.Advantage)
                        skill.Advantage = p.Advantage;

                    if (p.Disadvantage)
                        skill.Disadvantage = p.Disadvantage;
                });
            }
        }

        private static bool ItemHasSameProperties(this IEquipable item, IEquipable otherItem)
        {
            return item.Properties.All(p => 
            otherItem.Properties.Any(op => op.Name == p.Name 
            && op.Advantage == p.Advantage 
            && op.Disadvantage == p.Disadvantage));
        }
    }
}
