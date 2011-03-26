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
            textTemp.Text = trackBar_main.Value.ToString() + ",0";
            allChangeTrackBar(trackBar_main.Value);
            gateway.allHeaterAdjustTemperature(trackBar_main.Value);
            //SimulatorGUI
            simulator.fillDataGridViewHeaters();
            
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
                allChangeTrackBar(defaultTemp);
                allChangeTextTemp(defaultTemp.ToString() + ",0");
                allChangeSwitch(true);
                trackBar_main.Visible = true;
                labTemp.Visible = true;
                textTemp.Visible = true;
                textTemp.Text = defaultTemp.ToString()+",0";               
                trackBar_main.Value = defaultTemp;
            }// if
            else
            {
                buttonSwitch.Text = "OFF";
                buttonSwitch.BackColor = System.Drawing.Color.Red;
                gateway.allSwitchOffHeaters();
                allChangeSwitch(false);
                trackBar_main.Visible = false;
                labTemp.Visible = false;
                textTemp.Visible = false;
                
            }// else
            //SimulatorGUI
            simulator.fillDataGridViewHeaters();
            
        }// buttonSwitch_Click

        private void textTemp_KeyDown(Object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            { //Enter Key
                try
                {
                    double temp = Convert.ToDouble(textTemp.Text);
                    gateway.allHeaterAdjustTemperature(temp);
                    int roundTemp = Convert.ToInt32(temp);
                    trackBar_main.Value = roundTemp;
                    allChangeTrackBar(roundTemp);
                    allChangeTextTemp(textTemp.Text);
                    //SimulatorGUI
                    simulator.fillDataGridViewHeaters();
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
                dictionaryButtonSwitchByRoom[id_heater].Text = "ON";
                dictionaryButtonSwitchByRoom[id_heater].BackColor = System.Drawing.Color.Green;
                gateway.heaterAdjustTemparature(id_heater, 20.0); //Default temperature=20.0
                dictionaryTrackBarByRoom[id_heater].Value = 20;
                dictionaryTextTempByRoom[id_heater].Text = "20,0";
                dictionaryTrackBarByRoom[id_heater].Visible = true;
                dictionaryLabelByRoom[id_heater].Visible = true;
                dictionaryTextTempByRoom[id_heater].Visible = true;                
            }//if
            else
            {
                dictionaryButtonSwitchByRoom[id_heater].Text = "OFF";
                gateway.findHeater(id_heater).switchOff();
                dictionaryButtonSwitchByRoom[id_heater].BackColor = System.Drawing.Color.Red;
                dictionaryTrackBarByRoom[id_heater].Visible = false;
                dictionaryLabelByRoom[id_heater].Visible = false;
                dictionaryTextTempByRoom[id_heater].Visible = false;               
            }//else
            //SimulatorGUI
            simulator.fillDataGridViewHeaters();

        }//buttonSwitchByRoom_Click

        private void trackbarByRoom_Scroll(object sender, EventArgs e)
        {
            int id_heater = inverseDictionaryTrackBar[(TrackBar)sender];
            gateway.heaterAdjustTemparature(id_heater, dictionaryTrackBarByRoom[id_heater].Value);
            dictionaryTextTempByRoom[id_heater].Text = dictionaryTrackBarByRoom[id_heater].Value.ToString() + ",0";
            //SimulatorGUI
            simulator.fillDataGridViewHeaters();
        }// trackbarByRoom_Scroll

        private void textTempByRoom_KeyDown(Object sender, KeyEventArgs e)
        {
            int id_heater = inverseDictionaryTextTemp[(TextBox)sender];
            if (e.KeyValue == 13) //Enter Key
            { 
                try
                {
                    double temp = Convert.ToDouble(dictionaryTextTempByRoom[id_heater].Text);
                    gateway.heaterAdjustTemparature(id_heater,temp);
                    int roundTemp = Convert.ToInt32(temp);
                    dictionaryTrackBarByRoom[id_heater].Value = roundTemp;
                    //SimulatorGUI
                    simulator.fillDataGridViewHeaters();
                }// try
                catch (Exception exception)
                {
                    MessageBox.Show("Insert a correct temperature value(between 0 and 40 degrees)", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }// catch
            }//if            
        }//textTemp_KeyDown
      
    }// GatewayGUI
}//SmartHome
