using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public static class LoadActions
    {
        public static void Run()
        {
            // Add Actions
            Game.actions.Add(new Quit());

            // Add Option Actions
            Game.actions.Add(new Look());
        }
    }
}
