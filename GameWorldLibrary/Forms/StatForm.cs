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

        public void Init(Entity target)
        {
            // Start up form
            nameLBL.Text = target.Name;

            // Fill stat list
            statLB.Items.Clear();   // Clear current stats
            statLB.Items.Add($"Race:\t{target.Race}");
            statLB.Items.Add($"HP:\t{target.HP}");
            statLB.Items.Add($"AC:\t{target.AC}");
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            // Close form
            Close();
        }
    }
}
