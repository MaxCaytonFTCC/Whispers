using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public abstract class Usable : IUsable
    {
        #region Properties
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public UsableType Type { get; set; }
        #endregion
        #region Constructors
        // Default Constructor
        public Usable()
        {
            ID = 0;
            Name = "";
            Price = 0;
            Description = "";
            Type = UsableType.Item;
        }
        // Constructor
        public Usable(int id, string name, int price, string description)
        {
            ID = id;
            Name = name;
            Price = price;
            Description = description;
        }
        // Clone Constructor
        public Usable(Usable basis)
        {
            ID = basis.ID;
            Name = basis.Name;
            Price = basis.Price;
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
            Console.WriteLine(Description);
            Console.WriteLine();
        }
        #endregion
        #region Use Methods
        public abstract void Use(Player user);
        #endregion
        #endregion
    }
}
