﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public abstract class OptionAction : Action, IOptionAction
    {
        #region Properties
        public string[] Options { get; set; }
        #endregion
        #region Methods
        public OptionAction() : base()
        {
            Type = ActionType.Option;
        }
        public abstract void Activate(Player user, string option);
        #endregion
    }
}
