using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public class Weapon
    {
        public Weapon() { }

        public Weapon(int id, string name, string description, string damageType, int price, int damage)
        {

            ID = id;
            Name = name;
            Description = description;
            Damage = damage;
            DamageType = damageType;
            Price = price;

        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DamageType { get; set; }
        public int Damage { get; set; }        
        public int Price { get; set; }

    }
}
