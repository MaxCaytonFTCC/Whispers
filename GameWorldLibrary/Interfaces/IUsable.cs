using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    // Type of Usable
    public enum UsableType
    {
        Item,
        Potion,
        Treasure,
        Weapon
    }

    public interface IUsable
    {
        int ID { get; set; }                // Usable ID
        string Name { get; set; }           // Usable Name
        int Price { get; set; }             // Usable Price
        string Description { get; set; }    // Usable Description
        UsableType Type { get; set; }       // Usable Type

        void Info();                        // Show info for Usable
        void InfoMore();                    // Show more info for Usable
        void Use(Player user);              // REPLACE WHEN PLAYER AND MOB USE INHERITANCE
    }
}
