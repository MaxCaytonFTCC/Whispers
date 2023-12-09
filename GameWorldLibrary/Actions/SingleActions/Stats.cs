using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public class Stats : Action
    {
        #region Methods
        public Stats() : base()
        {
            ID = 2;
            Name = "Stats";
            Keywords = new string[] {"stat", "stats", "self" };
        }

        #region Commands
        public override void Activate(Player user)
        {
            FormHandler.ShowStats(user);
        }
        #endregion
        #endregion
    }
}
