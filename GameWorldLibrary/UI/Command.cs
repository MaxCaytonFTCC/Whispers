﻿using System;
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

            // If the Help action is called
            if (Help.Keywords.Contains(input[0]))
            {
                // Display Help
                Help.Do(World.player, input);
            }

            // If the Quit action is called
            if (Quit.Keywords.Contains(input[0]))
            {
                // Quit the game
                Quit.Do(World.player, input);
            }

            // If the Look action is called
            if (Look.Keywords.Contains(input[0]))
            {
                // Look at the Objects in the Room
                Look.Do(World.player, input);
            }

            // If the Move action is called
            if (Move.Keywords.Contains(input[0]))
            {
                // Move the player
                Move.Do(World.player, input);
            }

            // If the Pick Up action is called
            if (PickUp.Keywords.Contains(input[0]))
            {
                // Pick Up and object
                //PickUp.Do(World.player, input);
            }

            // If the Drop action is called
            if (Drop.Keywords.Contains(input[0]))
            {
                // Drop an object
                //Drop.Do(World.player, input);
            }

            // If the Use action is called
            if (Use.Keywords.Contains(input[0]))
            {
                // Use inventory
                Use.Do(World.player, input);
            }

            // If the Attack action is called
            if (Attack.Keywords.Contains(input[0]))
            {
                // Attack a mob
                //Attack.Do(World.player, input);
            }
        }
    }
}
