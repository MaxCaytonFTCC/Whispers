using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public class Inv : Action
    {
        #region Methods
        public Inv() : base()
        {
            ID = 3;
            Name = "Inventory";
            Keywords = new string[] { "inv", "inventory" };
        }

        #region Commands
        public override void Activate(Player user)
        {
            // show player inventory
            FormHandler.ShowInv(user);
        }
        #endregion
        #endregion
    }
}
