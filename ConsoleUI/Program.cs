/**
* 5/5/2023
* CSC 153
* Max Cayton
* This program plays the game World of Villainy.
*/

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameWorldLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {            
            string input;
            LoadGame.RunLoad();

            // Welcome the User
            DisplayRequested.DisplayWelcomeInstructions();

            // Create Character
            World.player = Player.CreateNewPlayer();
            LoadGame.InitializeStartingRoom(World.player);

            // Display Starting Room       
            DisplayRequested.DisplayRooms(0);
            Console.WriteLine("");

            // Game Loop
            while (Commands.keepGoing == 'y')
            {
                //Get Input
                DisplayRequested.DisplayCommandArrow();

                input = Console.ReadLine();

                Console.WriteLine("");
                Commands.RunCommand(input.ToLower());
                Console.WriteLine("");

            }
            Console.ReadKey();
        }

    }
}