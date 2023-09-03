using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public static class Menu
    {
        #region Run Methods
        public static string Run(string[] array, bool canCancel)        // Returns a String from an array
        {
            // Create an Array using the Strings and a Cancel
            string[] menu = ToMenu(array, canCancel);

            // Display the menu
            Display.Menu(menu);

            // Get user input
            return Input.Option(array, canCancel);
        }
        public static Item Run(Item[] array, bool canCancel)            // Returns an Item from an array
        {
            // Create an Array using the Item Names and a Cancel
            string[] menu = ToMenu(array, canCancel);

            // Display the menu
            Display.Menu(menu);

            // Get user input
            return Input.Option(array, canCancel);
        }
        public static Potion Run(Potion[] array, bool canCancel)        // Returns a Potion from an array
        {
            // Create an Array using the Item Names and a Cancel
            string[] menu = ToMenu(array, canCancel);

            // Display the menu
            Display.Menu(menu);

            // Get user input
            return Input.Option(array, canCancel);
        }
        public static Treasure Run(Treasure[] array, bool canCancel)    // Returns a Treasure from an array
        {
            // Create an Array using the Item Names and a Cancel
            string[] menu = ToMenu(array, canCancel);

            // Display the menu
            Display.Menu(menu);

            // Get user input
            return Input.Option(array, canCancel);
        }
        public static Weapon Run(Weapon[] array, bool canCancel)        // Returns a Weapon from an array
        {
            // Create an Array using the Item Names and a Cancel
            string[] menu = ToMenu(array, canCancel);

            // Display the menu
            Display.Menu(menu);

            // Get user input
            return Input.Option(array, canCancel);
        }
        public static Mob Run(Mob[] array, bool canCancel)              // Returns a Mob from an array
        {
            // Create an Array using the Item Names and a Cancel
            string[] menu = ToMenu(array, canCancel);

            // Display the menu
            Display.Menu(menu);

            // Get user input
            return Input.Option(array, canCancel);
        }
        #endregion
        #region ToMenu Methods
        static string[] ToMenu(string[] array, bool canCancel)          // String array to Menu
        {
            // Turn array to list
            List<string> menu = array.ToList();

            // Add Cancel
            if (canCancel)
                menu.Add("Cancel");

            // Return menu
            return menu.ToArray();
        }
        static string[] ToMenu(Item[] array, bool canCancel)            // Item array to Menu
        {
            // Create list
            List<string> menu = new List<string>();

            // Add names to menu
            foreach (Item item in array)
            {
                menu.Add(item.Name);
            }

            // Add Cancel
            if (canCancel)
                menu.Add("Cancel");

            // Return menu
            return menu.ToArray();
        }
        static string[] ToMenu(Potion[] array, bool canCancel)          // Potion array to Menu
        {
            // Create list
            List<string> menu = new List<string>();

            // Add names to menu
            foreach (Potion potion in array)
            {
                menu.Add(potion.Name);
            }

            // Add Cancel
            if (canCancel)
                menu.Add("Cancel");

            // Return menu
            return menu.ToArray();
        }
        static string[] ToMenu(Treasure[] array, bool canCancel)        // Treasure array to Menu
        {
            // Create list
            List<string> menu = new List<string>();

            // Add names to menu
            foreach (Treasure treasure in array)
            {
                menu.Add(treasure.Name);
            }

            // Add Cancel
            if (canCancel)
                menu.Add("Cancel");

            // Return menu
            return menu.ToArray();
        }
        static string[] ToMenu(Weapon[] array, bool canCancel)          // Weapon array to Menu
        {
            // Create list
            List<string> menu = new List<string>();

            // Add names to menu
            foreach (Weapon weapon in array)
            {
                menu.Add(weapon.Name);
            }

            // Add Cancel
            if (canCancel)
                menu.Add("Cancel");

            // Return menu
            return menu.ToArray();
        }
        static string[] ToMenu(Mob[] array, bool canCancel)             // Mob array to Menu
        {
            // Create list
            List<string> menu = new List<string>();

            // Add names to menu
            foreach (Mob mob in array)
            {
                menu.Add(mob.Name);
            }

            // Add Cancel
            if (canCancel)
                menu.Add("Cancel");

            // Return menu
            return menu.ToArray();
        }
        #endregion
    }
}
