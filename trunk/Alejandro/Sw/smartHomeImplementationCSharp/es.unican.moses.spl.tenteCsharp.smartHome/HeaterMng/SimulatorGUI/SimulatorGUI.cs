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
                    int id_heater = int.Parse(dataGridViewHeaters.Rows[dataGridViewHeaters.SelectedRows[0].Index].Cells[0].Value.ToString());
                    double temp = Convert.ToDouble(textBoxTemperature.Text);
                    gateway.changeThermometer(id_heater, temp);
                    fillDataGridViewHeaters();
                    textBoxTemperature.Clear();
                }// try
                catch (Exception exception)
                {
                    MessageBox.Show("Insert a correct temperature value(between 0 and 40 degrees)", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }// catch
            }//if            
        }//textTemp_KeyDown
    }
}
