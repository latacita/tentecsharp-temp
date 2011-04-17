using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartHome
{
    partial class GatewayGUI : IGatewayGUIBlindSimulationObserver
    {
        private TabPage tabPage_BlindSimulation;
        private Button buttonBlindSimulation;
        private PictureBox pictBlindSimulation;


        public void addBlindSimulation()
        {
            tabPage_BlindSimulation = new TabPage();
            tabPage_BlindSimulation.Text = "Blind simulation";
            tabPage_BlindSimulation.BorderStyle = BorderStyle.Fixed3D;
            tabControl_main.Controls.Add(tabPage_BlindSimulation);
            initBlindSimulation();
            gateway.registerObserverBlindSimulation(this);
        }//addSmartEnergyMng

        private void initBlindSimulation()
        {
            //
            //Button
            //
            buttonBlindSimulation = new Button();
            buttonBlindSimulation.Text = "OFF";
            buttonBlindSimulation.BackColor = System.Drawing.Color.Red;
            tabPage_BlindSimulation.Controls.Add(buttonBlindSimulation);
            buttonBlindSimulation.Location = new System.Drawing.Point((width / 2) - 40, height / 6);
            buttonBlindSimulation.Click += new System.EventHandler(this.buttonSwitch_Click_BlindSimulation);
            //
            //Image
            //
            pictBlindSimulation = new PictureBox();
            pictBlindSimulation.Image = System.Drawing.Image.FromFile("..\\..\\Images\\blindSimulation.jpg"); //TEMPORAL
            pictBlindSimulation.Location = new System.Drawing.Point((width + 30) / 3, height / 3);
            pictBlindSimulation.Size = new System.Drawing.Size(100, 100);
            tabPage_BlindSimulation.Controls.Add(pictBlindSimulation);

        }//initBlindSimulation   

        public void switchOnBlindSimulation()
        {
            buttonBlindSimulation.Text = "ON";
            buttonBlindSimulation.BackColor = System.Drawing.Color.Green;
        }//switchOnSmartEnergy

        public void switchOffBlindSimulation()
        {
            buttonBlindSimulation.Text = "OFF";
            buttonBlindSimulation.BackColor = System.Drawing.Color.Red;
        }//switchOnSmartEnergy*/
    }
}
