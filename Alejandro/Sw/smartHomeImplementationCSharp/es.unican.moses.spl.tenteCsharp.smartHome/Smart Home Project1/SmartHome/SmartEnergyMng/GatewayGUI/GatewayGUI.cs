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
    partial class GatewayGUI
    {
        private void buttonSwitch_Click_smartEnergy(object sender, EventArgs e)
        {
            if (buttonSmartEnergy.Text.Equals("OFF"))
            {
                gateway.smartEnergy_switchOnSmartEnergyMng(gateway.getTimer().getHour(), gateway.getTimer().getMinutes());
            }// if
            else
            {
                gateway.smartEnergy_switchOffSmartEnergyMng();
            }// else
        }// buttonSwitch_Click

        private void buttonSubmit_Click_smartEnergy(object sender, EventArgs e)
        {
            try
            {
                double temp = Convert.ToDouble(textBoxDesiredTemp.Text);
                if (temp < 0 || temp > 40) throw new Exception();
                gateway.heaterMng_setDesiredTemperature(temp);
                labelDesiredTemp.Text = "Desired temperature: " + temp.ToString() + " degrees";
            }
            catch (Exception exception)
            {
                MessageBox.Show("Insert a correct temperature value(between 0 and 40 degrees)", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }//buttonSubmit_Click_smartEnergy




    }
}
