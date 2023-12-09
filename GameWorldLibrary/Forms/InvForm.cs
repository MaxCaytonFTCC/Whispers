using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameWorldLibrary.Forms
{
    public partial class InvForm : Form
    {
        public InvForm()
        {
            InitializeComponent();
        }

        public void SetUp(Entity target)
        {
            // Start up form
            nameDisplayLBL.Text = target.Name + "'s inventory"; // Change name label to target name

            // Fill inventory list
            foreach(Item item in target.Inventory)  // For every item in the inventory
            {
                // Show item name and type
                invDisplayLB.Items.Add($"{item.Name} [{item.Type.ToString().ToUpper()}]");
            }
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            // Close form
            Close();
        }
    }
}
