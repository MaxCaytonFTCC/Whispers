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
    public partial class StatForm : Form
    {
        public StatForm()
        {
            InitializeComponent();
        }

        public void SetUp(Entity target)
        {
            // Start up form
            nameDisplayLBL.Text = target.Name;
            
            // Fill stat list
            statDisplayLB.Items.Clear();   // Clear current stats
            statDisplayLB.Items.Add($"Race:\t{target.Race}");
            statDisplayLB.Items.Add($"HP:\t{target.HP}");
            statDisplayLB.Items.Add($"AC:\t{target.AC}");
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            // Close form
            Close();
        }
    }
}
