using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    // Move player to another room
    public class Move : OptionAction
    {
        #region Methods
        public Move() : base()
        {
            ID = 4;
            Name = "Move";
            Keywords = new string[] { "move", "walk", "run", "go", "leave", "exit" };
            Options = new string[] { "North", "South", "East", "West" };
        }
        #region Command Methods
        public override void Activate(Player user)                        
        {
            // Display Action Name
            Console.WriteLine($"[{Name.ToUpper()}]");

            // Prompt user for direction
            string input = Menu.Run(Options, true);

            // If option is not Cancel, move to direction
            Activate(user, input);
        }

        public override void Activate(Player user, string direction)
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
                Room newRoom = World.rooms[World.rooms[user.Location].Exits[index]];

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
