using D_DTesting.Domain.Enums;
using D_DTesting.Domain.Model.Action;
using D_DTesting.Domain.Model.Inventory;

namespace D_DTesting.Domain.UnitTests.Models
{
    public static class TestModels
    {
        public static Armor TestArmor = new Armor()
        {
            Name = "Light Armor",
            ArmorValue = 10,
            ArmorType = ArmorType.Light,
            Weight = 10,
            Properties = new List<Property>()
            {
                new Property()
                {
                    Name = "Stealth",
                    Description = "You have disadvantage on Dexterity (Stealth) checks.",
                    Type = new Skill(),
                    Modifier = 0,
                    Advantage = false,
                    Disadvantage = true
                }
            }
        };

        public static PlayableCharacter PCTest = new PlayableCharacter()
        { 
            Name = "Test",
            MaxHealth = 10,
            Size = Size.Medium,
            Bag = new Bag()
            {
                Items = new List<IItem>() { TestArmor }
            },
            Abilities = new List<IAbilitiyScore>()
            {
                new AbilityScores()
                {
                    Name = "Dexterity",
                    Score = 10,
                    ItemScore = 0,
                    Advantage = false,
                    Disadvantage = false
                },
                new AbilityScores()
                {
                    Name = "Strength",
                    Score = 10,
                    ItemScore = 0,
                    Advantage = false,
                    Disadvantage = false
                },
                new AbilityScores()
                {
                    Name = "Constitution",
                    Score = 10,
                    ItemScore = 0,
                    Advantage = false,
                    Disadvantage = false
                },
                new AbilityScores()
                {
                    Name = "Intelligence",
                    Score = 10,
                    ItemScore = 0,
                    Advantage = false,
                    Disadvantage = false
                },
                new AbilityScores()
                {
                    Name = "Wisdom",
                    Score = 10,
                    ItemScore = 0,
                    Advantage = false,
                    Disadvantage = false
                },
                new AbilityScores()
                {
                    Name = "Charisma",
                    Score = 10,
                    ItemScore = 0,
                    Advantage = false,
                    Disadvantage = false
                }
            }
        };
    }
}
