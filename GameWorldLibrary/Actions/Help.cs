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
        public static void Activate()
        {
            // Display all commands (Use Action List in Game class)
            Console.WriteLine("Help");  // Placeholder
        }
        #endregion
    }
}
