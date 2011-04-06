using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartHome
{
    partial class GatewayGUI:IGatewayGUISmartEnergyObserver
    {
        private TabPage tabPage_smartEnergy;
        private Button buttonSmartEnergy;
        private PictureBox pictSmartEnergy;
        private Label labelDesiredTemp;
        private TextBox textBoxDesiredTemp;
        private Button buttonSubmitDesiredTemp;

        public void addSmartEnergy()
        {
            tabPage_smartEnergy = new TabPage();
            tabPage_smartEnergy.Text = "Smart energy";
            tabPage_smartEnergy.BorderStyle = BorderStyle.Fixed3D;
            tabControl_main.Controls.Add(tabPage_smartEnergy);
            initSmartEnergy();
            gateway.registerObserverSmartEnergy(this);
        }//addSmartEnergy

        private void initSmartEnergy()
        {
            //
            //Button
            //
            buttonSmartEnergy = new Button();
            buttonSmartEnergy.Text = "OFF";
            buttonSmartEnergy.BackColor = System.Drawing.Color.Red;
            tabPage_smartEnergy.Controls.Add(buttonSmartEnergy);
            buttonSmartEnergy.Location = new System.Drawing.Point((width / 2)-40, height / 6);
            buttonSmartEnergy.Click += new System.EventHandler(this.buttonSwitch_Click_smartEnergy);
            //
            //Image
            //
            pictSmartEnergy = new PictureBox();
            pictSmartEnergy.Image = System.Drawing.Image.FromFile("..\\..\\Images\\smartEnergy.jpg"); //TEMPORAL
            pictSmartEnergy.Location = new System.Drawing.Point((width + 84) / 3, height / 3);
            pictSmartEnergy.Size = new System.Drawing.Size(100, 94);
            tabPage_smartEnergy.Controls.Add(pictSmartEnergy);
            //
            //Label
            //
            labelDesiredTemp = new Label();
            labelDesiredTemp.Location = new System.Drawing.Point((width-70) / 3, (height+100)/2);
            labelDesiredTemp.Text = "Desired temperature: "+gateway.heaterMng_getDesiredTemperature().ToString()+" degrees";
            labelDesiredTemp.Size = new System.Drawing.Size(200, 20);
            labelDesiredTemp.Visible = false;
            tabPage_smartEnergy.Controls.Add(labelDesiredTemp);
            //
            //TextBox
            //
            textBoxDesiredTemp = new TextBox();
            textBoxDesiredTemp.Location = new System.Drawing.Point((width) / 3, (height + 150) / 2);
            textBoxDesiredTemp.Text = "20,0";
            textBoxDesiredTemp.Size = new System.Drawing.Size(30, 30);
            textBoxDesiredTemp.Visible = false;
            tabPage_smartEnergy.Controls.Add(textBoxDesiredTemp);
            //
            //Button
            //
            buttonSubmitDesiredTemp = new Button();
            buttonSubmitDesiredTemp.Location = new System.Drawing.Point((width+120) / 3, (height + 145) / 2);
            buttonSubmitDesiredTemp.Text = "Submit";
            buttonSubmitDesiredTemp.Visible = false;
            tabPage_smartEnergy.Controls.Add(buttonSubmitDesiredTemp);
            buttonSubmitDesiredTemp.Click += new System.EventHandler(this.buttonSubmit_Click_smartEnergy);
        }//initSmartEnergy   

        public void switchOnSmartEnergy()
        {
            buttonSmartEnergy.Text = "ON";
            buttonSmartEnergy.BackColor = System.Drawing.Color.Green;
            textBoxDesiredTemp.Visible = true;
            labelDesiredTemp.Visible = true;
            buttonSubmitDesiredTemp.Visible = true;
        }//switchOnSmartEnergy

        public void switchOffSmartEnergy()
        {
            buttonSmartEnergy.Text = "OFF";
            buttonSmartEnergy.BackColor = System.Drawing.Color.Red;
            textBoxDesiredTemp.Visible = false;
            labelDesiredTemp.Visible = false;
            buttonSubmitDesiredTemp.Visible = false;
        }//switchOnSmartEnergy
    }
}
