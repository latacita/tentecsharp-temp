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
            gateway.heaterMng_allHeaterAdjustTemperature(trackBar_main.Value);           
        }// trackbar_Scroll

        //Method to control click button event
        private void buttonSwitch_Click(object sender, EventArgs e)
        {
            if (buttonSwitch.Text.Equals("OFF"))
            {
                gateway.heaterMng_allSwitchOnHeaters(20);               
            }// if
            else
            {
                gateway.heaterMng_allSwitchOffHeaters();               
            }// else          
        }// buttonSwitch_Click

        private void textTemp_KeyDown(Object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            { //Enter Key
                try
                {
                    double temp = Convert.ToDouble(textTemp.Text);
                    gateway.heaterMng_allHeaterAdjustTemperature(temp);                                   
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Insert a correct temperature value(between 0 and 40 degrees)", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                    
                }// catch
            }//if            
        }//textTemp_KeyDown

       

        private void buttonSwitchByRoom_Click(object sender, EventArgs e)
        {
            int id_heater = inverseDictionaryButton[(Button)sender];
            if (dictionaryButtonSwitchByRoom[id_heater].Text.Equals("OFF"))
            {
                gateway.heaterMng_switchOnHeater(id_heater);                              
            }//if
            else
            {                
                gateway.heaterMng_switchOffHeater(id_heater);
                           
            }//else
        }//buttonSwitchByRoom_Click

    

        private void trackbarByRoom_Scroll(object sender, EventArgs e)
        {
            int id_heater = inverseDictionaryTrackBar[(TrackBar)sender];
            gateway.heaterAdjustTemperature(id_heater, dictionaryTrackBarByRoom[id_heater].Value);            
        }// trackbarByRoom_Scroll

        private void textTempByRoom_KeyDown(Object sender, KeyEventArgs e)
        {
            int id_heater = inverseDictionaryTextTemp[(TextBox)sender];
            if (e.KeyValue == 13) //Enter Key
            { 
                try
                {
                    double temp = Convert.ToDouble(dictionaryTextTempByRoom[id_heater].Text);
                    gateway.heaterAdjustTemperature(id_heater,temp);                                     
                }// try
                catch (Exception exception)
                {
                    MessageBox.Show("Insert a correct temperature value(between 0 and 40 degrees)", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }// catch
            }//if            
        }//textTemp_KeyDown
      
    }// GatewayGUI
}//SmartHome
