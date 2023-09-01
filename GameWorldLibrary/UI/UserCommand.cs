using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public static class UserCommand
    {
        public static void GetInput()
        {
            // Get command tokens from player
            string[] tokens = Input.Tokens();

            // Action
        }

        static void ReadInput(string command)
        {
            switch (command)
            {
                case "move":
                    // Break
                    break;
            }
        }
    }
}
