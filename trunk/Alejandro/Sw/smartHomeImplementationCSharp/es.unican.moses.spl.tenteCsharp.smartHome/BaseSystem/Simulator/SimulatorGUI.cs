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
       

        private void cleanRichTextBoxSimulated()
        {
            for (int i = richTextBoxSimulated.Controls.Count; i>0; i--)
            {
                richTextBoxSimulated.Controls.RemoveAt(i-1);
            }// for
        }// cleanRichTextBoxSimulated
    }
}
