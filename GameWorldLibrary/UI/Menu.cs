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
        public static string Run(string[] array)     // Returns a String from an array
        {
            // Create an Array using the Strings and a Cancel
            string[] menu = ToMenu(array);

            // Display the menu
            Display.Menu(menu);

            // Get user input
            return Input.Option(array);
        }
        public static Item Run(Item[] array)         // Returns an Item from an array
        {
            // Create an Array using the Item Names and a Cancel
            string[] menu = ToMenu(array);

            // Display the menu
            Display.Menu(menu);

            // Get user input
            return Input.Option(array);
        }
        public static Potion Run(Potion[] array)     // Returns a Potion from an array
        {
            // Create an Array using the Item Names and a Cancel
            string[] menu = ToMenu(array);

            // Display the menu
            Display.Menu(menu);

            // Get user input
            return Input.Option(array);
        }
        public static Treasure Run(Treasure[] array) // Returns a Treasure from an array
        {
            // Loop
            while (true)
            {
                // Catch input that is not a valid index
                try
                {

                }
                // Player enters incorrectly
                catch (Exception e)
                {
                    // Print error message
                    Console.WriteLine(e.Message);
                }
            }
        }
        public static Weapon Run(Weapon[] array)     // Returns a Weapon from an array
        {
            // Loop
            while (true)
            {
                // Catch input that is not a valid index
                try
                {

                }
                // Player enters incorrectly
                catch (Exception e)
                {
                    // Print error message
                    Console.WriteLine(e.Message);
                }
            }
        }
        #endregion
        #region ToMenu Methods
        static string[] ToMenu(string[] array)      // String array to Menu
        {
            // Turn array to list
            List<string> menu = array.ToList();

            // Add Cancel
            menu.Add("Cancel");

            // Return menu
            return menu.ToArray();
        }
        static string[] ToMenu(Item[] array)        // Item array to Menu
        {
            // Create list
            List<string> menu = new List<string>();

            // Add names to menu
            foreach (Item item in array)
            {
                menu.Add(item.Name);
            }

            // Add Cancel
            menu.Add("Cancel");

            // Return menu
            return menu.ToArray();
        }
        static string[] ToMenu(Potion[] array)      // Potion array to Menu
        {
            // Create list
            List<string> menu = new List<string>();

            // Add names to menu
            foreach (Potion potion in array)
            {
                menu.Add(potion.Name);
            }

            // Add Cancel
            menu.Add("Cancel");

            // Return menu
            return menu.ToArray();
        }
        static string[] ToMenu(Treasure[] array)    // Treasure array to Menu
        {
            // Create list
            List<string> menu = new List<string>();

            // Add names to menu
            foreach (Treasure treasure in array)
            {
                menu.Add(treasure.Name);
            }

            // Add Cancel
            menu.Add("Cancel");

            // Return menu
            return menu.ToArray();
        }
        static string[] ToMenu(Weapon[] array)      // Weapon array to Menu
        {
            // Create list
            List<string> menu = new List<string>();

            // Add names to menu
            foreach (Weapon weapon in array)
            {
                menu.Add(weapon.Name);
            }

            // Add Cancel
            menu.Add("Cancel");

            // Return menu
            return menu.ToArray();
        }
        static string[] ToMenu(Mob[] array)         // Mob array to Menu
        {
            // Create list
            List<string> menu = new List<string>();

            // Add names to menu
            foreach (Mob mob in array)
            {
                menu.Add(mob.Name);
            }

            // Add Cancel
            menu.Add("Cancel");

            // Return menu
            return menu.ToArray();
        }
        #endregion
    }
}
