using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public static class LoadGame
    {

        public static void RunLoad()
        {
            LoadWeapons();            
            LoadTreasures();
            LoadItems();
            LoadPotions();

            LoadMobs();
            LoadRooms();
        }

        public static void LoadWeapons()
        {

            int index = 0;

            using (StreamReader reader = File.OpenText(@"../../../GameWorldLibrary/Docs/weapons.csv"))
            {
                while (!reader.EndOfStream)
                {
                    string[] tokens = reader.ReadLine().Split(',');

                    if (index != 0)
                    {                        
                        World.weapons.Add(new Weapon(int.Parse(tokens[0]),tokens[1],tokens[2],tokens[3],int.Parse(tokens[4]),int.Parse(tokens[5])));
                    }

                    else
                    {
                        index++;
                    }
                }
            }
        }

        public static void LoadItems()
        {

            int index = 0;

            using (StreamReader reader = File.OpenText(@"../../../GameWorldLibrary/Docs/items.csv"))
            {
                while (!reader.EndOfStream)
                {
                    string[] tokens = reader.ReadLine().Split(',');

                    if (index != 0)
                    {
                        World.items.Add(new Item(int.Parse(tokens[0]), tokens[1], int.Parse(tokens[2]), bool.Parse(tokens[3]), bool.Parse(tokens[4]), tokens[5]));
                    }

                    else
                    {
                        index++;
                    }
                }
            }
        }

        public static void LoadTreasures()
        {

            int index = 0;

            using (StreamReader reader = File.OpenText(@"../../../GameWorldLibrary/Docs/treasures.csv"))
            {
                while (!reader.EndOfStream)
                {
                    string[] tokens = reader.ReadLine().Split(',');

                    if (index != 0)
                    {
                        World.treasures.Add(new Treasure(int.Parse(tokens[0]), tokens[1], int.Parse(tokens[2]), bool.Parse(tokens[3]), tokens[4]));
                    }

                    else
                    {
                        index++;
                    }
                }
            }
        }

        public static void LoadPotions()
        {

            int index = 0;

            using (StreamReader reader = File.OpenText(@"../../../GameWorldLibrary/Docs/potions.csv"))
            {
                while (!reader.EndOfStream)
                {
                    string[] tokens = reader.ReadLine().Split(',');

                    if (index != 0)
                    {
                        World.potions.Add(new Potion(int.Parse(tokens[0]), tokens[1], int.Parse(tokens[2]), int.Parse(tokens[3]), tokens[4]));
                    }

                    else
                    {
                        index++;
                    }
                }
            }
        }

        public static void LoadMobs()
        {
            int index = 0;

            using (StreamReader reader = File.OpenText(@"../../../GameWorldLibrary/Docs/mobs.csv"))
            {
                while (!reader.EndOfStream)
                {
                    string[] tokens = reader.ReadLine().Split(',');

                    if (index != 0)
                    {
                        // TODO Build Lists with new IDs
                        World.mobs.Add(new Mob(int.Parse(tokens[0]),tokens[1],tokens[2],tokens[3],int.Parse(tokens[4]),int.Parse(tokens[5]),tokens[6],tokens[7], new List<Treasure>()));
                    }

                    else
                    {
                        index++;
                    }
                }
            }
        }

        public static void LoadRooms()
        {

            int index = 0;

            using (StreamReader reader = File.OpenText(@"../../../GameWorldLibrary/Docs/rooms.csv"))
            {
                while (!reader.EndOfStream)
                {
                    string[] tokens = reader.ReadLine().Split(',');

                    if (index != 0)
                    {
                        World.rooms.Add(new Room(int.Parse(tokens[0]),tokens[1], tokens[2],Room.GetExits(tokens[3]),Room.GetItems(tokens[4]),Room.GetMobs(tokens[5]),Room.GetWeapons(tokens[6]),Room.GetTreasure(tokens[7]),Room.GetPotion(tokens[8]),new List<Player>()));
                    }

                    else
                    {
                        index++;
                    }
                }
            }

        }

        public static void InitializeStartingRoom(Player player)
        {
            World.rooms[player.Location].RoomPlayers.Add(player);
        }
    }
}
