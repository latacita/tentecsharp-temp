using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartHome
{
    partial class SimulatorGUI

    {
        private void textTemp_KeyDown(Object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13) //Enter Key
            {
                try
                {
                    double temp = Convert.ToDouble(textBoxTemperature.Text);
                    gateway.changeThermometer(currentIdHeater, temp);
                    addStatusHeaters(currentIdHeater);                                       
                }// try
                catch (Exception exception)
                {
                    MessageBox.Show("Insert a correct temperature value(between 0 and 40 degrees)", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }// catch
            }//if            
        }//textTemp_KeyDown
    }//SimulatroGUI
}//SmartHome
