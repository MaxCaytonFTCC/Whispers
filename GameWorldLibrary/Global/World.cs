using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public static class World
    {

        // Player
        public static Player player;

        // Rooms
        public static List<Room> rooms = new List<Room>();

        // Weapons
        public static List<Weapon> weapons = new List<Weapon>();

        // Potions
        public static List<Potion> potions = new List<Potion>();

        // Treasures
        public static List<Treasure> treasures = new List<Treasure>();

        // Items
        public static List<Item> items = new List<Item>();

        // Mobs
        public static List<Mob> mobs = new List<Mob>();

    }
}
