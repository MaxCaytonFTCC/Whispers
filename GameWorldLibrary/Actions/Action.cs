using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public abstract class Action : ISingleAction
    {
        #region Properties
        public int ID { get;}
        public string Name { get;}
        public string[] Keywords { get;}
        #endregion
        #region Methods
        public Action() { }
        public abstract void Activate(Player user);
        #endregion
    }
}
