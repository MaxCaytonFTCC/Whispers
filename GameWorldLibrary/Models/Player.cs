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
        public List<Usable> Inventory { get; set; } = new List<Usable>();              // Usables
        public List<string> Quests { get; set; }                // Quests
        public EquipmentSlots PlayerEquipmentSlots { get; set; } = new EquipmentSlots(new Item(0,"Helm of Domination",9000,false,false,"Helm of The Lich King"), new Item(), new Item(), new Item());
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

            // Add inventory lists to main Inventory
            Inventory.Concat(itemInventory).Concat(potionInventory).Concat(weaponInventory).Concat(treasureInventory);

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
