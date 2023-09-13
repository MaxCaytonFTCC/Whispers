/**
* 9/13/2023
* CSC 153
* Group 3
* This program plays the game Whispers (cm_branch)
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
            Display.DisplayWelcomeInstructions();

            // Create Character
            World.player = PlayerMaker.CreateNewPlayer();
            //World.player = new Player();
            LoadGame.InitializeStartingRoom(World.player);

            // Game Loop
            do
            {
                //Get Input
                Command.GetInput();
                Console.WriteLine("");

            }
            while (Game.running);
        }

    }
}