using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public class Help : Action
    {
        #region Methods
        public Help() : base()
        {
            ID = 0;
            Name = "Help";
            Keywords = new string[] { "help", "command", "commands" };
        }
        #region Commands
        public override void Activate(Player user)
        {
            foreach(Action action in Game.actions)
            {
                // Write command info
                Console.WriteLine(action.ID);
                Console.WriteLine(action.Name);
                // Write keywords
                Console.Write("Keywords: ");
                for (int i = 0; i < action.Keywords.Length; i++)
                {
                    // If keyword is not last in array
                    if (i != action.Keywords.Length - 1)
                    {
                        Console.Write(action.Keywords[i] + ", ");
                    }
                    // If keyword is last
                    else
                    {
                        Console.WriteLine(action.Keywords[i]);
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("[CONTINUE]");
            Console.ReadLine();
        }
        #endregion
        #endregion
    }
}
