﻿using D_DTesting.Domain.Model.Inventory;
using D_DTesting.Domain.UnitTests.Models;

namespace D_DTesting.Domain.UnitTests.EquippableAction
{
    public class ArmorActionTest
    {
        private Armor _armor = TestModels.TestArmor;
        private PlayableCharacter _pc = TestModels.PCTest;
        private Weapon _weapon = TestModels.TestWeapon;

        [Test]
        public void ArmorAddingToInventory()
        {
            _pc.StoreItemInInventory(_armor);
            Assert.IsTrue(_pc.Bag.Items.Contains(_armor));
        }

        [Test]
        public void ArmorPropertyCreateStealthDisadvantage()
        {
            _pc.SetSavingThrows();
            _pc.SetSkills();
            _pc.StoreItemInInventory(_armor);
            _pc.EquipGear(_armor);
            Assert.IsTrue(_pc.Skills.First(a => a.Name == "Stealth").Disadvantage);
        }

        [Test]
        public void ArmorShouldIncreaseArmorValue()
        {
            _pc.SetSavingThrows();
            _pc.SetSkills();
            _pc.StoreItemInInventory(_armor);
            _pc.EquipGear(_armor);
            Assert.AreEqual(_armor.ArmorValue, _pc.Armor);
        }

        [Test]
        public void ArmorUnEquipShouldRemoveStealthDisadvantage()
        {
            _pc.SetSavingThrows();
            _pc.SetSkills();
            _pc.StoreItemInInventory(_armor);
            _pc.EquipGear(_armor);
            _pc.UnEquipGear(_armor);
            Assert.IsFalse(_pc.Skills.First(a => a.Name == "Stealth").Disadvantage);
        }

        [Test]
        public void ArmorUnEquipShouldStillHaveStealthDisadvantageFromDagger()
        {
            _pc.SetSavingThrows();
            _pc.SetSkills();
            _pc.StoreItemInInventory(_weapon);
            _pc.StoreItemInInventory(_armor);
            _pc.EquipGear(_armor);
            _pc.EquipGear(_weapon);
            _pc.UnEquipGear(_armor);
            Assert.IsTrue(_pc.Skills.First(a => a.Name == "Stealth").Disadvantage);
        }
    }
}
