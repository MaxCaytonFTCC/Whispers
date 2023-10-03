using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    class Look
    {
        #region Properties
        public static string Name { get; } = "Look";                                                 // Action Name
        public static string[] Keywords { get; } = { "show", "look", "inspect" };                                       // Action Keywords
        public static string[] Options { get; } = { "Items", "Potions", "Treasures", "Weapons", "Mobs" };    // Action Choices
        #endregion
        #region Methods
        public static void Do(Player user, string[] input)
        {
            // Check how many tokens a user has inputted
            switch (input.Length)
            {
                // User entered 3 words
                case 3:
                    // No command for 3 words

                // User entered 2 words
                case 2:
                    Activate(user, input[1]);
                    break;

                // User entered 1 word
                default:
                    Activate(user);
                    break;
            }
        }
        #region Command Methods
        public static void Activate(Player user)
        {
            // Use command
            Console.WriteLine($"[{Name.ToUpper()}]");

            // Prompt user for object type
            string input = Menu.Run(Options, true);

            // Move to Command + Option Method
            Activate(user, input); // Debug
        }
        #endregion
        #region Command + Option Methods
        public static void Activate(Player user, string option)
        {
            // Switch
            switch (option)
            {
                // Player wants to inspect Items
                case "items":
                    // Get Items in Room
                    World.rooms[World.player.Location].InfoItems();
                    // Break
                    break;

                // Player wants to inspect Potions
                case "potions":
                    // Get Potions in Room
                    World.rooms[World.player.Location].InfoPotions();
                    // Break
                    break;

                // Player wants to inspect Treasures
                case "treasures":
                    // Get Treasures in Room
                    World.rooms[World.player.Location].InfoTreasures();
                    // Break
                    break;

                // Player wants to inspect Weapons
                case "weapons":
                    // Get Weapons in Room
                    World.rooms[World.player.Location].InfoWeapons();
                    // Break
                    break;

                // Player wants to inspect Mobs
                case "mobs":
                    // Get Mobs in Room
                    World.rooms[World.player.Location].InfoMobs();
                    // Break
                    break;

                // Player wants to Cancel Action
                default:
                    Console.WriteLine("Cancel");  // Placeholder
                    // Break
                    break;
            }
            // Readline
            Console.WriteLine("[CONTINUE]");
            Console.ReadLine();
        }
        #endregion
        #endregion
    }
}
