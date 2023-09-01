using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public static class Input
    {
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

        public static string[] Tokens()
        {
            // Loop?
            // In case command token (tokens[0]) does not match any known command keyword
            // Maybe should not have removed Convert class
            // Prompt user
            Console.Write("Enter a command: ");

            // Return string input
            return Console.ReadLine().ToLower().Split(' ');
        }

        public static string StrArray(string[] array)
        { 
            /* Input for String Array
             * ======================
             * Designed to return a choice from an array of string options
             */

            // Catch input that is not a valid index
            try
            {
                // Prompt user
                for (int i = 0; i < array.Length; i++)
                {
                    // Print options and index + 1
                    Console.WriteLine($"{i + 1}. {array[i]}");
                }
                // Get index input from user

            }
            // Player enters incorrectly
            catch (Exception e)
            {
                // Print error message
                Console.WriteLine(e.Message);
            }
            return "";  // DEBUG
        }
    }
}
