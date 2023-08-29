using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public class Treasure
    {
        // Default Constructor
        public Treasure() { }

        public Treasure(int id, string name, int price, bool questItem, string description)
        {
            ID = id;
            Name = name;
            Price = price;
            QuestItem = questItem;
            Description = description;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public bool QuestItem { get; set; }
        public string Description { get; set; }
    }
}
