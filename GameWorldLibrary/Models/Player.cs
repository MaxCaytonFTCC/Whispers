using GameWorldLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public class Player : Entity
    {
        #region Properties
        public string Password { get; set; }                    // Password
        public int Location { get; set; }
        public List<string> Quests { get; set; }                // Quests
        #endregion
        #region Constructors
        // Default Constructor
        public Player() { }
        // Constructor
        public Player(int id, string name, string password, string race, string combatClass, int hp, int ac, int location, List<Item> inventory, EquipmentSlots equipmentSlots, List<string> quests) : base(id, name, race, combatClass, hp, ac, inventory, equipmentSlots)
        {
            Location = location;
            Password = password;
            Quests = quests;
        }
        #endregion

        #region Methods

        public static Weapon SelectWeapon(Entity player)
        {
            // Use LINQ to get all weapons the player has                    
            var availableWeapons = (from weapon in player.Inventory
                                    where weapon is Weapon
                                    select weapon).ToList();
            
            Display.DisplayItemList(availableWeapons);

            int selection = -1;
            while ((selection - 1) < 0 || (selection - 1) > availableWeapons.Count - 1)
            {
                try
                {
                    Console.Write("\nSelect your weapon: ");
                    selection = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
                catch
                {
                    Console.WriteLine("Please select a valid weapon number");
                    selection = -1;
                }

            }
            
            return (Weapon)availableWeapons[selection-1];
            
        }

        public override void EntityDie(int location)
        {
            // Get World mobs that excludes the mob who is dead
            HP = 1;
            Location = 0;
            Display.DisplayDeathMessage();
            
        }

        #endregion


    }
}
