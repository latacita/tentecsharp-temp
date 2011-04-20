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
        /// <summary>
        /// Empty constructor for SimulatorGUI
        /// </summary>
        public SimulatorGUI()
        {
            InitializeComponent();
        } //SimulatorGUI

        /// <summary>
        /// Handler to control the exit botton in the SimulatorGUI
        /// </summary>
        /// <param name="e">FormClosingEventArgs</param>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            DialogResult rs2 = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs2 == DialogResult.Yes)
            {
                System.Environment.Exit(1);
            }// if
            else
            {
                e.Cancel = true;
            }// else
        }// OnFormClosign
    }// SimulatorGUI
}// SmartHome
