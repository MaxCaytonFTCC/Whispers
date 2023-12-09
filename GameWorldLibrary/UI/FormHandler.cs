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
        public static void ShowStats(Entity target)
        {
            StatForm form = new StatForm();
            form.SetUp(target);
            Application.Run(form);
        }

        public static void ShowInv(Entity target)
        {
            InvForm form = new InvForm();
            form.SetUp(target);
            Application.Run(form);
        }
    }
}
