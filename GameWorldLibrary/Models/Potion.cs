using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public class Potion : Item
    {
        #region Properties
        // Add affected stat property
        public int ValueChange { get; set; }
        #endregion
        #region Constructors
        // Default Constructor
        public Potion() 
        {
            ValueChange = 0;
            Type = UsableType.Potion;
        }
        // Constructor
        public Potion(int id, string name, int price, bool questItem, bool required, int valueChange, string description, UsableType usableType) : base(id,name,price,questItem,required,description,usableType)
        {
            ValueChange = valueChange;
        }
        // Clone Constructor
        public Potion(Potion basis) : base(basis.ID, basis.Name, basis.Price, basis.QuestItem, basis.Required, basis.Description, basis.Type)
        {
            ValueChange = basis.ValueChange;
        }
        #endregion
        #region Methods

        #region Info Methods
        public override void InfoMore()
        {
            // Show more info
            Console.WriteLine(ID);
            Console.WriteLine(Name);
            Console.WriteLine("$" + Price);
            Console.WriteLine(ValueChange); // Add affected stat here (Ex: HP - ValueChanged)
            Console.WriteLine(Description);
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
