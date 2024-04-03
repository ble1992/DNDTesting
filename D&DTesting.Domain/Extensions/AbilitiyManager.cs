using D_DTesting.Domain.Abstractions;
using D_DTesting.Domain.Model.Misc;
using D_DTesting.Domain.Model.Objects;

namespace D_DTesting.Domain.Extensions
{
    public static class AbilitiyManager
    {
        public static void SetSavingThrows(this PlayableCharacter pc)
        {
            var AbilityScores = pc.Abilities;

            foreach(var ability in AbilityScores)
            {
                var modifier = CommonExtensions.CalculateModifier(ability.Score);
                pc.SavingThrows.Add(new SavingThrow
                {
                    Name = ability.Name,
                    AbilitiyModifier = modifier
                });
            }
        }

        public static void SetAbilityScoreFromItems(this PlayableCharacter pc, IEquipable item)
        {
            if (item.Properties.Any(p => p.Type is IAbilitiyScore))
            {
                var skillProperty = item.Properties.FirstOrDefault(p => p.Type is IAbilitiyScore);
                var skill = pc.Abilities.FirstOrDefault(s => s.Name == skillProperty.Name);

                skill.ItemScore += skillProperty.Modifier;
            }
        }

        public static void SetSavingThrowFromItems(this PlayableCharacter pc, IEquipable item)
        {
            if (item.Properties.Any(p => p.Type is ISavingThrow))
            {
                var skillProperty = item.Properties.FirstOrDefault(p => p.Type is ISavingThrow);
                var skill = pc.SavingThrows.FirstOrDefault(s => s.Name == skillProperty.Name);

                skill.ItemModifier += skillProperty.Modifier;

                if (skillProperty.Advantage)
                    skill.Advantage = skillProperty.Advantage;

                if (skillProperty.Disadvantage)
                    skill.Disadvantage = skillProperty.Disadvantage;
            }
        }
    }
}
