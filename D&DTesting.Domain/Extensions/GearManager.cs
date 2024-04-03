using D_DTesting.Domain.Abstractions;
using D_DTesting.Domain.Model.Inventory;
using D_DTesting.Domain.Model.Objects;

namespace D_DTesting.Domain.Extensions
{
    public static class GearManager
    {
        public static void EquipGear(this PlayableCharacter player, IEquipable gear)
        {
            if (gear is Armor armor)
            {
                EquipArmor(player, armor);
            }
            else if (gear is Weapon weapon)
            {
                EquipWeapon(player, weapon);
            }
        }
        public static void UnEquipGear(this PlayableCharacter player, IEquipable gear)
        {
            if (gear is Armor armor)
            {
                UnEquipArmor(player, armor);
            }
            else if (gear is Weapon weapon)
            {
                UnequipWeapon(player, weapon);
            }
        }
        public static void StoreItem(this PlayableCharacter player, IItem item)
        {
            player.Bag.Items.Add(item);
            player.Bag.CurrentWeight += item.Weight;
        }
        public static void RemoveItem(this PlayableCharacter player, IItem item)
        {
            player.Bag.Items.Remove(item);
            player.Bag.CurrentWeight -= item.Weight;
        }

        private static void EquipArmor(PlayableCharacter player, Armor armor)
        {
            var existingArmor = player.Equipments.FirstOrDefault(e => e is Armor);
            if (existingArmor != null)
            {
                player.Armor -= ((Armor)existingArmor).ArmorValue;
                player.StoreItem((IItem)existingArmor);
                player.Equipments.Remove(existingArmor);
            }
            player.Equipments.Add(armor);
            player.Armor += armor.ArmorValue;
            player.RemoveItem(armor);
        }
        private static void UnEquipArmor(PlayableCharacter player, Armor armor)
        {
            player.Armor -= armor.ArmorValue;
            player.Equipments.Remove(armor);
            player.StoreItem(armor);
        }
        private static void EquipWeapon(PlayableCharacter player, Weapon weapon)
        {
            player.Equipments.Add(weapon);
            player.ActionSets.Add(weapon);
            player.RemoveItem(weapon);
        }
        private static void UnequipWeapon(PlayableCharacter player, Weapon weapon)
        {
            player.Equipments.Remove(weapon);
            player.ActionSets.Remove(weapon);
            player.StoreItem(weapon);
        }
    }
}
