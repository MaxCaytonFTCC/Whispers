using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public class Player
    {
        #region Properties
        public int ID { get; set; }                             // ID
        public string Name { get; set; }                        // Name
        public string Password { get; set; }                    // Password
        public string Race { get; set; }                        // Race
        public string CombatClass { get; set; }                 // Combat Class
        public int HP { get; set; }                             // Health Points
        public int AC { get; set; }                             // im dumb i cant remember what this means
        public int Location { get; set; }                       // Location
        public List<Item> ItemInventory { get; set; } = new List<Item>();               // Items
        public List<Potion> PotionInventory { get; set; } = new List<Potion>();         // Potions
        public List<Weapon> WeaponInventory { get; set; } = new List<Weapon>();         // Weapons
        public List<Treasure> TreasureInventory { get; set; } = new List<Treasure>();   // Treasures
        public List<string> Quests { get; set; }                // Quests
        #endregion
        #region Constructors
        // Default Constructor
        public Player() { }
        // Constructor
        public Player(int id, string name, string password, string race, string combatClass, int hp, int ac, int location, List<Item> itemInventory, List<Potion> potionInventory, List<Weapon> weaponInventory, List<Treasure> treasureInventory, List<string> quests)
        {
            ID = id;
            Name = name;
            Password = password;
            Race = race;
            CombatClass = combatClass;
            HP = hp;
            AC = ac;
            Location = location;
            PotionInventory = potionInventory;
            ItemInventory = itemInventory;
            WeaponInventory = weaponInventory;
            TreasureInventory = treasureInventory;
            Quests = quests;
        }
        #endregion
        #region Methods
        #region Info Methods
        public void Info()
        {
            // Show info
            Console.WriteLine(Name);
            Console.WriteLine(Race);
            Console.WriteLine(CombatClass);
            Console.WriteLine();
        }
        public void InfoMore()
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
