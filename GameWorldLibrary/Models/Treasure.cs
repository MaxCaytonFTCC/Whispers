using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public class Treasure : Usable
    {
        #region Properties
        public bool QuestItem { get; set; }
        #endregion
        #region Constructors
        // Default Constructor
        public Treasure() :
            base()
        {
            QuestItem = false;
            Type = UsableType.Treasure;
        }
        // Constructor
        public Treasure(int id, string name, int price, bool questItem, string description) :
            base(id, name, price, description)
        {
            QuestItem = questItem;
            Type = UsableType.Treasure;
        }
        // Clone Constructor
        public Treasure(Treasure basis) :
            base(basis)
        {
            QuestItem = basis.QuestItem;
            Type = UsableType.Treasure;
        }
        #endregion
        #region Methods
        #region Info Methods
        public override void Info()
        {
            // Use base info method
            base.Info();

            // Show treasure info
            Console.WriteLine("Quest Item: " + QuestItem);
            Console.WriteLine();
        }
        public override void InfoMore()
        {
            // Use base infomore
            base.InfoMore();

            // Show treasure info
            Console.WriteLine("Quest Item: " + QuestItem);
            Console.WriteLine();
        }
        #endregion
        #region Use Methods
        public override void Use(Player user)
        {
            // Use code
        }
        #endregion
        #endregion
    }
}
