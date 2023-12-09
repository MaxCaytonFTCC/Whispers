using GameWorldLibrary;
using GameWorldLibrary.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameWorldLibrary
{
    public static class FormHandler
    {
        public static StatForm _formStat;
        public static InvForm _formInv;
        public static void Boot()
        {
            // Create all forms
            _formStat = new StatForm();     // Create Stat Form
            _formInv = new InvForm();       // Create Inv Form
        }

        public static void ShowStats(Entity target)
        {
            _formStat.Init(target);
            Application.Run(_formStat);
        }

        public static void ShowInv(Entity target)
        {
            _formInv.Init(target);
            Application.Run(_formInv);
        }
    }
}
