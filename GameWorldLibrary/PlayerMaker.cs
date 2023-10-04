using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public static class PlayerMaker
    {
        #region Public Methods

        public static Player CreateNewPlayer()
        {
            Display.DisplayCharacterCreatorBanner();

            string name, password, race, combatClass;
            Player newPlayer;

            // Select Race
            race = Menu.Run(new string[] { "Undead", "Elemental", "Demon", "Mechanical" }, false);

            // Select Class
            combatClass = Menu.Run(new string[] { "Warrior", "Necromancer", "Assassin", "Firelord" }, false);

            // Get Name
            Display.DisplayNameInstructions();
            name = GetCharacterName(Console.ReadLine());

            // Get Password
            Display.DisplayPasswordInstructions();
            password = GetCharacterPassword(Console.ReadLine());
            Console.WriteLine("");

            // Create Player Object
            newPlayer = new Player(0, name, password, race, combatClass, 100, 0, 0, new List<Item>(), new List<Potion>(), new List<Weapon>(), new List<Treasure>(), new EquipmentSlots(), new List<string>());

            // Create & Save Player File
            CreatePlayerFile(newPlayer);

            return newPlayer;
        }
        // TODO Add Character Selection In a Future Iteration

        #endregion

        #region Private Methods
        private static string GetCharacterName(string playerName)
        {
            int maxChars = 12;
            string finalName;

            if (playerName.Length > maxChars)
            {
                Display.DisplayInputTooLongError();
                return GetCharacterName(Console.ReadLine());
            }

            finalName = char.ToUpper(playerName[0]).ToString();

            for (int i = 1; i < playerName.Length; i++)
            {
                finalName += playerName[i];
            }

            return finalName;

        }

        private static string GetCharacterPassword(string playerPassword)
        {

            bool capital = false, lowerCase = false, special = false;

            foreach (char c in playerPassword)
            {
                // Check for capital & lowercase characters
                if (char.IsUpper(c) == true)
                {
                    capital = true;
                }
                else
                {
                    lowerCase = true;
                }

                if (char.IsSymbol(c) || char.IsPunctuation(c))
                {
                    special = true;
                }
            }

            if (capital && lowerCase && special)
            {
                return playerPassword;
            }
            else
            {
                Display.DisplayPasswordError();
                return GetCharacterPassword(Console.ReadLine());
            }

        }

        private static void CreatePlayerFile(Player player)
        {

            StreamWriter outputFile;

            try
            {
                outputFile = File.CreateText(@"../../../GameWorldLibrary/Docs/Players/" + player.Name);
                outputFile.WriteLine(player.ID.ToString() + "," + player.Name + "," + player.Password + "," + player.Race + "," + player.CombatClass + "," + player.HP.ToString() + "," + player.AC.ToString() + "," + player.Location.ToString());
                outputFile.Close();
            }
            catch
            {
                Display.DisplayGeneralError();
            }
        }

        #endregion
    }
}

