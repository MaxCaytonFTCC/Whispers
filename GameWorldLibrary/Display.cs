using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public static class Display
    {
        public static void DisplayWelcomeInstructions()
        {
            Console.WriteLine("Welcome to World Of Villainy!\n");
            Console.WriteLine("Create a character to begin\n");
        }

        public static void Help()
        {
            Console.WriteLine("Type \"help\" for a list of commands\n");
        }

        #region Info Methods
        #endregion

        #region Menu Methods
        public static void Menu(string[] array)        // String Menu
        {
            // Display the String Menu
            for (int i = 0; i < array.Length; i++)
            {
                // Print options and index + 1
                Console.WriteLine($"[{i + 1}] {array[i]}");
            }
        }
        #endregion

        public static void DisplayRooms(int location)
        {
            Console.WriteLine("Current Room: " + World.rooms[location].Name);
            Console.WriteLine("Room Description: " + World.rooms[location].Description);

            // Room Exits
            Console.WriteLine("\nRoom Exits: ");

            for (int i = 0; i < World.rooms[location].Exits.Length; i++)
            {
                Console.WriteLine((i + 1).ToString() + ". " + World.rooms[World.rooms[location].Exits[i]].Name);
            }

            Console.WriteLine("\nType \"Move [Exit Number]\" to move to that room.");

        }

        public static void DisplayObject(int location, string type)
        {
            switch (type)
            {
                case "items":
                    // Display Items
                    World.rooms[location].InfoItems();

                    // Break
                    break;

                case "mobs":
                    // Display Mobs
                    World.rooms[location].InfoMobs();

                    // Break
                    break;

                case "weapons":
                    // Display Weapons
                    World.rooms[location].InfoWeapons();

                    // Break
                    break;
                
                case "treasures":
                    // Display Treasures
                    World.rooms[location].InfoTreasures();

                    // Break
                    break;

                case "potions":
                    // Display Potions
                    World.rooms[location].InfoPotions();

                    // Break
                    break;

                default:
                    // Should not run unless error
                    Console.WriteLine("You shouldn't be here.");

                    // Break
                    break;
            }
        }

        public static void DisplayCommandArrow()
        {
            Console.Write("=> ");
        }

        public static void DisplayGeneralError()
        {
            Console.WriteLine("Something went wrong... Try Again");
        }
        public static void DisplayInputError()
        {
            Console.WriteLine("Invalid input. Please Try Again");
        }

        public static void DisplayInputTooLongError()
        {
            Console.WriteLine("Input too long. Please Try Again");
        }

        public static void DisplayPasswordError()
        {
            Console.WriteLine("Password is invalid. Please Try Again\nPasswords must have 1 Capital Letter, 1 Lowercase Letter, and 1 Special Character.");
        }

        public static void DisplayMovementError()
        {
            Console.WriteLine("You cannot move that way. Try another direction.");
        }

        public static void DisplayCharacterCreatorBanner()
        {
            Console.WriteLine("\n----CHARACTER CREATOR----\n");
        }

        public static void DisplayPasswordInstructions()
        {
            Console.Write("\nCreate your Character's Password: ");
        }

        public static void DisplayNameInstructions()
        {
            Console.Write("\nEnter your name: ");
        }

        public static void DisplayNoWeaponMessage()
        {
            Console.WriteLine("You don't have any weapons! You are forced to use your fists.\n");
        }

        public static void DisplayWeaponInstructions()
        {
            // Get weapons list
            List<IUsable> weapons = GetList.Usable(World.player.Inventory, UsableType.Weapon);

            if (weapons.Count < 1)
            {
                DisplayNoWeaponMessage();
            }
            else
            {
                for (int i = 0; i < weapons.Count; i++)
                {
                    Console.WriteLine((i + 1).ToString() + ". " + weapons[i].Name);
                    Console.WriteLine("Weapon Description: " + weapons[i].Description + "\n");
                }

                Console.Write("Select a weapon to fight with: ");

            }            
        }

        public static void DisplayDeathMessage()
        {
            Console.WriteLine("\n-----YOU DIED, RETURNING TO STARTING ROOM-----\n");
        }

        public static void DisplayHelpMessage()
        {
            Console.WriteLine("----HELP----");
            Console.WriteLine("Commands:\nhelp - Displays this list of commands\nmove [exit number] - Moves to a room\nget [item type] [item number] - Picks up an item\ndrop [item type] [item number] - Drops an item\ninventory [item type] - Displays an inventory\n[item type/mob] - Displays all of that item or all mobs in your current room\nfight [mob number] - Fights a mob\nquit - Quits the game\n ");
        }

    }
}