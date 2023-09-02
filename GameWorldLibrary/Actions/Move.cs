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
        public static string Name { get;} = "Move";                                             // Action Name
        public static string[] Keywords { get;} = { "move", "walk", "run", "go" };              // Action Keywords
        public static string[] Options { get;} = { "North", "South", "East", "West"};           // Action Choices
        #endregion
        #region Methods
        #region Command Methods
        public static void Activate(Player user)                        // Move player to another room
        {
            // Display Action Name
            Console.WriteLine($"[{Name.ToUpper()}]");

            // Prompt user for direction
            string input = Menu.Run(Options);

            // If option is not Cancel, move to direction
            Console.WriteLine(input); // Debug
            Console.ReadLine(); // Debug
        }
        #endregion
        #region Command + Option Methods
        public static void Activate(Player user, string direction)
        {
            // Switch
            switch (direction)
            {
                // Player wants to move north
                case "north":
                    // Move player to north exit
                    // Break
                    break;

                // Player wants to move south
                case "south":
                    // Move player to north exit
                    // Break
                    break;

                // Player wants to move east
                case "east":
                    // Move player to north exit
                    // Break
                    break;

                // Player wants to move west
                case "west":
                    // Move player to north exit
                    // Break
                    break;

                // Player wants to cancel
                case "cancel":
                    // Break
                    break;

                // Invalid direction
                default:
                    // Print no direction string
                    // Break
                    break;
            }
            // Move player to another room
            Console.WriteLine("Move");  // Placeholder
        }
        #endregion
        #endregion
    }
}
