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
    public partial class GatewayGUI: Form
    {
        //Method to control scroll trackbar event
        private void trackbar_Scroll(object sender, EventArgs e)
        {
            textTemp.Text = trackBar_main.Value.ToString() + ".0";
            gateway.allHeaterAdjustTemperature(trackBar_main.Value);
        }// trackbar_Scroll

        //Method to control click button event
        private void buttonSwitch_Click(object sender, EventArgs e)
        {
            if (buttonSwitch.Text.Equals("OFF"))
            {
                int defaultTemp = 20;
                buttonSwitch.Text = "ON";
                buttonSwitch.BackColor = System.Drawing.Color.Green;
                gateway.allHeaterAdjustTemperature(defaultTemp);
                trackBar_main.Visible = true;
                labTemp.Visible = true;
                textTemp.Visible = true;
                textTemp.Text = defaultTemp.ToString()+".0";
                trackBar_main.Value = defaultTemp;
            }// if
            else
            {
                buttonSwitch.Text = "OFF";
                buttonSwitch.BackColor = System.Drawing.Color.Red;
                gateway.allSwitchOffHeaters();
                trackBar_main.Visible = false;
                labTemp.Visible = false;
                textTemp.Visible = false;
                
            }// else
            
        }// buttonSwitch_Click
      
    }// GatewayGUI
}//SmartHome
