using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public class Item : Usable
    {
        #region Properties
        public bool QuestItem { get; set; }
        public bool Required { get; set; }
        #endregion
        #region Constructors
        // Default Constructor
        public Item() : 
            base()
        {
            QuestItem = false;
            Required = false;
            Type = UsableType.Item;
        }
        // Constructor
        public Item(int id, string name, int price, bool questItem, bool required, string description) : 
            base(id, name, price, description)
        {
            QuestItem = questItem;
            Required = required;
            Type = UsableType.Item;
        }
        // Clone Constructor
        public Item(Item basis): 
            base(basis)
        {
            QuestItem = basis.QuestItem;
            Required = basis.Required;
            Type = UsableType.Item;
        }
        #endregion
        #region Methods
        #region Info Methods
        public override void Info()
        {
            // Use base info method
            base.Info();

            // Show item info
            Console.WriteLine("Quest Item: " + QuestItem);
            Console.WriteLine("Required: " + Required);
            Console.WriteLine();
        }
        public override void InfoMore()
        {
            // Use base infomore method
            base.InfoMore();

            // Show item info
            Console.WriteLine("Quest Item: " + QuestItem);
            Console.WriteLine("Required: " + Required);
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
