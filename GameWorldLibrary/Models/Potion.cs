using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public class Potion
    {
        #region Properties
        // Add affected stat property
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int ValueChange { get; set; }
        public string Description { get; set; }
        #endregion
        #region Constructors
        // Default Constructor
        public Potion() { }
        // Constructor
        public Potion(int id, string name, int price, int valueChange, string description)
        {
            ID = id;
            Name = name;
            Price = price;
            ValueChange = valueChange;
            Description = description;
        }
        // Clone Constructor
        public Potion(Potion basis)
        {
            ID = basis.ID;
            Name = basis.Name;
            Price = basis.Price;
            ValueChange = basis.ValueChange;
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
            Console.WriteLine(ValueChange); // Add affected stat here (Ex: HP - ValueChanged)
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
