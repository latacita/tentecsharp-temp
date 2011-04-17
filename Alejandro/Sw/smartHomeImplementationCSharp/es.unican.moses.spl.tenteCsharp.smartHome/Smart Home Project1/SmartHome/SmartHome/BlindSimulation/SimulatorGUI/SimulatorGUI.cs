﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace SmartHome
{
    partial class SimulatorGUI
    {


        /// <summary>
        ///     Action handler for the Submmit Button related to timer management
        /// </summary>
        /// <param name="sender">Autogenerated</param>
        /// <param name="e">Autogenerated</param>
        private void buttonSubmit_blindSimulation_Click(object sender, EventArgs e)
        {
            try
            {
                int hours = Convert.ToInt32(comboBoxHours_blindSimulation.SelectedItem.ToString());
                int minutes = Convert.ToInt32(comboBoxMinutes_blindSimulation.SelectedItem.ToString());
                this.gateway.getTimer().setTime(hours, minutes);
                refreshTime();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Select hours and minutes", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }//buttonSubmit_Click
    }
}
