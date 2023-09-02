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
        // Move (Player)
        public static void Activate(Player user)
        {
            // Move player to another room
            Console.WriteLine("Move");  // Placeholder
        }

        // Move (Player, Direction)
        public static void Activate(Player user, string direction)
        {
            // Move player to another room
            Console.WriteLine("Move");  // Placeholder
        }
        #endregion
    }
}
