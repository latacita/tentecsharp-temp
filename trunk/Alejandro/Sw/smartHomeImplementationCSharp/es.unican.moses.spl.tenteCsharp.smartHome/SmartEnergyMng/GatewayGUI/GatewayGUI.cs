using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
    partial class GatewayGUI
    {
        private void buttonSwitch_Click_smartEnergy(object sender, EventArgs e)
        {
            if (buttonSmartEnergy.Text.Equals("OFF"))
            {
                buttonSmartEnergy.Text = "ON";
                buttonSmartEnergy.BackColor = System.Drawing.Color.Green;                
                gateway.smartEnergy_switchOnSmartEnergyMng(simulator.currentTime());
                
                
            }// if
            else
            {
                buttonSmartEnergy.Text = "OFF";
                buttonSmartEnergy.BackColor = System.Drawing.Color.Red;
                gateway.smartEnergy_switchOffSmartEnergyMng();

            }// else
            //SimulatorGUI
            refreshSimulator();

        }// buttonSwitch_Click
    }
}
