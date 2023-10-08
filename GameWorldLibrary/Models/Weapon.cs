using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public class Weapon : Item
    {
        #region Properties
        public string DamageType { get; set; }
        public int Damage { get; set; }
        #endregion
        #region Constructors
        // Default Constructor
        public Weapon() { }
        // Constructor
        public Weapon(int id, string name, string description, string damageType, int price, bool questItem, bool required, int damage) : base(id, name, price, questItem, required, description)
        {
            Damage = damage;
            DamageType = damageType;
        }
        // Clone Constructor
        public Weapon(Weapon basis) : base(basis.ID, basis.Name, basis.Price, basis.QuestItem, basis.Required, basis.Description)
        {
            Damage = basis.Damage;
            DamageType = basis.DamageType;
        }
        #endregion
        #region Methods
        #region Info Methods
        public override void InfoMore()
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
        public override void Use(Player user)
        {
            // Use code
        }
        #endregion
        #endregion
    }
}
