using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public class Item : IUsable
    {
        #region Properties
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public bool QuestItem { get; set; }
        public bool Required { get; set; }
        public string Description { get; set; }
        public UsableType Type { get; set; }

        #endregion
        #region Constructors
        // Default Constructor
        public Item() 
        {
            Type = UsableType.Item;
        }
        // Consructor
        public Item(int id, string name, int price, bool questItem, bool required, string description, UsableType usableType)
        {
            ID = id;
            Name = name;
            Price = price;
            QuestItem = questItem;
            Required = required;
            Description = description;
            Type = usableType;
        }
        // Clone Constructor
        public Item(Item basis)
        {
            ID = basis.ID;
            Name = basis.Name;
            Price = basis.Price;
            QuestItem = basis.QuestItem;
            Required = basis.Required;
            Description = basis.Description;
        }
        #endregion
        #region Methods
        #region Info Methods
        public virtual void Info()
        {
            // Show info
            Console.WriteLine(Name);
            Console.WriteLine(Description);
            Console.WriteLine();
        }
        public virtual void InfoMore()
        {
            // Show more info
            Console.WriteLine(ID);
            Console.WriteLine(Name);
            Console.WriteLine("$" + Price);
            Console.WriteLine("Quest Item: " + QuestItem);
            Console.WriteLine("Required: " + Required);
            Console.WriteLine(Description);
            Console.WriteLine();
        }
        #endregion
        #region Use Methods
        public virtual void Use(Player user)
        {
            // Use code
        }
        #endregion
        #endregion
    }
}
