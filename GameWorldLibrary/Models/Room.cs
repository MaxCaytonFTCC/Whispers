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
        public int[] Exits { get; set; }
        public List<Item> RoomItems { get; set; }
        public List<Weapon> RoomWeapons { get; set; }
        public List<Treasure> RoomTreasures { get; set; }
        public List<Potion> RoomPotions { get; set; }
        public List<Mob> RoomMobs { get; set; }
        public List<Player> RoomPlayers { get; set; }
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
            RoomItems = roomItems;
            RoomMobs = roomMobs;
            RoomWeapons = roomWeapons;
            RoomTreasures = roomTreasures;
            RoomPotions = roomPotions;
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
            // If there are no Items in the Room
            if (RoomItems.Count == 0)
            {
                // Print message
                Console.WriteLine("There are no items here");
            }
            // If there are Items in the Room
            else
            {
                // For every Item in list
                foreach (Item item in RoomItems)
                {
                    // Display Item Info
                    item.Info();
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
        public void InfoWeapons()       // Show Weapon Names and Descriptions
        {
            // If there are no Weapons in the Room
            if (RoomWeapons.Count == 0)
            {
                // Print message
                Console.WriteLine("There are no weapons here");
            }
            // If there are Weapons in the Room
            else
            {
                // For every Weapon in list
                foreach (Weapon weapon in RoomWeapons)
                {
                    // Display Weapon Info
                    weapon.Info();
                }
            }
        }
        public void InfoTreasures()     // Show Treasure Names and Descriptions
        {
            // If there are no Treasures in the Room
            if (RoomTreasures.Count == 0)
            {
                // Print message
                Console.WriteLine("There are no treasures here");
            }
            // If there are Treasures in the Room
            else
            {
                // For every Treasure in list
                foreach (Treasure treasure in RoomTreasures)
                {
                    // Display Treasure Info
                    treasure.Info();
                }
            }
        }
        public void InfoPotions()       // Show Potion Names and Descriptions
        {
            // If there are no Potions in the Room
            if (RoomPotions.Count == 0)
            {
                // Print message
                Console.WriteLine("There are no potions here");
            }
            // If there are Potions in the Room
            else
            {
                // For every Potion in list
                foreach (Potion potion in RoomPotions)
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
        #endregion
        // Split into separate Class
        public static int[] GetSubArray(string array_string)
        {
            // Split string into tokens
            string[] tokens = array_string.Split('_');

            // Create int array
            int[] int_array = new int[tokens.Length];

            // For every token
            for (int i = 0; i < tokens.Length; i++)
            {
                // If token entry is empty, replace with a -1
                int_array[i] = (tokens[i] != "") ? int.Parse(tokens[i]): -1;
            }

            // Return int array
            return int_array;
        }

        public static List<Item> GetItems(string items)
        {
            int[] item_tokens = GetSubArray(items);

            List<Item> itemList = new List<Item>();

            // Cut item list entries if first entry is -1
            if (item_tokens[0] == -1)
            {
                return itemList;
            }

            for (int i = 0; i < item_tokens.Length; i++)
            {
                itemList.Add(World.items[item_tokens[i]]);
            }

            return itemList;

        }

        public static List<Mob> GetMobs(string mobs)
        {
            string[] tokens = mobs.Split('_');
            List<Mob> mobList = new List<Mob>();

            if (tokens[0] == "-1")
            {
                return mobList;
            }

            for (int i = 0; i < tokens.Length; i++)
            {
                mobList.Add(World.mobs[int.Parse(tokens[i])]);
            }

            return mobList;

        }

        public static List<Weapon> GetWeapons(string weapons)
        {
            string[] tokens = weapons.Split('_');
            List<Weapon> weaponList = new List<Weapon>();

            if (tokens[0] == "-1")
            {
                return weaponList;
            }

            for (int i = 0; i < tokens.Length; i++)
            {
                weaponList.Add(World.weapons[int.Parse(tokens[i])]);
            }

            return weaponList;

        }

        public static List<Treasure> GetTreasures(string treasures)
        {
            string[] tokens = treasures.Split('_');
            List<Treasure> treasureList = new List<Treasure>();

            if (tokens[0] == "-1")
            {
                return treasureList;
            }

            for (int i = 0; i < tokens.Length; i++)
            {
                treasureList.Add(World.treasures[int.Parse(tokens[i])]);
            }

            return treasureList;

        }

        public static List<Potion> GetPotions(string potions)
        {
            string[] tokens = potions.Split('_');
            List<Potion> potionList = new List<Potion>();

            if (tokens[0] == "-1")
            {
                return potionList;
            }

            for (int i = 0; i < tokens.Length; i++)
            {
                potionList.Add(World.potions[int.Parse(tokens[i])]);
            }

            return potionList;

        }
        #endregion
    }
}
