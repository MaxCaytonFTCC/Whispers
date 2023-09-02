using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public static class Use
    {
        #region Properties
        public static string Name { get; } = "Move";                                     // Action Name
        public static string[] Keywords { get; } = { "move", "walk", "run", "go" };      // Action Keywords
        #endregion
        #region Methods
        #region Command Methods
        public static void Activate(Player user)
        {
            // Prompt object type to Use
            Console.WriteLine("Use");  // Placeholder
        }
        #endregion
        #region Command + Option Methods
        public static void Activate(Player user, Item[] items)
        {
            // Prompt Items to Use
            Console.WriteLine("Items");  // Placeholder
        }
        public static void Activate(Player user, Potion[] potions)
        {
            // Prompt Potions to Use
            Console.WriteLine("Potion");  // Placeholder
        }
        public static void Activate(Player user, Treasure[] treasures)
        {
            // Prompt Items to Use
            Console.WriteLine("Treasures");  // Placeholder
        }
        public static void Activate(Player user, Weapon[] weapons)
        {
            // Prompt Items to Use
            Console.WriteLine("Weapons");  // Placeholder
        }
        #endregion
        #endregion
    }
}
