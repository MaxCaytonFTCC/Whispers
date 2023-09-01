using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public class Player
    {
        #region Properties
        public int ID { get; set; }                             // ID
        public string Name { get; set; }                        // Name
        public string Password { get; set; }                    // Password
        public string Race { get; set; }                        // Race
        public string CombatClass { get; set; }                 // Combat Class
        public int HP { get; set; }                             // Health Points
        public int AC { get; set; }                             // im dumb i cant remember what this means
        public Room Location { get; set; }                      // Location
        public List<Item> ItemInventory { get; set; }           // Items
        public List<Potion> PotionInventory { get; set; }       // Potions
        public List<Weapon> WeaponInventory { get; set; }       // Weapons
        public List<Treasure> TreasureInventory { get; set; }   // Treasures
        public List<string> Quests { get; set; }                // Quests
        #endregion
        #region Constructors
        // Default Constructor
        public Player() { }
        // Constructor
        public Player(int id, string name, string password, string race, string combatClass, int hp, int ac, int location, List<Item> itemInventory, List<Potion> potionInventory, List<Weapon> weaponInventory, List<Treasure> treasureInventory, List<string> quests)
        {
            ID = id;
            Name = name;
            Password = password;
            Race = race;
            CombatClass = combatClass;
            HP = hp;
            AC = ac;
            Location = location;
            PotionInventory = potionInventory;
            ItemInventory = itemInventory;
            WeaponInventory = weaponInventory;
            TreasureInventory = treasureInventory;
            Quests = quests;
        }
        #endregion
        #region Methods
        #region Info Methods
        public void Info()
        {
            // Show info
            Console.WriteLine(Name);
            Console.WriteLine(Race);
            Console.WriteLine(CombatClass);
            Console.WriteLine();
        }
        public void InfoMore()
        {
            // Show more info
            Console.WriteLine(ID);
            Console.WriteLine(Name);
            Console.WriteLine(Race);
            Console.WriteLine(CombatClass);
            Console.WriteLine();
        }
        #endregion
        #endregion
        #region Public Methods

        public static Player CreateNewPlayer()
        {
            DisplayRequested.DisplayCharacterCreatorBanner();

            string name, password, race, combatClass;
            Player newPlayer;

            // Select Race
            DisplayRequested.DisplayRaceInstructions();
            race = GetCharacterChoice(Console.ReadLine(),"Undead","Elemental","Demon","Mechanical");

            // Select Class
            DisplayRequested.DisplayClassInstructions();
            combatClass = GetCharacterChoice(Console.ReadLine(),"Warrior","Necromancer","Assassin","Firelord");

            // Get Name
            DisplayRequested.DisplayNameInstructions();
            name = GetCharacterName(Console.ReadLine());

            // Get Password
            DisplayRequested.DisplayPasswordInstructions();
            password = GetCharacterPassword(Console.ReadLine());
            Console.WriteLine("");

            // Create Player Object
            newPlayer = new Player(0, name, password, race,combatClass,100,0,0,new List<Item>(), new List<Potion>(), new List<Weapon>(), new List<Treasure>(),new List<string>());

            // Create & Save Player File
            CreatePlayerFile(newPlayer);

            return newPlayer;
        }

        public static void MovePlayer(Player player, int targetLocation)
        {
            // Remove Player from previous Room
            World.rooms[player.Location].RoomPlayers.Remove(player);            

            // Add Player to target Room
            World.rooms[targetLocation].RoomPlayers.Add(player);
            player.Location = targetLocation;
        }

        public static Weapon SelectWeapon(Player player)
        {

            // Get All Available Weapons
            List<Weapon> currentWeapons = new List<Weapon>();

            foreach (Weapon weapon in World.player.WeaponInventory)
            {
                currentWeapons.Add(weapon);
            }

            if (currentWeapons.Count < 1)
            {
                Weapon fists = new Weapon(-1,"Fists","You probably should've made sure you had a weapon before picking a fight","Bludgeoning",0,1);                               
                return fists;
            }

            else
            {
                string choice = Console.ReadLine();

                try
                {
                    // Pick Weapon
                    return currentWeapons[int.Parse(choice) - 1];
                }

                catch
                {
                    DisplayRequested.DisplayInputError();
                    return SelectWeapon(player);
                }
            }

        }
        

        // TODO Add Character Selection In a Future Iteration
        
        #endregion

        #region Private Methods
        private static string GetCharacterChoice(string choice, string option1, string option2, string option3, string option4)
        {
            switch (choice)
            {
                case "1":
                    return option1;
                    break;
                case "2":
                    return option2;
                    break;
                case "3":
                    return option3;
                    break;
                case "4":
                    return option4;
                    break;
                default:
                    DisplayRequested.DisplayInputError();                   
                    return GetCharacterChoice(Console.ReadLine(),option1,option2,option3,option4);
                    break;
            }
        }

        private static string GetCharacterName(string playerName)
        {
            int maxChars = 12;
            string finalName;

            if (playerName.Length > maxChars)
            {
                DisplayRequested.DisplayInputTooLongError();
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
                DisplayRequested.DisplayPasswordError();
                return GetCharacterPassword(Console.ReadLine());
            }

        }

        private static void CreatePlayerFile(Player player)
        {

            StreamWriter outputFile;

            try
            {
                outputFile = File.CreateText(@"../../../GameWorldLibrary/Docs/Players/"+player.Name);
                outputFile.WriteLine(player.ID.ToString()+","+player.Name + "," +player.Password + "," +player.Race + "," +player.CombatClass + "," +player.HP.ToString() + "," +player.AC.ToString() + "," +player.Location.ToString());                
                outputFile.Close();
            }
            catch
            {
                DisplayRequested.DisplayGeneralError();
            }
        }

        #endregion

    }
}
