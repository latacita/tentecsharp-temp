using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartHome
{
    partial class SimulatorGUI

    {
        private void listBoxRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            cleanRichTextBoxSimulated();
            richTextBoxStatus.Clear();
            int index = listBoxRooms.SelectedIndex;
            int id_room = dictionaryListRooms[index];
            addHeaters(id_room);
        }// listBoxRooms_SelectedIndexChanged

        private void listBoxDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            cleanRichTextBoxSimulated();
            richTextBoxStatus.Clear();
            int index = listDevices.SelectedIndex;
            int id_heater = dictionaryListHeater[index];
            addStatusHeaters(id_heater);
            addLabelTemperature();
            addTextBoxTemperature(id_heater);
        }// listBoxDevices_SelectedIndexChanged

        private void textTemp_KeyDown(Object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13) //Enter Key
            {
                try
                {
                    double temp = Convert.ToDouble(textBoxTemperature.Text);
                    gateway.changeThermometer(currentIdHeater, temp);
                    addStatusHeaters(currentIdHeater);
                    //gateway.heaterAdjustTemparature(currentIdHeater, temp);                    
                }// try
                catch (Exception exception)
                {
                    MessageBox.Show("Insert a correct temperature value(between 0 and 40 degrees)", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }// catch
            }//if            
        }//textTemp_KeyDown
    }//SimulatroGUI
}//SmartHome
