using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    // Option Action: An action that takes and option which changes its output
    public interface IOptionAction
    {
        #region Properties
        string[] Options { get; }
        #endregion
        #region Methods
        void Activate(Player user, string option);
        #endregion
    }
}
