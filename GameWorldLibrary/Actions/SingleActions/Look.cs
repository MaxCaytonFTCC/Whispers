using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GameWorldLibrary
{
    public class Look : Action
    {
        #region Methods
        public Look() : base()
        {
            ID = 4;
            Name = "Look";
            Keywords = new string[] { "show", "look", "inspect" };
        }

        #region Commands
        public override void Activate(Player user)
        {
            // Show current room
            FormHandler.ShowRoom(World.rooms[user.Location]);
        }
        #endregion
        #endregion
    }
}
