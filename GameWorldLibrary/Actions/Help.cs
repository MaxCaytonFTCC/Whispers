using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public static class Help
    {
        #region Properties
        public static string Name { get;} = "Help";                                     // Action Name
        public static string[] Keywords { get;} = { "help", "command", "commands" };    // Action Keywords
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
                    // No command for 2 words (yet)
                    break;

                // User entered 1 word
                default:
                    Activate();
                    break;
            }
        }
        public static void Activate()
        {
            // Display all commands (Use Action List in Game class)
            Console.WriteLine("Help");  // Placeholder
        }
        #endregion
    }
}
