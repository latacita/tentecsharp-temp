using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
    partial class SimulatorGUI
    {
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            Console.WriteLine(comboBoxHours.SelectedItem.ToString());
            comboBoxMinutes.SelectedItem.ToString();
            String time = comboBoxHours.SelectedItem.ToString() + "," + comboBoxMinutes.SelectedItem.ToString();
            gateway.smartEnergy_adjustTime(Convert.ToDouble(time));
            refreshTime();
        }//buttonSubmit_Click
    }
}
