using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartHome
{
    partial class SimulatorGUI
    {
        private TabPage tabPageBlindSimulation = new TabPage();
        private ComboBox comboBoxHours_blindSimulation = new ComboBox();
        private ComboBox comboBoxMinutes_blindSimulation = new ComboBox();
        private Label labelHours_BlindSimulation = new Label();
        private Label labelMinutes_BlindSimulation = new Label();
        private Button buttonSubmit_BlindSimulation = new Button();
        private Label labelTextCurrentTime_BlindSimulation = new Label();
        private Label labelCurrentTime_BlindSimulation = new Label();


        public void addBlindSimulation()
        {
            //this.timer = time;
            initTabPageBlindSimulation();
        }//addBlindSimulation


        public void initTabPageBlindSimulation()
        {
            //
            // tabPageBlindSimulation
            //

            this.tabPageBlindSimulation.Text = "BlindSimulation";
            this.tabPageBlindSimulation.Location = new System.Drawing.Point(4, 22);
            this.tabPageBlindSimulation.Size = new System.Drawing.Size(663, 313);

            //
            //labelHours_BlindSimulation
            //
            this.labelHours_BlindSimulation.Text = "Hours:";
            this.labelHours_BlindSimulation.Location = new System.Drawing.Point(200, 152);
            //
            //comboBoxHours
            //
            this.comboBoxHours_blindSimulation.Location = new System.Drawing.Point(250, 150);
            this.comboBoxHours_blindSimulation.Size = new System.Drawing.Size(60, 20);
            for (int i = 0; i < 24; i++)
            {
                if (i < 10) this.comboBoxHours_blindSimulation.Items.Add("0" + i.ToString());
                else this.comboBoxHours_blindSimulation.Items.Add(i.ToString());

            }
            //
            //labelMinutes_BlindSimulation
            //
            this.labelMinutes_BlindSimulation.Text = "Minutes:";
            this.labelMinutes_BlindSimulation.Location = new System.Drawing.Point(340, 152);
            //
            //LabelTextEmpty
            //
            this.labelTextEmpty.Text = "Empty house:";
            this.labelTextEmpty.Size = new System.Drawing.Size(80, 20);
            this.labelTextEmpty.Location = new System.Drawing.Point(240, 20);
            //
            //comboBoxMinutes
            //
            this.comboBoxMinutes_blindSimulation.Location = new System.Drawing.Point(400, 150);
            this.comboBoxMinutes_blindSimulation.Size = new System.Drawing.Size(60, 20);
            for (int i = 0; i < 60; i++)
            {
                if (i < 10) this.comboBoxMinutes_blindSimulation.Items.Add("0" + i.ToString());
                else this.comboBoxMinutes_blindSimulation.Items.Add(i.ToString());
            }
            //
            //labelTextCurrentTime_BlindSimulation
            //
            this.labelTextCurrentTime_BlindSimulation.Text = "Current time: ";
            this.labelTextCurrentTime_BlindSimulation.Location = new System.Drawing.Point(275, 120);
            this.labelTextCurrentTime_BlindSimulation.Size = new System.Drawing.Size(70, 20);
            //
            //labelCurrentTime_BlindSimulation
            //
            this.labelCurrentTime_BlindSimulation.Location = new System.Drawing.Point(350, 120);
            this.labelCurrentTime_BlindSimulation.Size = new System.Drawing.Size(80, 20);
            this.labelCurrentTime_BlindSimulation.Text = gateway.getTimer().getTime().ToString().Replace(",", ":");
            //
            //Button
            //
            this.buttonSubmit_BlindSimulation.Location = new System.Drawing.Point(300, 200);
            this.buttonSubmit_BlindSimulation.Text = "Submit";
            this.buttonSubmit_BlindSimulation.Click += new System.EventHandler(this.buttonSubmit_blindSimulation_Click);

            this.tabControl.Controls.Add(tabPageBlindSimulation);


            this.tabPageBlindSimulation.Controls.Add(comboBoxHours_blindSimulation);
            this.tabPageBlindSimulation.Controls.Add(comboBoxMinutes_blindSimulation);
            this.tabPageBlindSimulation.Controls.Add(labelHours_BlindSimulation);
            this.tabPageBlindSimulation.Controls.Add(labelMinutes_BlindSimulation);
            this.tabPageBlindSimulation.Controls.Add(buttonSubmit_BlindSimulation);
            this.tabPageBlindSimulation.Controls.Add(labelTextCurrentTime_BlindSimulation);
            this.tabPageBlindSimulation.Controls.Add(labelCurrentTime_BlindSimulation);
        }//initTabPageBlindSimulation

        public void blindSimulation_refreshTime()
        {
            this.labelCurrentTime_BlindSimulation.Text = gateway.getTimer().getTime();
        }//blindSimulation_refreshTime      
    }
}
