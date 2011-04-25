using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartHome
{
    //============================================================================================================================//
    // This class represents the visual interface for the Gateway                                                                 //
    // This file only contains the funcionality related to the BlindSimulation feature                                            //
    //============================================================================================================================//

    partial class GatewayGUI : IGatewayGUIBlindSimulationObserver
    {
        //Visual components
        protected TabPage tabPage_BlindSimulation;
        protected Button buttonBlindSimulation;
        protected PictureBox pictBlindSimulation;

        /// <summary>
        /// Constructor to add the blindSimulation to GatewayGUI
        /// </summary>
        public void addBlindSimulation()
        {
            tabPage_BlindSimulation = new TabPage();
            tabPage_BlindSimulation.Text = "Blind simulation";
            tabPage_BlindSimulation.BorderStyle = BorderStyle.Fixed3D;
            tabControl_main.Controls.Add(tabPage_BlindSimulation);
            initBlindSimulation();
            gateway.registerObserverBlindSimulation(this);
        }//addSmartEnergyMng

        protected void initBlindSimulation()
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
            pictBlindSimulation.Image = System.Drawing.Image.FromFile("..\\..\\Images\\blindSimulation.jpg"); //Temporal
            pictBlindSimulation.Location = new System.Drawing.Point((width + 30) / 3, height / 3);
            pictBlindSimulation.Size = new System.Drawing.Size(100, 100);
            tabPage_BlindSimulation.Controls.Add(pictBlindSimulation);

        }//initBlindSimulation   

        /// <summary>
        /// Method to switch on the visual components
        /// </summary>
        public void switchOnBlindSimulation()
        {
            buttonBlindSimulation.Text = "ON";
            buttonBlindSimulation.BackColor = System.Drawing.Color.Green;
        }//switchOnSmartEnergy

        /// <summary>
        /// Method to switch off the visual components
        /// </summary>
        public void switchOffBlindSimulation()
        {
            buttonBlindSimulation.Text = "OFF";
            buttonBlindSimulation.BackColor = System.Drawing.Color.Red;
        }// switchOffBlindSimulation
    }// GatewayGUI
}// SmartHome
