using D_DTesting.Domain.Abstractions;
using D_DTesting.Domain.Enums;
using D_DTesting.Domain.Extensions;

namespace D_DTesting.Domain.Model.Objects
{
    public class PlayableCharacter : IInteractableObject
    {
        public PlayableCharacter()
        {
            ActionSets = new List<IAction>();
            Inventories = new List<IItem>();
            Equipments = new List<IEquipable>();
            Spells = new List<ISpell>();
            SpellInventory = new List<ISpell>();
            Skills = new List<ISkill>();
            Abilities = new List<IAbilitiyScore>();
            SavingThrow = new List<ISavingThrow>();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int CurrentHealth { get; set; }
        public int MaxHealth { get; set; }
        public int Armor { get; set; }
        public Size Size { get; set; }
        public Status Status { get; set; } = Status.Healthy;
        public int Weight { get; set; }

        public List<IAction> ActionSets { get; set; }
        public List<IItem> Inventories { get; set; }
        public List<IEquipable> Equipments { get; set; }
        public List<ISpell> Spells { get; set; }
        public List<ISpell> SpellInventory { get; set; }
        public List<ISkill> Skills { get; set; }
        public List<IAbilitiyScore> Abilities { get; set; }
        public List<ISavingThrow> SavingThrow { get; set; }
        public int Initiative { get; set; }

        public void EquipGear(IEquipable gear)
        {
            GearManager.EquipGear(this, gear);
        }
        public void UnEquipGear(IEquipable gear)
        {
            GearManager.UnEquipGear(this, gear);
        }

        public void StoreItem(IItem item)
        {
            GearManager.StoreItem(this, item);
        }
        public void RemoveItem(IItem item)
        {
            GearManager.RemoveItem(this, item);
        }
    }
}
