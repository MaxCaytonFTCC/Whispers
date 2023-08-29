using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public class Room
    {
        // Default Constructor
        public Room() { }

        public Room(int id, string name, string description, string[] exits, List<Item> roomItems, List<Mob> roomMobs, List<Weapon> roomWeapons, List<Treasure> roomTreasures, List<Potion> roomPotions, List<Player> roomPlayers)
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


        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string[] Exits { get; set; }
        public List<Item> RoomItems { get; set; }
        public List<Mob> RoomMobs { get; set; }
        public List<Weapon> RoomWeapons { get; set; }
        public List<Treasure> RoomTreasures { get; set; }
        public List<Potion> RoomPotions { get; set; }
        public List<Player> RoomPlayers { get; set; }


        public static string[] GetExits(string exits)
        {
            string[] tokens = exits.Split('_');
            return tokens;
        }

        public static List<Item> GetItems(string items)
        {
            string[] tokens = items.Split('_');
            List<Item> itemList = new List<Item>();

           if (tokens[0] == "-1")
           {
                return itemList;
           }

            for (int i = 0; i < tokens.Length; i++)
            {
                itemList.Add(World.items[int.Parse(tokens[i])]);
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


        public static List<Treasure> GetTreasure(string treasures)
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

        public static List<Potion> GetPotion(string potions)
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

    }

}
