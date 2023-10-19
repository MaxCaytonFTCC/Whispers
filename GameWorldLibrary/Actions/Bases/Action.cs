using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public enum ActionType
    {
        Single,
        Option
    }

    public abstract class Action : ISingleAction
    {
        #region Properties
        public int ID { get; set; }
        public string Name { get; set; }
        public string[] Keywords { get; set; }
        public ActionType Type { get; set; }
        #endregion
        #region Methods
        public Action()
        {
            Type = ActionType.Single;
        }
        public abstract void Activate(Player user);
        #endregion
    }
}
