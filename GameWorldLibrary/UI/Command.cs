using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public static class Command
    {
        public static void GetInput()
        {
            // Get command tokens from player
            string[] tokens = Input.Tokens();

            // If token count is greater than 1
            ReadInput(tokens[0]);
            // If token count equals 1
            // Read input with parameters
        }

        static void ReadInput(string command)
        {
            // If the Move action is called
            if (Move.Keywords.Contains(command))
            {
                // Move the player
                Move.Activate(World.player);
            }

            // If the Quit action is called
            if (Quit.Keywords.Contains(command))
            {
                // Quit the game
                Quit.Activate(World.player);
            }

            // Readline debug
            Console.ReadLine();
        }
    }
}
