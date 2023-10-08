using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public class Treasure : Item
    {
        #region Constructors
        // Default Constructor
        public Treasure() { }
        // Constructor
        public Treasure(int id, string name, int price, bool questItem, bool required, string description) : base(id, name, price, questItem, required, description) { }
        // Clone Constructor
        public Treasure(Treasure basis) : base(basis.ID, basis.Name, basis.Price, basis.QuestItem, basis.Required, basis.Description) { }
        #endregion
        #region Methods
        #region Use Methods
        public override void Use(Player user)
        {
            // Use code
        }
        #endregion
        #endregion
    }
}
