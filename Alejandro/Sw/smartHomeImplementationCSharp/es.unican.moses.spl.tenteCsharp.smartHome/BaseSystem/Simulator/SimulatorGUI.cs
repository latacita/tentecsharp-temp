using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartHome
{
    public partial class SimulatorGUI : Form
    {
        private Gateway gateway;
        public SimulatorGUI(Gateway gateway)
        {
            InitializeComponent();
             this.gateway = gateway;
        }// SimulatorGUI(Gateway)

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void listBoxFloors_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxRooms.Items.Clear();
            listDevices.Items.Clear();
            richTextBoxStatus.Clear();
            richTextBoxSimulated.Clear();
            cleanRichTextBoxSimulated();
            int index = listBoxFloors.SelectedIndex;
            int id_floor = dictionaryListFloors[index];
            Floor f = gateway.getFloorById(id_floor);
            addRooms(f);
        }
       

        private void listBoxRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            cleanRichTextBoxSimulated();
            richTextBoxStatus.Clear();
            int index = listBoxRooms.SelectedIndex;
            int id_room = dictionaryListRooms[index];
            addHeaters(id_room);
        }// listBoxRooms_SelectedIndexChanged

        private void listBoxDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            cleanRichTextBoxSimulated();
            richTextBoxStatus.Clear();
            int index = listDevices.SelectedIndex;
            int id_heater = dictionaryListHeater[index];
            addStatusHeaters(id_heater);
            addLabelTemperature();
            addTextBoxTemperature(id_heater);
        }// listBoxDevices_SelectedIndexChanged
    }
}
