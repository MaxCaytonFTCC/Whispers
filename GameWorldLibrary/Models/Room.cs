using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public class Room
    {
        #region Properties
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }        
        public string ExitString { get; set; }
        public int[] Exits { get; set; }
        public List<Item> RoomItems { get; set; } = new List<Item>();
        public List<Mob> RoomMobs { get; set; } = new List<Mob>();
        public List<Player> RoomPlayers { get; set; } = new List<Player>();
        #endregion
        #region Constructors
        // Default Constructor
        public Room() { }
        // Constructor
        public Room(int id, string name, string description, int[] exits, List<Item> roomItems, List<Mob> roomMobs, List<Weapon> roomWeapons, List<Treasure> roomTreasures, List<Potion> roomPotions, List<Player> roomPlayers)
        {

            ID = id;
            Name = name;
            Description = description;
            Exits = exits;

            // Add room usables to list
            RoomItems.Concat(roomItems).Concat(roomWeapons).Concat(roomTreasures).Concat(roomPotions);

            // Join lists together after inheritance
            RoomMobs = roomMobs;
            RoomPlayers = roomPlayers;
        }
        #endregion
        #region Methods
        #region Info Methods
        public void Info()              // Show Name and Description
        {   
            Console.WriteLine(Name);
            Console.WriteLine(Description);
            Console.WriteLine();
        }
        public void InfoItems()         // Show Item Names and Descriptions
        {
            // Get Items list
            List<Item> items = GetList.Item(RoomItems, UsableType.Item);

            // If there are no Items in the Room
            if (items.Count == 0)
            {
                // Print message
                Console.WriteLine("There are no items here");
            }
            // If there are Items in the Room
            else
            {
                // For every Item in list (TEST)
                foreach (Item item in items)
                {
                    // Display Item Info
                    item.Info();
                }
            }
        }
        
        public void InfoWeapons()       // Show Weapon Names and Descriptions
        {
            // Get Weapons list
            List<Item> weapons = GetList.Item(RoomItems, UsableType.Item);

            // If there are no Weapons in the Room
            if (weapons.Count == 0)
            {
                // Print message
                Console.WriteLine("There are no weapons here");
            }
            // If there are Weapons in the Room
            else
            {
                // For every Weapon in list
                foreach (Item weapon in weapons)
                {
                    // Display Weapon Info
                    weapon.Info();
                }
            }
        }
        public void InfoTreasures()     // Show Treasure Names and Descriptions
        {
            // Get Treasures list
            List<Item> treasures = GetList.Item(RoomItems, UsableType.Item);

            // If there are no Treasures in the Room
            if (treasures.Count == 0)
            {
                // Print message
                Console.WriteLine("There are no treasures here");
            }
            // If there are Treasures in the Room
            else
            {
                // For every Treasure in list
                foreach (Item treasure in treasures)
                {
                    // Display Treasure Info
                    treasure.Info();
                }
            }
        }
        public void InfoPotions()       // Show Potion Names and Descriptions
        {
            // Get Potions list
            List<Item> potions = GetList.Item(RoomItems, UsableType.Item);

            // If there are no Potions in the Room
            if (potions.Count == 0)
            {
                // Print message
                Console.WriteLine("There are no potions here");
            }
            // If there are Potions in the Room
            else
            {
                // For every Potion in list
                foreach (Item potion in potions)
                {
                    // Display Potion Info
                    potion.Info();
                }
            }
        }
        public void InfoPlayers()       // Show Player Names and Descriptions
        {
            // If there are no Players in the Room
            if (RoomPlayers.Count == 0)
            {
                // Print message
                Console.WriteLine("There are no players here");
            }
            // If there are Players in the Room
            else
            {
                // For every Player in list
                foreach (Player player in RoomPlayers)
                {
                    // Display Player Info
                    player.Info();
                }
            }
        }
        public void InfoMobs()          // Show Mob Names and Descriptions
        {
            // If there are no Mobs in the Room
            if (RoomMobs.Count == 0)
            {
                // Print message
                Console.WriteLine("There are no mobs here");
            }
            // If there are Mobs in the Room
            else
            {
                // For every Mob in list
                foreach (Mob mob in RoomMobs)
                {
                    // Display Mob Info
                    mob.Info();
                }
            }
        }
        #endregion
        #endregion
    }
}
