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
        public SimulatorGUI()
        {
            InitializeComponent();
        }

        private void dataGridViewRooms_selectedRowsButton_Click(object sender, DataGridViewCellEventArgs e)
        {
            //int id_room=int.Parse(dataGridViewRooms.Rows[dataGridViewRooms.SelectedRows[0].Index].Cells[1].Value.ToString());
            //Console.WriteLine(id_room);
            //cleanRichTextBoxSimulated();
            //addSimulatedHeaterMng(id_room);
            
        }// dataGridViewRooms_selectedRowsButton_Click       
    }
}
