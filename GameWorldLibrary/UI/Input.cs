using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public static class Input
    {
        #region Basic Return Methods
        public static int Int()        // Get an integer input from the player
        {
            // Loop
            while (true)
            {
                // Catch input that is not an int
                try
                {
                    // Prompt user
                    Console.Write("Enter a number: ");

                    // Return an integer input
                    return int.Parse(Console.ReadLine());
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
        #region Array Return Methods
        public static string[] StrArray()
        {
            // Loop?
            // In case command token (tokens[0]) does not match any known command keyword
            // Maybe should not have removed Convert class
            // Prompt user
            Console.Write("Enter a command: ");

            // Return string input
            return Console.ReadLine().ToLower().Split(' ');
        }
        #endregion
        #region Option Return Methods
        public static string Option(string[] array, bool canCancel)
        {
            // Loop
            while (true)
            {
                // Catch input that is not a valid index
                try
                {
                    // Get player index input
                    int input = Int() - 1;

                    // If index is on the Cancel
                    if (input == array.Length && canCancel)
                    {
                        // Return no items
                        return "cancel";
                    }
                    // If input is not on Cancel
                    else
                    {
                        // Get an Item from index input
                        return array[input].ToLower();
                    }
                }
                // Player enters incorrectly
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        public static Item Option(Item[] array, bool canCancel)
        {
            while (true)
            {
                // Catch input that is not a valid index
                try
                {
                    // Get player index input
                    int input = Int() - 1;

                    // If index is on the Cancel
                    if (input == array.Length && canCancel)
                    {
                        // Return no Items
                        return null;
                    }
                    // If input is not on Cancel
                    else
                    {
                        // Get an Item from index input
                        return array[input];
                    }
                }
                // Player enters incorrectly
                catch (Exception e)
                {
                    // Print error message
                    Console.WriteLine(e.Message);
                }
            }
        }
        public static Potion Option(Potion[] array, bool canCancel)
        {
            while (true)
            {
                // Catch input that is not a valid index
                try
                {
                    // Get player index input
                    int input = Int() - 1;

                    // If index is on the Cancel
                    if (input == array.Length && canCancel)
                    {
                        // Return no Potions
                        return null;
                    }
                    // If input is not on Cancel
                    else
                    {
                        // Get a Potion from index input
                        return array[input];
                    }
                }
                // Player enters incorrectly
                catch (Exception e)
                {
                    // Print error message
                    Console.WriteLine(e.Message);
                }
            }
        }
        public static Treasure Option(Treasure[] array, bool canCancel)
        {
            while (true)
            {
                // Catch input that is not a valid index
                try
                {
                    // Get player index input
                    int input = Int() - 1;

                    // If index is on the Cancel
                    if (input == array.Length && canCancel)
                    {
                        // Return no Treasures
                        return null;
                    }
                    // If input is not on Cancel
                    else
                    {
                        // Get a Treasure from index input
                        return array[input];
                    }
                }
                // Player enters incorrectly
                catch (Exception e)
                {
                    // Print error message
                    Console.WriteLine(e.Message);
                }
            }
        }
        public static Weapon Option(Weapon[] array, bool canCancel)
        {
            while (true)
            {
                // Catch input that is not a valid index
                try
                {
                    // Get player index input
                    int input = Int() - 1;

                    // If index is on the Cancel
                    if (input == array.Length && canCancel)
                    {
                        // Return no Weapons
                        return null;
                    }
                    // If input is not on Cancel
                    else
                    {
                        // Get a Weapon from index input
                        return array[input];
                    }
                }
                // Player enters incorrectly
                catch (Exception e)
                {
                    // Print error message
                    Console.WriteLine(e.Message);
                }
            }
        }
        public static Mob Option(Mob[] array, bool canCancel)
        {
            while (true)
            {
                // Catch input that is not a valid index
                try
                {
                    // Get player index input
                    int input = Int() - 1;

                    // If index is on the Cancel
                    if (input == array.Length && canCancel)
                    {
                        // Return no Mobs
                        return null;
                    }
                    // If input is not on Cancel
                    else
                    {
                        // Get a Mob from index input
                        return array[input];
                    }
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
    }
}
