using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    // Single Action: An action that does not need any options and that does only one thing
    public interface ISingleAction
    {
        #region Abstract Methods
        void Activate(Player user);        // Activate: Single action activate method
        #endregion
    }
}
