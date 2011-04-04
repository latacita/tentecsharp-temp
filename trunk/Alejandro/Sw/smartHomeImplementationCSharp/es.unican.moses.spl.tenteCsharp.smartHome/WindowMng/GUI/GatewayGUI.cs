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
            gateway.windowMng_allAdjustWindows(trackBar_aperture.Value);       

        }// trackbar_Scroll_aperture

        private void textAperture_KeyDown(Object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            { //Enter Key
                try
                {
                    int aperture = Convert.ToInt32(text_aperture.Text);
                    gateway.windowMng_allAdjustWindows(aperture);                                     
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Insert a correct aperture value(integer between 0 and 100 degrees)", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }// catch
            }//if            
        }//textAperture_KeyDown
        
        private void textApertureByRoom_KeyDown(Object sender, KeyEventArgs e)
        {
            int id_window = inverseDictionaryTextAperture[(TextBox)sender];
            if (e.KeyValue == 13) //Enter Key
            {
                try
                {
                    int aperture = Convert.ToInt32(dictionaryTextApertureByRoom[id_window].Text);
                    gateway.windowMng_adjustWindow(id_window, aperture);                                 
                }// try
                catch (Exception exception)
                {
                    MessageBox.Show("Insert a correct aperture value(integer between 0 and 100 degrees)", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }// catch
            }//if            
        }//textApertureByRoom_KeyDown

        private void trackbarApertureByRoom_Scroll(object sender, EventArgs e)
        {
            int id_window = inverseDictionaryTrackBarAperture[(TrackBar)sender];
            gateway.windowMng_adjustWindow(id_window, dictionaryTrackBarApertureByRoom[id_window].Value);                       
        }// trackbarApertureByRoom_Scroll

    }
}
