using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartHome
{
    public partial class SimulatorGUI : Form
    {
        public SimulatorGUI()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            DialogResult rs2 = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs2 == DialogResult.Yes)
            {
                //System.Windows.Forms.Application.Exit();
                System.Environment.Exit(1);
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
