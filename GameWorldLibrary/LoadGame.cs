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

            LoadActions();
        }

        public static void LoadWeapons()
        {

            int index = 0;

            using (StreamReader reader = File.OpenText(@"../../../GameWorldLibrary/Docs/csv/weapons.csv"))
            {
                while (!reader.EndOfStream)
                {
                    string[] tokens = reader.ReadLine().Split(',');

                    if (index != 0)
                    {                        
                        World.weapons.Add(new Weapon(int.Parse(tokens[0]),tokens[1],tokens[2],tokens[3],int.Parse(tokens[4]), bool.Parse(tokens[5]), bool.Parse(tokens[6]), int.Parse(tokens[7]),UsableType.Weapon));
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

            using (StreamReader reader = File.OpenText(@"../../../GameWorldLibrary/Docs/csv/items.csv"))
            {
                while (!reader.EndOfStream)
                {
                    string[] tokens = reader.ReadLine().Split(',');

                    if (index != 0)
                    {
                        World.items.Add(new Item(int.Parse(tokens[0]), tokens[1], int.Parse(tokens[2]), bool.Parse(tokens[3]), bool.Parse(tokens[4]), tokens[5], UsableType.Potion));
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

            using (StreamReader reader = File.OpenText(@"../../../GameWorldLibrary/Docs/csv/treasures.csv"))
            {
                while (!reader.EndOfStream)
                {
                    string[] tokens = reader.ReadLine().Split(',');

                    if (index != 0)
                    {
                        World.treasures.Add(new Treasure(int.Parse(tokens[0]), tokens[1], int.Parse(tokens[2]), bool.Parse(tokens[3]), bool.Parse(tokens[4]), tokens[5], UsableType.Potion));
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

            using (StreamReader reader = File.OpenText(@"../../../GameWorldLibrary/Docs/csv/potions.csv"))
            {
                while (!reader.EndOfStream)
                {
                    string[] tokens = reader.ReadLine().Split(',');

                    if (index != 0)
                    {
                        World.potions.Add(new Potion(int.Parse(tokens[0]), tokens[1], int.Parse(tokens[2]), bool.Parse(tokens[3]), bool.Parse(tokens[4]), int.Parse(tokens[5]), tokens[6],UsableType.Potion));
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

            using (StreamReader reader = File.OpenText(@"../../../GameWorldLibrary/Docs/csv/mobs.csv"))
            {
                while (!reader.EndOfStream)
                {
                    string[] tokens = reader.ReadLine().Split(',');

                    if (index != 0)
                    {
                        // TODO Build Lists with new IDs
                        World.mobs.Add(new Mob(int.Parse(tokens[0]),tokens[1],tokens[2],tokens[3],int.Parse(tokens[4]),int.Parse(tokens[5]),tokens[6],tokens[7], new List<Item>(), new EquipmentSlots()));
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

            using (StreamReader reader = File.OpenText(@"../../../GameWorldLibrary/Docs/csv/roomtest.csv"))
            {
                while (!reader.EndOfStream)
                {
                    string[] tokens = reader.ReadLine().Split(',');

                    if (index != 0)
                    {
                        // Construct Room
                        Room room = new Room();

                        // Add basic info
                        room.ID = int.Parse(tokens[0]);
                        room.Name = tokens[1];
                        room.Description = tokens[2];

                        // Move GetObject functions into their own class at some point
                        room.Exits = GetList.SubArray(tokens[3]);

                        // Add to usables list
                        room.RoomItems.Concat(GetList.ItemsfromString(tokens[4]));
                        room.RoomItems.Concat(GetList.PotionsfromString(tokens[5]));
                        room.RoomItems.Concat(GetList.TreasuresfromString(tokens[6]));
                        room.RoomItems.Concat(GetList.WeaponsfromString(tokens[7]));

                        room.RoomMobs = GetList.MobsfromString(tokens[8]);
                        room.RoomPlayers = new List<Player>();

                        // Add the room
                        World.rooms.Add(room);
                    }

                    else
                    {
                        index++;
                    }
                }
            }

        }
        public static void LoadActions()
        {
            // Add Actions
            Game.actions.Add(new Help());
            Game.actions.Add(new Quit());

            // Add Option Actions
            Game.actions.Add(new Look());
            Game.actions.Add(new Move());

            // Sort action list by ID
            Game.actions.OrderBy(x => x.ID);
        }

        public static void InitializeStartingRoom(Player player)
        {
            World.rooms[player.Location].RoomPlayers.Add(player);
        }

        // Method for copying Mob Objects From List to List
        public static void CopyMobToList(ref List<Mob> preivousList, Mob targetMob, ref List<Mob> targetList, bool remove = false)
        {
            // Find mob to copy using LINQ on the previous list
            Mob copyMob = (from mob in preivousList
                           where mob == targetMob
                           select mob);

            // Remove from previous list (if enabled)
            if (remove == true) preivousList.RemoveAll(x => x == copyMob);
           
            // Add to target List
            targetList.Add(copyMob);
        }

    }
}
