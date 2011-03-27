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
    public partial class GatewayGUI
    {
        //Method to control scroll trackbar event
        private void trackbar_Scroll_aperture(object sender, EventArgs e)
        {
            text_aperture.Text = trackBar_aperture.Value.ToString();
            //allChangeTrackBar(trackBar_main.Value);
            gateway.allAdjustWindows(trackBar_aperture.Value);
            //gateway.allHeaterAdjustTemperature(trackBar_main.Value);
            //SimulatorGUI
            //simulator.fillDataGridViewHeaters();

        }// trackbar_Scroll_aperture

        private void textAperture_KeyDown(Object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            { //Enter Key
                try
                {
                    int aperture = Convert.ToInt32(text_aperture.Text);
                    gateway.allAdjustWindows(trackBar_aperture.Value);
                    trackBar_aperture.Value = aperture;
                    //allChangeTrackBar(roundTemp);
                    //allChangeTextTemp(textTemp.Text);
                    //SimulatorGUI
                    //simulator.fillDataGridViewHeaters();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Insert a correct aperture value(integer between 0 and 100 degrees)", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }// catch
            }//if            
        }//textTemp_KeyDown

        private void textApertureByRoom_KeyDown(Object sender, KeyEventArgs e)
        {
            int id_window = inverseDictionaryTextAperture[(TextBox)sender];
            if (e.KeyValue == 13) //Enter Key
            {
                try
                {
                    int aperture = Convert.ToInt32(dictionaryTextApertureByRoom[id_window].Text);
                    gateway.ajustWindow(id_window, aperture);
                    dictionaryTrackBarApertureByRoom[id_window].Value = aperture;
                    //SimulatorGUI
                    //simulator.fillDataGridViewHeaters();
                }// try
                catch (Exception exception)
                {
                    MessageBox.Show("Insert a correct aperture value(integer between 0 and 100 degrees)", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }// catch
            }//if            
        }//textTemp_KeyDown

        private void trackbarApertureByRoom_Scroll(object sender, EventArgs e)
        {
            int id_window = inverseDictionaryTrackBarAperture[(TrackBar)sender];
            gateway.ajustWindow(id_window, dictionaryTrackBarApertureByRoom[id_window].Value);
            dictionaryTextApertureByRoom[id_window].Text = dictionaryTrackBarApertureByRoom[id_window].Value.ToString();
            //SimulatorGUI
            //simulator.fillDataGridViewHeaters();
        }// trackbarByRoom_Scroll

    }
}
