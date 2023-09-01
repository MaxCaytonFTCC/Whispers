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
                // Try to get an integer
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
                    // Show error message
                    Console.WriteLine(e.Message);
                }
            }
        }

        public static string[] Tokens()
        {
            // Prompt user
            Console.Write("Enter a command: ");

            // Return string input
            return Console.ReadLine().ToLower().Split(' ');
        }
    }
}
