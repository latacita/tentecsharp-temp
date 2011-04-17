using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartHome
{
    partial class SimulatorGUI
    {
        private TabPage tabPageLightSimulation = new TabPage();
        private ComboBox comboBoxHours_lightSimulation = new ComboBox();
        private ComboBox comboBoxMinutes_lightSimulation = new ComboBox();
        private Label labelHours_lightSimulation = new Label();
        private Label labelMinutes_lightSimulation = new Label();
        private Button buttonSubmit_lightSimulation = new Button();
        private Label labelTextCurrentTime_lightSimulation = new Label();
        private Label labelCurrentTime_lightSimulation = new Label();
       
        public void addLightSimulation()
        {
            //this.timer = time;
            initTabPageLightSimulation();
        }//addLightSimulation


        public void initTabPageLightSimulation()
        {
            //
            // tabPageLightSimulation
            //

            this.tabPageLightSimulation.Text = "LightSimulation";
            this.tabPageLightSimulation.Location = new System.Drawing.Point(4, 22);
            this.tabPageLightSimulation.Size = new System.Drawing.Size(663, 313);

            //
            //labelHours_lightSimulation
            //
            this.labelHours_lightSimulation.Text = "Hours:";
            this.labelHours_lightSimulation.Location = new System.Drawing.Point(200, 152);
            //
            //comboBoxHours
            //
            this.comboBoxHours_lightSimulation.Location = new System.Drawing.Point(250, 150);
            this.comboBoxHours_lightSimulation.Size = new System.Drawing.Size(60, 20);
            for (int i = 0; i < 24; i++)
            {
                if (i < 10) this.comboBoxHours_lightSimulation.Items.Add("0" + i.ToString());
                else this.comboBoxHours_lightSimulation.Items.Add(i.ToString());

            }
            //
            //labelMinutes_lightSimulation
            //
            this.labelMinutes_lightSimulation.Text = "Minutes:";
            this.labelMinutes_lightSimulation.Location = new System.Drawing.Point(340, 152);
            //
            //comboBoxMinutes
            //
            this.comboBoxMinutes_lightSimulation.Location = new System.Drawing.Point(400, 150);
            this.comboBoxMinutes_lightSimulation.Size = new System.Drawing.Size(60, 20);
            for (int i = 0; i < 60; i++)
            {
                if (i < 10) this.comboBoxMinutes_lightSimulation.Items.Add("0" + i.ToString());
                else this.comboBoxMinutes_lightSimulation.Items.Add(i.ToString());
            }
            //
            //labelTextCurrentTime_lightSimulation
            //
            this.labelTextCurrentTime_lightSimulation.Text = "Current time: ";
            this.labelTextCurrentTime_lightSimulation.Location = new System.Drawing.Point(275, 120);
            this.labelTextCurrentTime_lightSimulation.Size = new System.Drawing.Size(70, 20);
            //
            //labelCurrentTime_lightSimulation
            //
            this.labelCurrentTime_lightSimulation.Location = new System.Drawing.Point(350, 120);
            this.labelCurrentTime_lightSimulation.Size = new System.Drawing.Size(80, 20);
            this.labelCurrentTime_lightSimulation.Text = gateway.getTimer().getTime().ToString().Replace(",", ":");
            //
            //Button
            //
            this.buttonSubmit_lightSimulation.Location = new System.Drawing.Point(300, 200);
            this.buttonSubmit_lightSimulation.Text = "Submit";
            this.buttonSubmit_lightSimulation.Click += new System.EventHandler(this.buttonSubmit_lightSimulation_Click);

            this.tabControl.Controls.Add(tabPageLightSimulation);


            this.tabPageLightSimulation.Controls.Add(comboBoxHours_lightSimulation);
            this.tabPageLightSimulation.Controls.Add(comboBoxMinutes_lightSimulation);
            this.tabPageLightSimulation.Controls.Add(labelHours_lightSimulation);
            this.tabPageLightSimulation.Controls.Add(labelMinutes_lightSimulation);
            this.tabPageLightSimulation.Controls.Add(buttonSubmit_lightSimulation);
            this.tabPageLightSimulation.Controls.Add(labelTextCurrentTime_lightSimulation);
            this.tabPageLightSimulation.Controls.Add(labelCurrentTime_lightSimulation);
        }//initTabPageLightSimulation

        public void lightSimulation_refreshTime()
        {
            this.labelCurrentTime_lightSimulation.Text = gateway.getTimer().getTime();
        }//lightSimulation_refreshTime

        /* public double currentTime()
         {
             return gateway.getTimer().getTime();
         }//currentTime*/
    }
}
