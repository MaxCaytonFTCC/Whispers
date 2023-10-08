using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    // Actions may need to be actual objects so they can be placed into a list maybe
    public interface ISingleAction
    {
        // Single Action: Takes a single Activate argument
        #region Properties
        int ID { get; set; }                 // Command ID: Can use number id to use command
        string Name { get; set; }            // Command Name: Display name
        string[] Keywords { get; set; }      // Command Keywords: Used to call command (can set aliases maybe?)
        #endregion
        #region Abstract Methods
        void Do();
        void Activate();
        #endregion
    }
}
