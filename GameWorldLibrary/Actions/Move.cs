using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public static class Move
    {
        #region Properties
        public static string Name { get;} = "Move";                                     // Action Name
        public static string[] Keywords { get;} = { "move", "walk", "run", "go" };      // Action Keywords
        #endregion
        #region Methods
        public static void Activate(Player user)
        {
            // Move player to another room
            Console.WriteLine("Move");  // Debug
        }
        #endregion
    }
}
