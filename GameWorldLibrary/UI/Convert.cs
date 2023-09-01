using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public static class Convert
    {
        // Command Keywords
        static string[] helpKeys = { "help", "commands" };
        static string[] waitKeys = { "wait", "sit", "stand" };
        static string[] moveKeys = { "move", "walk" };
        static string[] attackKeys = { "attack", "fight", "hit" };
        static string[] quitKeys = { "quit" };

        public static string Command(string input)     // Convert command keyword to command
        {
            // If help keywords contains user input
            if (helpKeys.Contains(input))
            {
                // Convert to help command
                return Actions.commands[0];
            }

            // If wait keywords contains user input
            if (waitKeys.Contains(input))
            {
                // Convert to wait command
                return Actions.commands[1];
            }

            // If move keywords contains user input
            if (moveKeys.Contains(input))
            {
                // Convert to move command
                return Actions.commands[2];
            }

            // If attack keywords contains user input
            if (attackKeys.Contains(input))
            {
                // Convert to attack command
                return Actions.commands[3];
            }

            // If attack keywords contains user input
            if (attackKeys.Contains(input))
            {
                // Convert to attack command
                return Actions.commands[4];
            }

            // If quit keywords contains user input
            if (quitKeys.Contains(input))
            {
                // Convert to quit command
                return Actions.commands[5];
            }

            // If no keywords contains user input
            return Actions.commands[-1];
        }
    }
}
