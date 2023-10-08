﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public static class Use
    {
        #region Properties
        public static string Name { get; } = "Use";                                                 // Action Name
        public static string[] Keywords { get; } = { "use" };                                       // Action Keywords
        public static string[] Options { get; } = { "Items", "Potions", "Treasures", "Weapons"};    // Action Choices
        #endregion
        #region Methods
        public static void Do(Player user, string[] input)
        {
            // Check how many tokens a user has inputted
            switch (input.Length)
            {
                // User entered 3 words
                case 3:
                    // No command for 3 words YET

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
            Console.ReadLine(); // Debug
        }
        #endregion
        #region Command + Option Methods
        public static void Activate(Player user, string option)
        {
            // Switch
            switch (option)
            {
                // Player wants to use Items
                case "items":
                    // Get Item selection
                    //Activate(user, Menu.Run(user.ItemInventory.ToArray(), true));
                    // Break
                    break;

                // Player wants to use Potions
                case "potions":
                    // Get Potion selection
                    //Activate(user, Menu.Run(user.PotionInventory.ToArray(), true));
                    // Break
                    break;

                // Player wants to use Treasures
                case "treasures":
                    // Get Treasure selection
                    //Activate(user, Menu.Run(user.TreasureInventory.ToArray(), true));
                    // Break
                    break;

                // Player wants to use Weapons
                case "weapons":
                    // Get Weapon selection
                    //Activate(user, Menu.Run(user.WeaponInventory.ToArray(), true));
                    // Break
                    break;

                // Player wants to Cancel Action
                default:
                    Console.WriteLine("Cancel");  // Placeholder
                    // Break
                    break;
            }
        }
        #endregion
        #region Command + Object Methods
        public static void Activate(Player user, Item item)
        {
            // Ask if player wants to use the Item
        }
        public static void Activate(Player user, Potion potion)
        {
            // Ask if player wants to use the Potion
        }
        public static void Activate(Player user, Treasure treasure)
        {
            // Ask if player wants to use the Treasure
        }
        public static void Activate(Player user, Weapon weapon)
        {
            // Ask if player wants to use the Weapon
        }
        #endregion
        #endregion
    }
}
