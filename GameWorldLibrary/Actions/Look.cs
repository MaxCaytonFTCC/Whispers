using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public class Look : OptionAction
    {
        #region Properties
        new public string Name { get; } = "Look";
        new public string[] Keywords { get; } = { "show", "look", "inspect" };
        new public string[] Options { get; } = { "Items", "Potions", "Treasures", "Weapons", "Mobs" };
        #endregion
        #region Methods
        public Look() : base() { }
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
        #endregion
        #region Command + Option Methods
        public override void Activate(Player user, string option)
        {
            // Switch
            switch (option)
            {
                // Player wants to inspect Items
                case "items":
                    // Get Items in Room
                    World.rooms[World.player.Location].InfoItems();
                    // Break
                    break;

                // Player wants to inspect Potions
                case "potions":
                    // Get Potions in Room
                    World.rooms[World.player.Location].InfoPotions();
                    // Break
                    break;

                // Player wants to inspect Treasures
                case "treasures":
                    // Get Treasures in Room
                    World.rooms[World.player.Location].InfoTreasures();
                    // Break
                    break;

                // Player wants to inspect Weapons
                case "weapons":
                    // Get Weapons in Room
                    World.rooms[World.player.Location].InfoWeapons();
                    // Break
                    break;

                // Player wants to inspect Mobs
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
