using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public class Item
    {
        // Default Constructor
        public Item() { }

        public Item(int id, string name, int price, bool questItem, bool required, string description)
        {
            ID = id;
            Name = name;
            Price = price;
            QuestItem = questItem;
            Required = required;
            Description = description;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public bool QuestItem { get; set; }
        public bool Required { get; set; }
        public string Description { get; set; }

    }
}
