using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public class Mob
    {
        #region Properties
        public int ID { get; set; }
        public string Name { get; set; }
        public string Race { get; set; }
        public string CombatClass { get; set; }
        public int HP { get; set; }
        public int AC { get; set; }
        public string Weapon { get; set; }
        public string Description { get; set; }
        public List<Usable> Inventory { get; set; } = new List<Usable>();
        #endregion
        #region Constructors
        // Default Constructor
        public Mob() { }
        // Constructor
        public Mob(int id, string name, string race, string combatClass, int hp, int ac, string weapon, string description, List<Treasure> treasureInventory)
        {
            ID = id;
            Name = name;
            Race = race;
            CombatClass = combatClass;
            HP = hp;
            AC = ac;
            Weapon = weapon;
            Description = description;
            Inventory.Concat(treasureInventory);
        }
        // Clone Constructor
        public Mob(Mob basis)
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
        public void Info()
        {
            // Show info
            Console.WriteLine(Name);
            Console.WriteLine(Description);
            Console.WriteLine();
        }
        public void InfoMore()
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
