using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public class Mob
    {

        // Default Constructor
        public Mob() { }


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
            TreasureInventory = treasureInventory;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Race { get; set; }
        public string CombatClass { get; set; }
        public int HP { get; set; }
        public int AC { get; set; }
        public string Weapon { get; set; }
        public string Description { get; set; }
        public List<Treasure> TreasureInventory { get; set; }


    }
}
