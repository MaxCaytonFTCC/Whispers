/**
* 12/3/2023 
* CSC 253
* Group 3
* Group Members: Max Cayton, Kevin McCroary, Joseph McCollum
* This program plays the game "Whispers"
*/

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameWorldLibrary;
using System.Windows.Forms;
using WinUI;
using System.Threading;

namespace ConsoleUI
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            // Launch Game Main Menu
            Application.Run(new GameMainMenu());

            LoadGame.RunLoad();

            // Welcome the User
            Display.DisplayWelcomeInstructions();

            // Create Character
            World.player = PlayerMaker.CreateNewPlayer();
            LoadGame.InitializeStartingRoom(World.player);

            // Boot forms
            FormHandler.Boot();

            Console.ReadKey();

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