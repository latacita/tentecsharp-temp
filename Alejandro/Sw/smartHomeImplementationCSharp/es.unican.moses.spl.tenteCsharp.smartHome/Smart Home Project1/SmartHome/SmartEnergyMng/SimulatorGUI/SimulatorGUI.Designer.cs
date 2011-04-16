using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartHome
{
    partial class SimulatorGUI
    {
        private TabPage tabPageSmartEnergy = new TabPage();
        private ComboBox comboBoxHours = new ComboBox();
        private ComboBox comboBoxMinutes = new ComboBox();
        private Label labelHours = new Label();
        private Label labelMinutes = new Label();
        private Button buttonSubmit = new Button();
        private Label labelTextCurrentTime = new Label();
        private Label labelCurrentTime = new Label();
        private Label labelTextEmpty = new Label();
        private ListBox listEmpty = new ListBox();
        //private Time timer;

        public void addSmartEnergyMng()
        {
            //this.timer = time;
            initTabPageSmartEnergy();
        }//addSmartEnergyMng


        public void initTabPageSmartEnergy()
        {
            //
            // tabPageSmartEnergy
            //

            this.tabPageSmartEnergy.Text = "SmartEnergy";
            this.tabPageSmartEnergy.Location = new System.Drawing.Point(4, 22);
            this.tabPageSmartEnergy.Size = new System.Drawing.Size(663, 313);

            //
            //LabelHours
            //
            this.labelHours.Text = "Hours:";
            this.labelHours.Location = new System.Drawing.Point(200, 152);
            //
            //comboBoxHours
            //
            this.comboBoxHours.Location = new System.Drawing.Point(250, 150);
            this.comboBoxHours.Size = new System.Drawing.Size(60, 20);
            for (int i = 0; i < 24; i++)
            {
                if (i < 10) this.comboBoxHours.Items.Add("0" + i.ToString());
                else this.comboBoxHours.Items.Add(i.ToString());

            }
            //
            //LabelMinutes
            //
            this.labelMinutes.Text = "Minutes:";
            this.labelMinutes.Location = new System.Drawing.Point(340, 152);
            //
            //LabelTextEmpty
            //
            this.labelTextEmpty.Text = "Empty house:";
            this.labelTextEmpty.Size = new System.Drawing.Size(80, 20);
            this.labelTextEmpty.Location = new System.Drawing.Point(240, 20);
            //
            //ListBoxEmpty
            //
            this.listEmpty.Location = new System.Drawing.Point(320, 20);
            this.listEmpty.Size = new System.Drawing.Size(100, 80);
            List<Double> empty = gateway.smartEnergy_getEmptyTime();
            for (int i = 0; i < empty.Count; i = i + 2)
            {
                String time1 = empty[i].ToString();
                String time2 = empty[i + 1].ToString();
                if (time1.Contains(","))
                {
                    time1 = time1.Replace(",", ":");
                    if (time1.Length == 4 || time1.Length == 3)
                        time1 = time1 + "0";
                }
                else
                    time1 = time1 + ":" + "00";
                if (time2.Contains(","))
                {
                    time2 = time2.Replace(",", ":");
                    if (time2.Length == 4 || time1.Length == 3)
                        time2 = time2 + "0";

                }
                else
                    time2 = time2 + ":" + "00";
                this.listEmpty.Items.Add(time1 + "-" + time2);
            }

            //
            //comboBoxMinutes
            //
            this.comboBoxMinutes.Location = new System.Drawing.Point(400, 150);
            this.comboBoxMinutes.Size = new System.Drawing.Size(60, 20);
            for (int i = 0; i < 60; i++)
            {
                if (i < 10) this.comboBoxMinutes.Items.Add("0" + i.ToString());
                else this.comboBoxMinutes.Items.Add(i.ToString());
            }
            //
            //LabelTextCurrentTime
            //
            this.labelTextCurrentTime.Text = "Current time: ";
            this.labelTextCurrentTime.Location = new System.Drawing.Point(275, 120);
            this.labelTextCurrentTime.Size = new System.Drawing.Size(70, 20);
            //
            //LabelCurrentTime
            //
            this.labelCurrentTime.Location = new System.Drawing.Point(350, 120);
            this.labelCurrentTime.Size = new System.Drawing.Size(80, 20);
            this.labelCurrentTime.Text = gateway.getTimer().getTime().ToString().Replace(",", ":");
            //
            //Button
            //
            this.buttonSubmit.Location = new System.Drawing.Point(300, 200);
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);

            this.tabControl.Controls.Add(tabPageSmartEnergy);


            this.tabPageSmartEnergy.Controls.Add(comboBoxHours);
            this.tabPageSmartEnergy.Controls.Add(comboBoxMinutes);
            this.tabPageSmartEnergy.Controls.Add(labelHours);
            this.tabPageSmartEnergy.Controls.Add(labelMinutes);
            this.tabPageSmartEnergy.Controls.Add(buttonSubmit);
            this.tabPageSmartEnergy.Controls.Add(labelTextCurrentTime);
            this.tabPageSmartEnergy.Controls.Add(labelCurrentTime);
            this.tabPageSmartEnergy.Controls.Add(labelTextEmpty);
            this.tabPageSmartEnergy.Controls.Add(listEmpty);
        }//initTabPageSmartEnergy

        public void smartEnergy_refreshTime()
        {
            this.labelCurrentTime.Text = gateway.getTimer().getTime();
        }//smartEnergy_refreshTime


    }
}
