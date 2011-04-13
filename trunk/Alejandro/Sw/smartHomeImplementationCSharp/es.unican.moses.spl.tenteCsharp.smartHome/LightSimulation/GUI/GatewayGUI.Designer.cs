using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartHome
{
    partial class GatewayGUI : IGatewayGUILightSimulationObserver
    {
        private TabPage tabPage_ligthSimulation;
        private Button buttonLigthSimulation;
        private PictureBox pictLigthSimulation;
        

        public void addLightSimulation()
        {
            tabPage_ligthSimulation = new TabPage();
            tabPage_ligthSimulation.Text = "Light simulation";
            tabPage_ligthSimulation.BorderStyle = BorderStyle.Fixed3D;
            tabControl_main.Controls.Add(tabPage_ligthSimulation);
            initLightSimulation();
            gateway.registerObserverLightSimulation(this);
        }//addSmartEnergyMng

        private void initLightSimulation()
        {
            //
            //Button
            //
            buttonLigthSimulation = new Button();
            buttonLigthSimulation.Text = "OFF";
            buttonLigthSimulation.BackColor = System.Drawing.Color.Red;
            tabPage_ligthSimulation.Controls.Add(buttonLigthSimulation);
            buttonLigthSimulation.Location = new System.Drawing.Point((width / 2) - 40, height / 6);
            buttonLigthSimulation.Click += new System.EventHandler(this.buttonSwitch_Click_ligthSimulation);
            //
            //Image
            //
            pictLigthSimulation = new PictureBox();
            pictLigthSimulation.Image = System.Drawing.Image.FromFile("..\\..\\Images\\lightSimulation.jpg"); //TEMPORAL
            pictLigthSimulation.Location = new System.Drawing.Point((width + 30) / 3, height / 3);
            pictLigthSimulation.Size = new System.Drawing.Size(100, 100);
            tabPage_ligthSimulation.Controls.Add(pictLigthSimulation);
           
        }//initLightSimulation   

        public void switchOnLightSimulation()
        {
            buttonLigthSimulation.Text = "ON";
            buttonLigthSimulation.BackColor = System.Drawing.Color.Green;            
        }//switchOnSmartEnergy

        public void switchOffLightSimulation()
        {
            buttonLigthSimulation.Text = "OFF";
            buttonLigthSimulation.BackColor = System.Drawing.Color.Red;            
        }//switchOnSmartEnergy*/
    }
}
