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
        private const int TVWATCHING = 35;
        private const int READING = 100;
        private const int NORMAL = 70;
        private const int AMBIENT = 50;

        //Method to control scroll trackbar event
        private void trackbar_Scroll_ligthing(object sender, EventArgs e)
        {
            gateway.ligthMng_allAdjustligths(trackBar_ligthing.Value);
            combo_predefinedValues.SelectedIndex = 0;
        }// trackbar_Scroll_ligthing

        private void textLigthing_KeyDown(Object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            { //Enter Key
                try
                {
                    int lighting = Convert.ToInt32(text_ligthing.Text);
                    gateway.ligthMng_allAdjustligths(lighting);
                    combo_predefinedValues.SelectedIndex = 0;
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Insert a correct ligthing value(integer between 0 and 100)", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }// catch
            }//if            
        }//textligthing_KeyDown

  

        private void combo_predefinedValues_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (combo_predefinedValues.SelectedIndex)
            {
                case 1:
                    gateway.ligthMng_allAdjustligths(TVWATCHING);
                    break;
                case 2:
                    gateway.ligthMng_allAdjustligths(READING);
                    break;
                case 3:
                    gateway.ligthMng_allAdjustligths(NORMAL);
                    break;
                case 4:
                    gateway.ligthMng_allAdjustligths(AMBIENT);
                    break;
            }//switch

        }// combo_predefinedValues_SelectedIndexChanged

        private void textLigthingByRoom_KeyDown(Object sender, KeyEventArgs e)
        {
            int id_ligth = inverseDictionaryTextLigthing[(TextBox)sender];
            if (e.KeyValue == 13) //Enter Key
            {
                try
                {
                    int ligthing = Convert.ToInt32(dictionaryTextLigthingByRoom[id_ligth].Text);
                    gateway.ligthMng_adjustLigth(id_ligth, ligthing);
                    dictionaryComboBoxPredefinedValues[id_ligth].SelectedIndex = 0;
                }// try
                catch (Exception exception)
                {
                    MessageBox.Show("Insert a correct ligthing value(integer between 0 and 100)", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }// catch
            }//if            
        }//textLigthingByRoom_KeyDown

        private void trackbarLigthingByRoom_Scroll(object sender, EventArgs e)
        {
            int id_ligth = inverseDictionaryTrackBarLigthing[(TrackBar)sender];
            gateway.ligthMng_adjustLigth(id_ligth, dictionaryTrackBarLigthingByRoom[id_ligth].Value);
            dictionaryComboBoxPredefinedValues[id_ligth].SelectedIndex = 0;
        }// trackbarLigthingByRoom_Scroll

        private void combo_predefinedValues_SelectedIndexChangedByRoom(object sender, EventArgs e)
        {
            int id_ligth = inverseDictComboBoxPredefinedValues[(ComboBox)sender];
            switch (dictionaryComboBoxPredefinedValues[id_ligth].SelectedIndex)
            {
                case 1:
                    gateway.ligthMng_adjustLigth(id_ligth, TVWATCHING);
                    break;
                case 2:
                    gateway.ligthMng_adjustLigth(id_ligth, READING);
                    break;
                case 3:
                    gateway.ligthMng_adjustLigth(id_ligth, NORMAL);
                    break;
                case 4:
                    gateway.ligthMng_adjustLigth(id_ligth, AMBIENT);
                    break;
            }//switch
        }//combo_predefinedValues_SelectedIndexChangedByRoom

    
    }
}
