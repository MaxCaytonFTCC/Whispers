using GameWorldLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public class Mob : Entity
    {
        #region Properties
        public string Weapon { get; set; }
        public string Description { get; set; }
        #endregion
        #region Constructors
        // Default Constructor
        public Mob() { }
        // Constructor
        public Mob(int id, string name, string race, string combatClass, int hp, int ac, string weapon, string description, List<Item> itemInventory, List<Potion> potionInventory, List<Weapon> weaponInventory, List<Treasure> treasureInventory, EquipmentSlots equipmentSlots) : base(id, name, race, combatClass, hp, ac, itemInventory, potionInventory, weaponInventory, treasureInventory, equipmentSlots)
        {
            Weapon = weapon;
            Description = description;
        }
        // Clone Constructor
        public Mob(Mob basis) : base(basis.ID, basis.Name, basis.Race, basis.CombatClass, basis.HP, basis.AC, basis.Inventory,basis.EntityEquipmentSlots)
        {
            ID = basis.ID;
            Name = basis.Name;
            Race = basis.Race;
            CombatClass = basis.CombatClass;
            HP = basis.HP;
            AC = basis.AC;
            Weapon = basis.Weapon;
            Description = basis.Description;
            Inventory = basis.Inventory;
        }
        #endregion
        #region Methods
        #region Info Methods
        public override void InfoMore()
        {
            // Show more info
            Console.WriteLine(ID);
            Console.WriteLine(Name);
            Console.WriteLine(Race);
            Console.WriteLine(CombatClass);
            Console.WriteLine(Description);
            Console.WriteLine();
        }
        #endregion
        #endregion
    }
}