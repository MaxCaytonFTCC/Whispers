using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public class Weapon : Usable
    {
        #region Properties
        public string DamageType { get; set; }
        public int Damage { get; set; }
        #endregion
        #region Constructors
        // Default Constructor
        public Weapon() :
            base()
        {
            DamageType = "";
            Damage = 0;
            Type = UsableType.Weapon;
        }
        // Constructor
        public Weapon(int id, string name, string description, string damageType, int price, int damage) :
            base(id, name, price, description)
        {
            Damage = damage;
            DamageType = damageType;
            Type = UsableType.Weapon;
        }
        // Clone Constructor
        public Weapon(Weapon basis) :
            base(basis)
        {
            Damage = basis.Damage;
            DamageType = basis.DamageType;
            Type = UsableType.Weapon;
        }
        #endregion
        #region Methods
        #region Info Methods
        public override void Info()
        {
            // Use base info method
            base.Info();

            // Show item info
            Console.WriteLine(DamageType);
            Console.WriteLine(Damage);
            Console.WriteLine();
        }
        public override void InfoMore()
        {
           // Use base info method
            base.Info();

            // Show item info
            Console.WriteLine(DamageType);
            Console.WriteLine(Damage);
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
