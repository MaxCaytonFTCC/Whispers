using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameWorldLibrary
{
    public partial class RoomForm : Form
    {
        public RoomForm()
        {
            InitializeComponent();
        }
        public void SetUp(Room target)
        {
            // Start up form
            nameDisplayLBL.Text = target.Name;

            // Fill stat list
            itemDisplayLB.Items.Clear();    // Clear current items
            mobDisplayLB.Items.Clear();     // Clear current mobs
            playerDisplayLB.Items.Clear();  // Clear current players

            // Fill items list
            foreach(Item item in target.RoomItems)
            {
                // Show item name and type
                itemDisplayLB.Items.Add($"{item.Name} [{item.Type.ToString().ToUpper()}]");
            }

            // Fill mobs list
            foreach (Item item in target.RoomItems)
            {
                // Show item name and type
                itemDisplayLB.Items.Add($"{item.Name} [{item.Type.ToString().ToUpper()}]");
            }

            // Fill player list
            foreach (Item item in target.RoomItems)
            {
                // Show item name and type
                itemDisplayLB.Items.Add($"{item.Name} [{item.Type.ToString().ToUpper()}]");
            }
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            // Close form
            Close();
        }
    }
}
