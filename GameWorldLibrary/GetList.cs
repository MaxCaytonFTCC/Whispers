using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameWorldLibrary
{
    public static class GetList
    {
        public static List<Item> Item (List<Item> itemList, UsableType type)
        {
            // Create empty list of usables
            List<Item> results = new List<Item>();

            // Loop through every usable
            foreach (Item usable in itemList)
            {
                // If usable's type is being looked for
                if (usable.Type == type)
                {
                    // Add usable to list of type
                    results.Add(usable);
                }
            }

            // Return results list
            return results;
        }

        public static int[] SubArray(string array_string)
        {
            // Split string into tokens
            string[] tokens = array_string.Split('_');

            // Create int array
            int[] int_array = new int[tokens.Length];

            // For every token
            for (int i = 0; i < tokens.Length; i++)
            {
                // If token entry is empty, replace with a -1
                int_array[i] = (tokens[i] != "") ? int.Parse(tokens[i]) : -1;
            }

            // Return int array
            return int_array;
        }

        public static List<Item> ItemsfromString(string items)
        {
            int[] item_tokens = SubArray(items);

            List<Item> itemList = new List<Item>();

            // Cut item list entries if first entry is -1
            if (item_tokens[0] == -1)
            {
                return itemList;
            }

            for (int i = 0; i < item_tokens.Length; i++)
            {
                // Add clone of item
                itemList.Add(new Item(World.items[item_tokens[i]]));
            }

            return itemList;
        }

        public static List<Mob> MobsfromString(string mobs)
        {
            int[] mob_tokens = SubArray(mobs);

            List<Mob> mobList = new List<Mob>();

            if (mob_tokens[0] == -1)
            {
                return mobList;
            }

            for (int i = 0; i < mob_tokens.Length; i++)
            {
                // Add clone of mob
                mobList.Add(new Mob(World.mobs[mob_tokens[i]]));
            }

            return mobList;
        }

        public static List<Weapon> WeaponsfromString(string weapons)
        {
            int[] weapon_tokens = SubArray(weapons);

            List<Weapon> weaponList = new List<Weapon>();

            if (weapon_tokens[0] == -1)
            {
                return weaponList;
            }

            for (int i = 0; i < weapon_tokens.Length; i++)
            {
                // Add clone of weapon
                weaponList.Add(new Weapon(World.weapons[weapon_tokens[i]]));
            }

            return weaponList;
        }

        public static List<Treasure> TreasuresfromString(string treasures)
        {
            int[] treasure_tokens = SubArray(treasures);
            List<Treasure> treasureList = new List<Treasure>();

            if (treasure_tokens[0] == -1)
            {
                return treasureList;
            }

            for (int i = 0; i < treasure_tokens.Length; i++)
            {
                // Add clone of treasure
                treasureList.Add(new Treasure(World.treasures[treasure_tokens[i]]));
            }

            return treasureList;

        }

        public static List<Potion> PotionsfromString(string potions)
        {
            int[] potion_tokens = SubArray(potions);
            List<Potion> potionList = new List<Potion>();

            if (potion_tokens[0] == -1)
            {
                return potionList;
            }

            for (int i = 0; i < potion_tokens.Length; i++)
            {
                // Add clone of potion
                potionList.Add(new Potion(World.potions[potion_tokens[i]]));
            }

            return potionList;

        }
    }
}
