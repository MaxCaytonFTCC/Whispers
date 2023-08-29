using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public class Potion
    {

        // Default Constructor
        public Potion() { }

        public Potion(int id, string name, int price, int valueChange, string description)
        {
            ID = id;
            Name = name;
            Price = price;
            ValueChange = valueChange;
            Description = description;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int ValueChange { get; set; }
        public string Description { get; set; }

    }
}
