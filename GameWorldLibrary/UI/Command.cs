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
            // Clear Console
            Console.Clear();

            // Display Room Info
            World.rooms[World.player.Location].Info();

            // Get command tokens from player
            string[] tokens = Input.StrArray();

            // Read the user's input
            ReadInput(tokens);
        }
        static void ReadInput(string[] input)
        {
            // Clear console
            Console.Clear();

            // Initialize command strings
            Action chosen_action = null;
            string option = "";

            // Select the command using a keyword
            foreach (Action action in Game.actions)
            {
                // If the chosen word is in the action's keywords
                if (action.Keywords.Contains(input[0]))
                {
                    chosen_action = action;
                }
            }

            // Select the command option
            if (input.Length > 1)
            {
                option = input[1];
            }

            // If an action was chosen
            if (chosen_action != null)
            {
                // If chosen action is an option action
                if (chosen_action.Type == ActionType.Option)
                {
                    // Change action type
                    OptionAction action = (OptionAction)chosen_action;

                    // If option is empty
                    if (option == "")
                    {
                        action.Activate(World.player);
                    }
                    // If option is not empty
                    else
                    {
                        action.Activate(World.player, option);
                    }
                }
                // Chosen action is a basic action
                else
                {
                    chosen_action.Activate(World.player);
                }
            }
        }
    }
}
