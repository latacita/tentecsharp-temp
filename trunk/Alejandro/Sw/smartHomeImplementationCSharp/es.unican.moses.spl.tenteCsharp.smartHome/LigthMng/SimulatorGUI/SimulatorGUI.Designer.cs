using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartHome
{
    public partial class SimulatorGUI : IDeviceObserver
    {
        private TabPage tabPageLigths = new TabPage();
        private DataGridView dataGridViewLigths = new DataGridView();
        private DataGridViewTextBoxColumn column_ligth = new DataGridViewTextBoxColumn();
        private DataGridViewTextBoxColumn column_nameRoom_ligth = new DataGridViewTextBoxColumn();
        private DataGridViewTextBoxColumn column_ligthing_ligth = new DataGridViewTextBoxColumn();

        public void addLigthMng()
        {
            initTabPageLigthMng();
            filldataGridViewLigths();
            ligthMng_registerObserver();

        }//addWindowMng

        public void initTabPageLigthMng()
        {
            //
            // tabPageLigths
            //

            this.tabPageLigths.Text = "Ligths";
            this.tabPageLigths.Location = new System.Drawing.Point(4, 22);
            this.tabPageLigths.Size = new System.Drawing.Size(663, 313);

            //
            // dataGridView
            //

            this.dataGridViewLigths.Size = new System.Drawing.Size(330, 230);
            this.dataGridViewLigths.AllowUserToAddRows = false;
            this.dataGridViewLigths.AllowUserToDeleteRows = false;
            this.dataGridViewLigths.AllowUserToResizeColumns = false;
            this.dataGridViewLigths.AllowUserToResizeRows = false;
            this.dataGridViewLigths.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewLigths.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewLigths.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLigths.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_ligth,
            this.column_nameRoom_ligth,
            this.column_ligthing_ligth});
            this.dataGridViewLigths.Location = new System.Drawing.Point(169, 24);
            this.dataGridViewLigths.Name = "dataGridViewLigths";
            this.dataGridViewLigths.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLigths.MultiSelect = false;
            this.dataGridViewLigths.TabIndex = 0;
            //this.dataGridViewLigths.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLigths_selectedRowsButton_Click);
            // 
            // column_nameHeater
            // 
            this.column_ligth.HeaderText = "Ligth Id";
            this.column_ligth.Name = "column_nameHeater";
            this.column_ligth.ReadOnly = true;
            // 
            // column_nameRoom_ligth
            // 
            this.column_nameRoom_ligth.HeaderText = "Room";
            this.column_nameRoom_ligth.Name = "column_nameRoom_ligth";
            this.column_nameRoom_ligth.ReadOnly = true;
            // 
            // column_ligthing_ligth
            // 
            this.column_ligthing_ligth.HeaderText = "Ligthing";
            this.column_ligthing_ligth.Name = "column_ligthing_ligth";
            this.column_ligthing_ligth.ReadOnly = true;
            //Add the element to the tabPageWindow
            this.tabPageLigths.Controls.Add(this.dataGridViewLigths);
            //Add tapPageLigths to the tabControl
            this.tabControl.Controls.Add(tabPageLigths);

        }

        public void filldataGridViewLigths()
        {
            List<Floor> f = gateway.getFloors();
            int numRowSelected = 0;
            if (dataGridViewLigths.RowCount > 0)
                numRowSelected = dataGridViewLigths.SelectedRows[0].Index;
            //Clear the dataGridViewLigths
            dataGridViewLigths.Rows.Clear();
            for (int i = 0; i < f.Count; i++)
            {
                List<Room> r = f[i].getRooms();
                for (int j = 0; j < r.Count; j++)
                {
                    List<LigthCtrl> l = gateway.ligthMng_findLigthCtrlByRoom(r[j].getId());
                   
                    for (int k = 0; k < l.Count; k++)
                    {
                        LigthSensor ls = gateway.ligthMng_findLigthSensorByIdLigth(l[k].getId());
                        dataGridViewLigths.Rows.Add(new string[] {l[k].getId().ToString(),
                                                                  r[j].getName(),
                                                                  ls.getValue().ToString()});
                    }//for                    
                }//for
            }//for 
            if (dataGridViewLigths.RowCount > 0)
                dataGridViewLigths.Rows[numRowSelected].Selected = true;
        }//filldataGridViewLigths



        #region IDeviceObserver Members

        void ligthMng_registerObserver()
        {
            List<LigthCtrl> l = gateway.ligthwMng_getLigths();
            List<LigthSensor> ls = gateway.ligthwMng_getLigthsSensors();
            for (int i = 0; i < l.Count; i++)
            {
                l[i].registerObserver(this);
            }//for
            for (int j = 0; j < ls.Count; j++)
            {
                ls[j].registerObserver(this);
            }//for
        }//ligthMng_registerObserver

        #endregion
    }//SimulatorGUI
}//SmartHome
