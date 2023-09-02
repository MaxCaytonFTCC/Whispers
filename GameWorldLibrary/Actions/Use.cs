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
        #region Command Methods
        public static void Activate(Player user)
        {
            // Use command
            Console.WriteLine($"[{Name.ToUpper()}]");

            // Prompt user for object type
            string input = Menu.Run(Options);

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
                    // Display Item choices
                    

                    // Break
                    break;

                // Player wants to use Potions
                case "potions":
                    // Display Potion choices
                    

                    // Break
                    break;

                // Player wants to use Treasures
                case "treasures":
                    // Display Treasure choices
                    

                    // Break
                    break;

                // Player wants to use Weapons
                case "weapons":
                    // Display Weapon choices
                    

                    // Break
                    break;

                // Player wants to Cancel Action
                default:
                    // Break
                    break;
            }
            Console.WriteLine();  // Placeholder
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
