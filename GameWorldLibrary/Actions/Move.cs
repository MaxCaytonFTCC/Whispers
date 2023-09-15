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
        public static string[] Keywords { get;} = { "move", "walk", "run", "go", "leave", "exit" };              // Action Keywords
        public static string[] Options { get;} = { "North", "South", "East", "West"};           // Action Choices
        #endregion
        #region Methods
        public static void Do(Player user, string[] input)
        {
            // Check how many tokens a user has inputted
            switch (input.Length)
            {
                // User entered 3 words
                case 3:
                    // No command for 3 words

                // User entered 2 words
                case 2:
                    Activate(user, input[1]);
                    break;

                // User entered 1 word
                default:
                    Activate(user);
                    break;
            }
        }
        #region Command Methods
        public static void Activate(Player user)                        // Move player to another room
        {
            // Display Action Name
            Console.WriteLine($"[{Name.ToUpper()}]");

            // Prompt user for direction
            string input = Menu.Run(Options, true);

            // If option is not Cancel, move to direction
            Activate(user, input);
        }
        #endregion
        #region Command + Option Methods
        public static void Activate(Player user, string direction)
        {
            // Print a movement string

            // Switch
            switch (direction)
            {
                // Player wants to move north
                case "north":
                    // Move player to north exit
                    Activate(user, 0);
                    // Break
                    break;

                // Player wants to move south
                case "south":
                    // Move player to south exit
                    Activate(user, 1);
                    // Break
                    break;

                // Player wants to move east
                case "east":
                    // Move player to east exit
                    Activate(user, 2);
                    // Break
                    break;

                // Player wants to move west
                case "west":
                    // Move player to west exit
                    Activate(user, 3);
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
        #region Command + Argument
        static void Activate(Player user, int index)
        {
            try
            {
                // Get the new room from the index
                Room newRoom = World.rooms[int.Parse(World.rooms[user.Location].Exits[index])]; // Redo exit code so this isn't like this

                // Add player to the new Room
                newRoom.RoomPlayers.Add(user);

                // Remove the player from the old Room
                World.rooms[user.Location].RoomPlayers.Remove(user);

                // Change player Location
                user.Location = newRoom.ID;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        #endregion
        #endregion
    }
}
