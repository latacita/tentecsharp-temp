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
        private void buttonSwitch_Click_BlindSimulation(object sender, EventArgs e)
        {
            if (buttonBlindSimulation.Text.Equals("OFF"))
            {
                gateway.blindSimulation_switchOn();               
            }// if
            else
            {
                gateway.BlindSimulation_switchOff();
            }// else
        }// buttonSwitch_Click
    }
}

