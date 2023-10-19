using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public class Quit : Action
    {
        #region Properties
        new public static string Name { get;} = "Quit";             // Action Name
        new public static string[] Keywords { get;} = { "quit"};    // Action Keywords
        #endregion
        #region Methods
        public override void Activate(Player user)
        {
            // Quit the game
            Game.running = false;

            // Display Goodbye
        }
        #endregion
    }
}
