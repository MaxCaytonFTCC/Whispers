using GameWorldLibrary.Models;
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
    }
}
