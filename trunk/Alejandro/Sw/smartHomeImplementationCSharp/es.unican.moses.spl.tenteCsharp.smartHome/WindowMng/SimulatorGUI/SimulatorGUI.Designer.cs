using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartHome
{
    public partial class SimulatorGUI
    {
        private TabPage tabPageWindows = new TabPage();
        private DataGridView dataGridViewWindows = new DataGridView();
        private DataGridViewTextBoxColumn column_window = new DataGridViewTextBoxColumn();
        private DataGridViewTextBoxColumn column_nameRoom_window = new DataGridViewTextBoxColumn();
        private DataGridViewTextBoxColumn column_aperture_window = new DataGridViewTextBoxColumn();

        public void addWindowMng()
        {
            initTabPageWindowMng();
            fillDataGridViewWindows();           

        }//addWindowMng

        public void initTabPageWindowMng()
        {
            //
            // tabPageWindows
            //

            this.tabPageWindows.Text = "Windows";
            this.tabPageWindows.Location = new System.Drawing.Point(4, 22);
            this.tabPageWindows.Size = new System.Drawing.Size(663, 313);

            //
            // dataGridView
            //

            this.dataGridViewWindows.Size = new System.Drawing.Size(330, 230);
            this.dataGridViewWindows.AllowUserToAddRows = false;
            this.dataGridViewWindows.AllowUserToDeleteRows = false;
            this.dataGridViewWindows.AllowUserToResizeColumns = false;
            this.dataGridViewWindows.AllowUserToResizeRows = false;
            this.dataGridViewWindows.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewWindows.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewWindows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWindows.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_window,
            this.column_nameRoom_window,
            this.column_aperture_window});
            this.dataGridViewWindows.Location = new System.Drawing.Point(169, 24);
            this.dataGridViewWindows.Name = "dataGridViewWindows";
            this.dataGridViewWindows.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewWindows.MultiSelect = false;
            this.dataGridViewWindows.TabIndex = 0;
            //this.dataGridViewWindows.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewWindows_selectedRowsButton_Click);
            // 
            // column_nameHeater
            // 
            this.column_window.HeaderText = "Window Id";
            this.column_window.Name = "column_nameHeater";
            this.column_window.ReadOnly = true;
            // 
            // column_nameRoom_window
            // 
            this.column_nameRoom_window.HeaderText = "Room";
            this.column_nameRoom_window.Name = "column_nameRoom_window";
            this.column_nameRoom_window.ReadOnly = true;
            // 
            // column_aperture_window
            // 
            this.column_aperture_window.HeaderText = "Aperture";
            this.column_aperture_window.Name = "column_aperture_window";
            this.column_aperture_window.ReadOnly = true;
            //Add the element to the tabPageWindow
            this.tabPageWindows.Controls.Add(this.dataGridViewWindows);
            //Add tapPageHeaters to the tabControl
            this.tabControl.Controls.Add(tabPageWindows);

        }

        public void fillDataGridViewWindows()
        {
            List<Floor> f = gateway.getFloors();
            int numRowSelected = 0;
            if (dataGridViewWindows.RowCount > 0)
                numRowSelected = dataGridViewWindows.SelectedRows[0].Index;                
            //Clear the dataGridViewWindows
            dataGridViewWindows.Rows.Clear();
            for (int i = 0; i < f.Count; i++)
            {
                List<Room> r = f[i].getRooms();
                for (int j = 0; j < r.Count; j++)
                {
                    List<WindowCtrl> w = gateway.findWindowsCtrlByRoom(r[j].getId());
                    
                    for (int k = 0; k < w.Count; k++)
                    {
                       dataGridViewWindows.Rows.Add(new string[] {w[k].getId().ToString(),
                                                                  r[j].getName(),
                                                                  w[k].getValue().ToString()});
                    }//for                    
                }//for
            }//for 
            if (dataGridViewWindows.RowCount > 0)
                dataGridViewWindows.Rows[numRowSelected].Selected = true;
        }//fillDataGridViewWindows
    }//SimulatorGUI
}//SmartHome
