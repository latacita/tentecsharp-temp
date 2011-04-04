using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartHome
{
    partial class GatewayGUI
    {
        private TabPage tabPage_smartEnergy;
        private Button buttonSmartEnergy;
        private PictureBox pictSmartEnergy;

        public void addSmartEnergy()
        {
            tabPage_smartEnergy = new TabPage();
            tabPage_smartEnergy.Text = "Smart energy";
            tabPage_smartEnergy.BorderStyle = BorderStyle.Fixed3D;
            tabControl_main.Controls.Add(tabPage_smartEnergy);
            initSmartEnergy();            
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

        }//initSmartEnergy     
    }
}
