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
        private void buttonSwitch_Click_ligthSimulation(object sender, EventArgs e)
        {
            if (buttonLigthSimulation.Text.Equals("OFF"))
            {
                gateway.ligthSimulation_switchOn();               
            }// if
            else
            {
                gateway.ligthSimulation_switchOff();
            }// else
        }// buttonSwitch_Click
    }
}

