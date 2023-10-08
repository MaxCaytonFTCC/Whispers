using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary.Models
{
    abstract public class Entity
    {
        #region Properties
        public int ID { get; set; }                             // ID
        public string Name { get; set; }                        // Name
        public string Race { get; set; }                        // Race
        public string CombatClass { get; set; }                 // Combat Class
        public int HP { get; set; }                             // Health Points
        public int AC { get; set; }                             // Armor Class
        
        // TODO Replace lists with new Inventory
        public List<Item> ItemInventory { get; set; } = new List<Item>();               // Items
        public List<Potion> PotionInventory { get; set; } = new List<Potion>();         // Potions
        public List<Weapon> WeaponInventory { get; set; } = new List<Weapon>();         // Weapons
        public List<Treasure> TreasureInventory { get; set; } = new List<Treasure>();   // Treasures
        public EquipmentSlots EntityEquipmentSlots { get; set; } = new EquipmentSlots();
        #endregion

        // Default Constructor
        public Entity() { }

        public Entity(int id, string name, string race, string combatClass, int hp, int ac, List<Item> itemInventory, List<Potion> potionInventory, List<Weapon> weaponInventory, List<Treasure> treasureInventory, EquipmentSlots equipmentSlots)
        {
            ID = id;
            Name = name;
            Race = race;
            CombatClass = combatClass;
            HP = hp;
            AC = ac;
            PotionInventory = potionInventory;
            ItemInventory = itemInventory;
            WeaponInventory = weaponInventory;
            TreasureInventory = treasureInventory;
            EntityEquipmentSlots = equipmentSlots;
        }

        #region Methods

            #region Info Methods

            public virtual void Info()
            {
                // Show info
                Console.WriteLine(Name);
                Console.WriteLine(Race);
                Console.WriteLine(CombatClass);
                Console.WriteLine();
            }
            public virtual void InfoMore()
            {
                // Show more info
                Console.WriteLine(ID);
                Console.WriteLine(Name);
                Console.WriteLine(Race);
                Console.WriteLine(CombatClass);
                Console.WriteLine();
            }

            #endregion

        #endregion

    }
}
