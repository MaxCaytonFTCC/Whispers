using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public class SQLiteDataAccess
    {
        public static List<Item> LoadItems()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {               
                var output = cnn.Query<Item>("select * from Item", new DynamicParameters()); // Returns An Item to an IEnumerable which will be then converted to a list
                return output.ToList();               
            }
        }

        public static List<Mob> LoadMobs()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Mob>("select * from Mob", new DynamicParameters());
                return output.ToList();
            }
        }

        #region Player Data Methods
        public static List<Player> LoadPlayers()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Player>("select * from Player", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SavePlayer(Player player)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                // Save Data into Player Table
                cnn.Execute("INSERT INTO Player (Name, Race, CombatClass, HP, AC, Password, Location) VALUES (@Name, @Race, @CombatClass, @HP, @AC, @Password, @Location)", player);

                // Save Player's Inventory Data
                foreach (Item item in player.Inventory)
                {
                    cnn.Execute("INSERT INTO PlayerInventory (PlayerID, ItemID, ItemType) VALUES ("+player.ID.ToString()+", @ID, @Type)", item);
                }            
            }
        }
        #endregion

        public static List<Potion> LoadPotions()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Potion>("select * from Potion", new DynamicParameters());
                return output.ToList();
            }
        }

        #region Loading Room Methods

        public static List<Room> LoadRooms()
        {
            List<Room> roomListOutput;
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Room>("select * from Room", new DynamicParameters());
                roomListOutput = output.ToList();
            }
         
            // Add Data from other related tables (RoomItems etc.)
            foreach (Room room in roomListOutput)
            {
                room.Exits = GetList.SubArray(room.ExitString);
                room.RoomItems = LoadRoomItems(room.ID.ToString());
                room.RoomMobs = LoadRoomMobs(room.ID.ToString());
                room.RoomPlayers = LoadRoomPlayers(room.ID.ToString());
            }
            
            return roomListOutput;
        }

        private static List<Item> LoadRoomItems(string roomID)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                // SQL Query for getting items assigned to the room by its ID
                string sql = @"
                    SELECT *
                    FROM Item
                    INNER JOIN RoomItems ON Item.ID = RoomItems.ItemID
                    WHERE RoomItems.RoomID ="+roomID+";";
                            
                var output = cnn.Query<Item>(sql, new DynamicParameters());
                return output.ToList();
            }
        }

        private static List<Mob> LoadRoomMobs(string roomID)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                // SQL Query for getting mobs assigned to the room by its ID
                string sql = @"
                    SELECT *
                    FROM Mob
                    INNER JOIN RoomMobs ON Mob.ID = RoomMobs.MobID
                    WHERE RoomMobs.RoomID =" + roomID + ";";

                var output = cnn.Query<Mob>(sql, new DynamicParameters());
                return output.ToList();
            }
        }

        private static List<Player> LoadRoomPlayers(string roomID)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                // SQL Query for getting players assigned to the room by its ID
                string sql = @"
                    SELECT *
                    FROM Player
                    INNER JOIN RoomPlayers ON Player.ID = RoomPlayers.PlayerID
                    WHERE RoomPlayers.RoomID =" + roomID + ";";

                var output = cnn.Query<Player>(sql, new DynamicParameters());
                return output.ToList();
            }
        }

        #endregion

        public static List<Treasure> LoadTreasures()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Treasure>("select * from Treasure", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<Weapon> LoadWeapons()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Weapon>("select * from Weapon", new DynamicParameters());
                return output.ToList();
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

    }
}
