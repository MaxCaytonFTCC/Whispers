using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public class Look : OptionAction
    {
        #region Methods
        public Look() : base()
        {
            ID = 3;
            Name = "Look";
            Keywords = new string[] { "show", "look", "inspect" };
            Options = new string[] { "Items", "Potions", "Treasures", "Weapons", "Mobs" };
        }
        #endregion
        #region Command Methods
        public override void Activate(Player user)
        {
            // Use command
            Console.WriteLine($"[{Name.ToUpper()}]");

            // Prompt user for object type
            string input = Menu.Run(Options, true);

            // Move to Command + Option Method
            Activate(user, input); // Debug
        }

        public override void Activate(Player user, string option)
        {
            // Switch
            switch (option)
            {
                // Player wants to inspect Items
                case "item":
                case "items":
                    // Get Items in Room
                    World.rooms[World.player.Location].InfoItems();
                    // Break
                    break;

                // Player wants to inspect Potions
                case "potion":
                case "potions":
                    // Get Potions in Room
                    World.rooms[World.player.Location].InfoPotions();
                    // Break
                    break;

                // Player wants to inspect Treasures
                case "treasure":
                case "treasures":
                    // Get Treasures in Room
                    World.rooms[World.player.Location].InfoTreasures();
                    // Break
                    break;

                // Player wants to inspect Weapons
                case "weapon":
                case "weapons":
                    // Get Weapons in Room
                    World.rooms[World.player.Location].InfoWeapons();
                    // Break
                    break;

                // Player wants to inspect Mobs
                case "mob":
                case "mobs":
                    // Get Mobs in Room
                    World.rooms[World.player.Location].InfoMobs();
                    // Break
                    break;

                // Player wants to Cancel Action
                default:
                    Console.WriteLine("Cancel");  // Placeholder
                    // Break
                    break;
            }
            // Readline
            Console.WriteLine("[CONTINUE]");
            Console.ReadLine();
        }
        #endregion
    }
}
