using D_DTesting.Domain.Abstractions;
using D_DTesting.Domain.Enums;
using D_DTesting.Domain.Extensions;
using D_DTesting.Domain.Model.Inventory;

namespace D_DTesting.Domain.Model.Objects
{
    public class PlayableCharacter : IInteractableObject
    {
        public PlayableCharacter()
        {
            ActionSets = new List<IAction>();
            Equipments = new List<IEquipable>();
            Spells = new List<ISpell>();
            SpellInventory = new List<ISpell>();
            Skills = new List<ISkill>();
            Abilities = new List<IAbilitiyScore>();
            SavingThrows = new List<ISavingThrow>();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; } = 1;
        public int CurrentHealth { get; set; }
        public int MaxHealth { get; set; }
        public int Armor { 
            get 
            {
                var armorEquipment = Equipments.Where(x => x.GetType() == typeof(Armor)).Cast<Armor>().ToList();
                return armorEquipment.Sum(x => x.ArmorValue);
            } 
        }
        public int ProficiencyBonus {
            get
            {
                return ProficiencyBonus;
            }
            set 
            {
                this.SetProficiencyBonus(Level);
            }
        }
        public Size Size { get; set; }
        public Status Status { get; set; } = Status.Healthy;
        public int CurrentWeight { 
            get{ 
                return Bag.CurrentWeight + Equipments.Sum(x => x.Weight);
            } 
        }

        public List<IAction> ActionSets { get; set; }
        public Bag Bag { get; set; }
        public List<IEquipable> Equipments { get; set; }
        public List<ISpell> Spells { get; set; }
        public List<ISpell> SpellInventory { get; set; }
        public List<ISkill> Skills { get; set; }
        public List<IAbilitiyScore> Abilities { get; set; }
        public List<ISavingThrow> SavingThrows { get; set; }
        public int Initiative { get; set; }
    }
}
