using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SmartHome
{
    partial class GatewayGUI
    {
        private TabPage tabPage_heaters;
        private TrackBar trackBar_main;
        private Button buttonSwitch;
        private Label labTemp;
        private TextBox textTemp;
        private PictureBox pictureTherm;        
       

        public void addHeaterMng()
        {
            List<HeaterCtrl> heaters = gateway.getHeaters();
            tabPage_heaters = new TabPage();
            tabPage_heaters.Text = "Heaters";
            tabPage_heaters.BorderStyle = BorderStyle.Fixed3D;
            tabControl_main.Controls.Add(tabPage_heaters);
            addTrackBar();
            addButton();
            addLabelTemp();
            addTextTemp();
            addThermometer();

        }// addHeaterMng

        private void addButton()
        {
            buttonSwitch = new Button();
            buttonSwitch.Text = "OFF";
            buttonSwitch.BackColor = System.Drawing.Color.Red;
            tabPage_heaters.Controls.Add(buttonSwitch);
            buttonSwitch.Location = new System.Drawing.Point(width/2, height/6);
            buttonSwitch.Click += new System.EventHandler(this.buttonSwitch_Click);
        }//addButton      

        private void addTrackBar()
        {
            trackBar_main = new TrackBar();
            trackBar_main.Location= new System.Drawing.Point(width/3, height/2);
            trackBar_main.Size = new System.Drawing.Size(width/3, height/16);
            trackBar_main.Maximum = 40;
            trackBar_main.Minimum = 0;
            tabPage_heaters.Controls.Add(trackBar_main);
            trackBar_main.Visible = false;
            trackBar_main.Scroll += new System.EventHandler(this.trackbar_Scroll);            
        }//addTrackBar

        private void addLabelTemp()
        {
            labTemp = new Label();
            labTemp.Size = new System.Drawing.Size(180, 20);
            labTemp.Text = "Select temperature (Celsius): ";
            labTemp.Location = new System.Drawing.Point((width-30)/3, (height+80)/3);
            tabPage_heaters.Controls.Add(labTemp);
            labTemp.Visible = false;
        }//addLabelTemp

        private void addTextTemp()
        {
            textTemp = new TextBox();
            textTemp.Text = "20.0";
            textTemp.Size = new System.Drawing.Size(30, 20);
            textTemp.Location = new System.Drawing.Point(width/4, height/2);
            textTemp.Enabled = false;
            tabPage_heaters.Controls.Add(textTemp);
            textTemp.Visible = false;

        }//addTextTemp

        private void addThermometer()
        {
            pictureTherm = new PictureBox();
            pictureTherm.Image = System.Drawing.Image.FromFile(".\\ImagesDebug\\thermometer.jpg"); //TEMPORAL
            pictureTherm.Location = new System.Drawing.Point(width/8, height/16);
            pictureTherm.Size = new System.Drawing.Size(75, 84);
            tabPage_heaters.Controls.Add(pictureTherm);
        }
    }
}
