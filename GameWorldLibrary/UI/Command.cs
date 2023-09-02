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

            // Read the user's input
            ReadInput(tokens);
        }
        static void ReadInput(string[] input)
        {
            // If the Help action is called
            if (Help.Keywords.Contains(input[0]))
            {
                // Display Help
                Help.Activate();
            }

            // If the Move action is called
            if (Move.Keywords.Contains(input[0]))
            {
                // Move the player
                Move.Activate(World.player);
            }

            // If the Pick Up action is called
            // If the Drop action is called
            // If the Use action is called
            // If the Attack action is called

            // If the Quit action is called
            if (Quit.Keywords.Contains(input[0]))
            {
                // Quit the game
                Quit.Activate();
            }

            // Readline debug
            Console.ReadLine();
        }
    }
}
