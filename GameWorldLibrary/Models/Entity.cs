using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
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
        public List<Item> Inventory { get; set; } = new List<Item>();               // Items
        public EquipmentSlots EntityEquipmentSlots { get; set; } = new EquipmentSlots();
        #endregion

        // Default Constructor
        public Entity() { }

        public Entity(int id, string name, string race, string combatClass, int hp, int ac, List<Item> inventory, EquipmentSlots equipmentSlots)
        {
            ID = id;
            Name = name;
            Race = race;
            CombatClass = combatClass;
            HP = hp;
            AC = ac;
            Inventory = inventory;
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

        #region Combat Methods

        public abstract void EntityDie(int location);        

        #endregion

        #endregion

    }
}
