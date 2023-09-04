using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public class Weapon
    {
        #region Properties
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DamageType { get; set; }
        public int Damage { get; set; }
        public int Price { get; set; }
        #endregion
        #region Constructors
        // Default Constructor
        public Weapon() { }
        // Constructor
        public Weapon(int id, string name, string description, string damageType, int price, int damage)
        {
            ID = id;
            Name = name;
            Description = description;
            Damage = damage;
            DamageType = damageType;
            Price = price;
        }
        // Clone Constructor
        public Weapon(Weapon basis)
        {
            ID = basis.ID;
            Name = basis.Name;
            Description = basis.Description;
            Damage = basis.Damage;
            DamageType = basis.DamageType;
            Price = basis.Price;
        }
        #endregion
        #region Methods
        #region Info Methods
        public void Info()
        {
            // Show info
            Console.WriteLine(Name);
            Console.WriteLine(Description);
            Console.WriteLine();
        }
        public void InfoMore()
        {
            // Show more info
            Console.WriteLine(ID);
            Console.WriteLine(Name);
            Console.WriteLine(Description);
            Console.WriteLine(DamageType);
            Console.WriteLine(Damage);
            Console.WriteLine("$" + Price);
            Console.WriteLine();
        }
        #endregion
        #region Use Methods
        public void Use(Player user)
        {
            // Use code
        }
        #endregion
        #endregion
    }
}
