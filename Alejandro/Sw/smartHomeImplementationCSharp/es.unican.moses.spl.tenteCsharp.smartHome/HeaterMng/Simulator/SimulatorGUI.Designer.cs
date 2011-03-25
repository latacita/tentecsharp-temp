using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartHome
{
    partial class SimulatorGUI
    {
        //Dictionary<index, id_heater>
        private Dictionary<int, int> dictionaryListHeater = new Dictionary<int, int>();
        private System.Windows.Forms.TextBox textBoxTemperature = new System.Windows.Forms.TextBox();
        private System.Windows.Forms.Label labelTemperature = new System.Windows.Forms.Label();
        private int currentIdHeater;

       
        public void addHeaterMng()
        {
            this.listBoxRooms.SelectedIndexChanged += new System.EventHandler(this.listBoxRooms_SelectedIndexChanged);
            this.listDevices.SelectedIndexChanged += new System.EventHandler(this.listBoxDevices_SelectedIndexChanged);            
        }// addHeaterMng

        //Add heaters to the ListBoxDevices 
        private void addHeaters(int id_room)
        {
            this.listDevices.Items.Clear();
            List<HeaterCtrl> h=gateway.findHeatersByRoom(id_room);
                       
            for (int i = 0; i < h.Count; i++)
            {
                dictionaryListHeater.Remove(i);          
                this.listDevices.Items.Add("Heater " + h[i].getId());
                dictionaryListHeater.Add(i, h[i].getId());
                
            }// for
        }// addHeaters

        //Add heater status to the richTextBoxStatus
        public void addStatusHeaters(int id_heater)
        {
            richTextBoxStatus.Clear();
            HeaterCtrl h=gateway.findHeater(id_heater);
            String status;
            String temperatureIndoor;
            String work;
            temperatureIndoor = "\nTemperature indoor: " + gateway.findThermometerByHeater(h.getId()).getValue()+"\n";
            if(h.getWork())  work = "Working: ON" ;
            else work = "Working: OFF";

            if(h.status()) status="Status: ON\n"+"Heater Degrees: "+h.getValue();
            else status = "Status: OFF"; 
          
            richTextBoxStatus.Text = status+temperatureIndoor+work;
        }// addStatursHeaters

        private void addLabelTemperature()
        {
            
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.Location = new System.Drawing.Point(5, 30);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(102, 13);
            this.labelTemperature.TabIndex = 10;
            this.labelTemperature.Text = "Temperature indoor:";
            this.richTextBoxSimulated.Controls.Add(this.labelTemperature);                      
        }// addLabelTemperature

        private void addTextBoxTemperature(int id_heater)
        {
            this.currentIdHeater = id_heater;
            this.textBoxTemperature.Location = new System.Drawing.Point(115, 25);
            this.textBoxTemperature.Name = "textBoxTemperature";
            this.textBoxTemperature.Size = new System.Drawing.Size(30, 20);
            this.textBoxTemperature.TabIndex = 9;
            this.richTextBoxSimulated.Controls.Add(this.textBoxTemperature);
            this.textBoxTemperature.KeyDown += new KeyEventHandler(textTemp_KeyDown);
        }// addTextBoxTemperature

        //Update the currented selected heater information
        public void updateCurrentSelected()
        {
            int index=listDevices.SelectedIndex;
            if (index != -1)
            {
                if(dictionaryListHeater.ContainsKey(index)) addStatusHeaters(currentIdHeater);
            }//if
            //return currentIdHeater;
        }// getCurrentIdHeater
    }
}
