using D_DTesting.Domain.Model.Inventory;
using D_DTesting.Domain.UnitTests.Models;

namespace D_DTesting.Domain.UnitTests.Equipable
{
    public class WeaponTest
    {
        private Weapon _weapon = TestModels.TestWeapon;
        private PlayableCharacter _pc = TestModels.PCTest;

        [Test]
        public void WeaponShouldNotBeNull()
        {
            Assert.IsNotNull(_weapon);
        }

        [Test]
        public void WeaponAddingToInventory()
        {
            _pc.StoreItemInInventory(_weapon);
            Assert.IsTrue(_pc.Bag.Items.Contains(_weapon));
        }

        [Test]
        public void WeaponShouldBeInMoveSetWhenEquip()
        {
            _pc.SetSavingThrows();
            _pc.SetSkills();
            _pc.StoreItemInInventory(_weapon);
            _pc.EquipGear(_weapon);
            Assert.IsTrue(_pc.ActionSets.Contains(_weapon));
        }

        [Test]
        public void WeaponShouldBeAnIItemClass()
        {
            Assert.IsTrue(_weapon is IItem);
        }

        [Test]
        public void WeaponShouldBeAnIEquipableClass()
        {
            Assert.IsTrue(_weapon is IEquipable);
        }

        [Test]
        public void WeaponShouldBeAnIActionClass()
        {
            Assert.IsTrue(_weapon is IAction);
        }

        [Test]
        public void WeaponPropertyIsISkill()
        {
            Assert.IsTrue(_weapon.Properties.First().Type is ISkill);
        }

        [Test]
        public void ArmorPropertyIsNotISavingThrow()
        {
            Assert.IsFalse(_weapon.Properties.First().Type is ISavingThrow);
        }
    }
}
