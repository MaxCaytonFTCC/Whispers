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
        public UsableType Type { get; } = UsableType.Item;
        #endregion
        #region Constructors
        // Default Constructor
        public Item() { }
        // Consructor
        public Item(int id, string name, int price, bool questItem, bool required, string description)
        {
            ID = id;
            Name = name;
            Price = price;
            QuestItem = questItem;
            Required = required;
            Description = description;
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
        public void Info()
        {
            // Show info
            Console.WriteLine(Name);
            Console.WriteLine(Description);
            Console.WriteLine();
        }
        public void InfoMore()
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
        public void Use(Player user)
        {
            // Use code
        }
        #endregion
        #endregion
    }
}
