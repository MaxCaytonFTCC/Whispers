using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public class Potion : Usable
    {
        #region Properties
        // Add affected stat property
        public int ValueChange { get; set; }
        #endregion
        #region Constructors
        // Default Constructor
        public Potion() : base()
        {
            ValueChange = 0;
            Type = UsableType.Potion;
        }
        // Constructor
        public Potion(int id, string name, int price, int valueChange, string description) :
            base(id, name, price, description)
        {
            ValueChange = valueChange;
            Type = UsableType.Potion;
        }
        // Clone Constructor
        public Potion(Potion basis) :
            base(basis)
        {
            ValueChange = basis.ValueChange;
            Type = UsableType.Potion;
        }
        #endregion
        #region Methods
        #region Info Methods
        public override void Info()
        {
            // Show base info
            base.Info();

            // Show potion info
            Console.WriteLine(Name);
            Console.WriteLine(Description);
            Console.WriteLine();
        }
        public override void InfoMore()
        {
            // Show base informore
            base.InfoMore();

            // Show potion info
            Console.WriteLine(ValueChange); // Add affected stat here (Ex: HP - ValueChanged)
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
