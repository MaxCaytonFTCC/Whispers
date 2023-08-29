using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public class Commands
    {
        public static char keepGoing = 'y';
        public static int roomIndex = 0;
        
        public static void RunCommand(string input)
        {
            // Tokenize input to determine correct commands & target
            string[] tokens = input.Split(' ');

            // Determine Command
            switch (tokens[0])
            {
                case "move":

                    // Get All Available Exits
                    List<string> currentExits = new List<string>();

                    foreach (string exit in World.rooms[World.player.Location].Exits)
                    {
                        currentExits.Add(exit);
                    }

                    try
                    {
                        Player.MovePlayer(World.player, int.Parse(currentExits[int.Parse(tokens[1]) - 1]));
                        DisplayRequested.DisplayRooms(World.player.Location);
                    }

                    catch
                    {
                        DisplayRequested.DisplayInputError();
                    }

                    break;

                case "get":

                    // Switch based on target object type
                    switch (tokens[1])
                    {

                        case "weapon":
                        case "weapons":

                            // Get All Available Weapons
                            List<Weapon> currentWeapons = new List<Weapon>();

                            foreach (Weapon weapon in World.rooms[World.player.Location].RoomWeapons)
                            {
                                currentWeapons.Add(weapon);
                            }

                            try
                            {
                                // Pick Up Weapon
                                World.player.WeaponInventory.Add((currentWeapons[int.Parse(tokens[2]) - 1]));

                                // Remove Weapon from Room
                                World.rooms[World.player.Location].RoomWeapons.Remove((currentWeapons[int.Parse(tokens[2]) - 1]));

                            }

                            catch
                            {
                                DisplayRequested.DisplayInputError();
                            }

                            break;

                        case "item":
                        case "items":

                            List<Item> currentItems = new List<Item>();

                            foreach (Item item in World.rooms[World.player.Location].RoomItems)
                            {
                                currentItems.Add(item);
                            }

                            try
                            {
                                // Pick Up Item
                                World.player.ItemInventory.Add((currentItems[int.Parse(tokens[2]) - 1]));

                                // Remove Item from Room
                                World.rooms[World.player.Location].RoomItems.Remove((currentItems[int.Parse(tokens[2]) - 1]));

                            }

                            catch
                            {
                                DisplayRequested.DisplayInputError();
                            }

                            break;

                        case "treasure":
                        case "treasures":

                            List<Treasure> currentTreasures = new List<Treasure>();

                            foreach (Treasure treasure in World.rooms[World.player.Location].RoomTreasures)
                            {
                                currentTreasures.Add(treasure);
                            }

                            try
                            {
                                // Pick Up Treasure
                                World.player.TreasureInventory.Add((currentTreasures[int.Parse(tokens[2]) - 1]));

                                // Remove Treasure from Room
                                World.rooms[World.player.Location].RoomTreasures.Remove((currentTreasures[int.Parse(tokens[2]) - 1]));

                            }

                            catch
                            {
                                DisplayRequested.DisplayInputError();
                            }

                            break;

                        case "potion":
                        case "potions":

                            List<Potion> currentPotions = new List<Potion>();

                            foreach (Potion potion in World.rooms[World.player.Location].RoomPotions)
                            {
                                currentPotions.Add(potion);
                            }

                            try
                            {
                                // Pick Up Potion
                                World.player.PotionInventory.Add((currentPotions[int.Parse(tokens[2]) - 1]));

                                // Remove Potion from Room
                                World.rooms[World.player.Location].RoomPotions.Remove((currentPotions[int.Parse(tokens[2]) - 1]));

                            }

                            catch
                            {
                                DisplayRequested.DisplayInputError();
                            }

                            break;



                    }

                    break;

                case "drop":

                    // Switch based on target object type
                    switch (tokens[1])
                    {

                        case "weapon":
                        case "weapons":

                            // Get All Available Weapons
                            List<Weapon> currentWeapons = new List<Weapon>();

                            foreach (Weapon weapon in World.player.WeaponInventory)
                            {
                                currentWeapons.Add(weapon);
                            }

                            try
                            {
                                // Drop Weapon
                                World.player.WeaponInventory.Remove((currentWeapons[int.Parse(tokens[2]) - 1]));

                                // Add Weapon to current Room
                                World.rooms[World.player.Location].RoomWeapons.Add((currentWeapons[int.Parse(tokens[2]) - 1]));

                            }

                            catch
                            {
                                DisplayRequested.DisplayInputError();
                            }

                            break;

                        case "item":
                        case "items":

                            List<Item> currentItems = new List<Item>();

                            foreach (Item item in World.player.ItemInventory)
                            {
                                currentItems.Add(item);
                            }

                            try
                            {
                                // Drop Item
                                World.player.ItemInventory.Remove((currentItems[int.Parse(tokens[2]) - 1]));

                                // Add Item to Room
                                World.rooms[World.player.Location].RoomItems.Add((currentItems[int.Parse(tokens[2]) - 1]));

                            }

                            catch
                            {
                                DisplayRequested.DisplayInputError();
                            }

                            break;

                        case "treasure":
                        case "treasures":

                            List<Treasure> currentTreasures = new List<Treasure>();

                            foreach (Treasure treasure in World.player.TreasureInventory)
                            {
                                currentTreasures.Add(treasure);
                            }

                            try
                            {
                                // Drop Treasure
                                World.player.TreasureInventory.Remove((currentTreasures[int.Parse(tokens[2]) - 1]));

                                // Add Treasure to Room
                                World.rooms[World.player.Location].RoomTreasures.Add((currentTreasures[int.Parse(tokens[2]) - 1]));

                            }

                            catch
                            {
                                DisplayRequested.DisplayInputError();
                            }

                            break;

                        case "potion":
                        case "potions":

                            List<Potion> currentPotions = new List<Potion>();

                            foreach (Potion potion in World.player.PotionInventory)
                            {
                                currentPotions.Add(potion);
                            }

                            try
                            {
                                // Drop Potion
                                World.player.PotionInventory.Remove((currentPotions[int.Parse(tokens[2]) - 1]));

                                // Add Potion to Room
                                World.rooms[World.player.Location].RoomPotions.Add((currentPotions[int.Parse(tokens[2]) - 1]));

                            }

                            catch
                            {
                                DisplayRequested.DisplayInputError();
                            }

                            break;



                    }

                    break;

                case "inventory":
                case "i":

                    try
                    {
                        DisplayRequested.DisplayPlayerInventory(World.player, tokens[1]);
                    }

                    catch
                    {
                        DisplayRequested.DisplayInputError();
                    }

                    break;

                case "r":
                case "room":
                case "rooms":

                    DisplayRequested.DisplayRooms(World.player.Location);
                    
                    break;

                case "weapons":
                case "weapon":

                    DisplayRequested.DisplayWeapons(World.player.Location);

                    break;


                case "potions":
                case "potion":

                    DisplayRequested.DisplayPotions(World.player.Location);

                    break;


                case "treasures":
                case "treasure":

                    DisplayRequested.DisplayTreasure(World.player.Location);

                    break;


                case "items":
                case "item":

                    DisplayRequested.DisplayItems(World.player.Location);

                    break;


                case "mobs":
                case "mob":

                    DisplayRequested.DisplayMobs(World.player.Location);

                    break;


                case "fight":

                    // Get all current mobs
                    List<Mob> currentMobs = new List<Mob>();

                    foreach (Mob mob in World.rooms[World.player.Location].RoomMobs)
                    {
                        currentMobs.Add(mob);
                    }

                    try
                    {
                        // Fight Mob
                        Combat.Battle(World.player,currentMobs[int.Parse(tokens[1]) - 1]);
                    }

                    catch
                    {
                        DisplayRequested.DisplayInputError();
                    }

                    break;

                case "help":
                case "h":

                    DisplayRequested.DisplayHelpMessage();

                    break;

                case "exit":
                case "quit":

                    keepGoing = 'n';
                    Console.WriteLine("\nThanks for playing! (Press any key to exit)");

                    break;

                default:
                    DisplayRequested.DisplayInputError();
                    break;

            }


        }
    }
}