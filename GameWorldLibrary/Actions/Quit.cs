using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public static class Quit
    {
        #region Properties
        public static string Name { get;} = "Quit";             // Action Name
        public static string[] Keywords { get;} = { "quit"};    // Action Keywords
        #endregion
        #region Methods
        public static void Activate()
        {
            // Quit the game
            Game.running = false;
        }
        #endregion
    }
}
