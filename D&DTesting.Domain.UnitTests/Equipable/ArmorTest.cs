using D_DTesting.Domain.UnitTests.Models;

using D_DTesting.Domain.Model.Inventory;


namespace D_DTesting.Domain.UnitTests.Equipable
{
    public class ArmorTest
    {
        private readonly Armor _armor = TestModels.TestArmor;
        private readonly PlayableCharacter _pc = TestModels.PCTest;

        [Test]
        public void ArmorShouldNotBeNull()
        {
            Assert.NotNull(_armor);
        }

        [Test]
        public void ArmorPropertyIsISkill()
        {
            Assert.IsTrue(_armor.Properties.First().Type is ISkill);
        }

        [Test]
        public void ArmorPropertyIsNotISavingThrow()
        {
            Assert.IsFalse(_armor.Properties.First().Type is ISavingThrow);
        }
    }
}
