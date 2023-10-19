using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public class Quit : Action
    {
        #region Methods
        public Quit(): base()
        {
            ID = 2;
            Name = "Quit";
            Keywords = new string[] { "quit" };
        }
        public override void Activate(Player user)
        {
            // Quit the game
            Game.running = false;

            // Display Goodbye
        }
        #endregion
    }
}
