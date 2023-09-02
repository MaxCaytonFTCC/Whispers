/**
* 5/5/2023
* CSC 153
* Group 3
* This program plays the game Whispers
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
            LoadGame.RunLoad();

            // Welcome the User
            DisplayRequested.DisplayWelcomeInstructions();

            // Create Character
            //World.player = PlayerMaker.CreateNewPlayer();
            World.player = new Player();
            LoadGame.InitializeStartingRoom(World.player);

            // Display Starting Room       
            DisplayRequested.DisplayRooms(0);
            Console.WriteLine("");

            // Game Loop
            do
            {
                //Get Input
                Console.WriteLine("");
                Command.GetInput();
                Console.WriteLine("");

            }
            while (Game.running);
        }

    }
}