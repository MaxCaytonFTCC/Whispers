using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public class EquipmentSlots
    {        
        public enum WearLocation // Enumerator for accessing equipment slots on the Player or any other mobs
        {
            Head = 0,
            Chest = 1,
            Legs = 2,
            Weapon = 3
        }

        #region Properties

        public Item[] equippedGear { get; set; } = new Item[4]; // TODO Implement Inheritance for "Armor" & "Weapon" Classes so they can all be used in this "Item" array

        #endregion

        public EquipmentSlots() { } // Default Constructor

        public EquipmentSlots(Item headPiece, Item chestPiece, Item legPiece, Item weapon) // Constructor for intitializing all slots
        {
            equippedGear[(int)WearLocation.Head] = headPiece;
            equippedGear[(int)WearLocation.Chest] = chestPiece;
            equippedGear[(int)WearLocation.Legs] = legPiece;
            equippedGear[(int)WearLocation.Weapon] = weapon;
        }
    }
}
