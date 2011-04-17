using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartHome
{
    public partial class SimulatorGUI : IDeviceObserver
    {
        private TabPage tabPageBlinds = new TabPage();
        private DataGridView dataGridViewBlinds = new DataGridView();
        private DataGridViewTextBoxColumn column_Blind = new DataGridViewTextBoxColumn();
        private DataGridViewTextBoxColumn column_nameRoom_Blind = new DataGridViewTextBoxColumn();
        private DataGridViewTextBoxColumn column_aperture_Blind = new DataGridViewTextBoxColumn();
        private DataGridViewTextBoxColumn column_window_Blind = new DataGridViewTextBoxColumn();

        public void addBlindMng()
        {
            initTabPageBlindMng();
            fillDataGridViewBlinds();
            blindMng_registerObserver();

        }//addBlindMng

        public void initTabPageBlindMng()
        {
            //
            // tabPageBlinds
            //

            this.tabPageBlinds.Text = "Blinds";
            this.tabPageBlinds.Location = new System.Drawing.Point(4, 22);
            this.tabPageBlinds.Size = new System.Drawing.Size(663, 313);

            //
            // dataGridView
            //

            this.dataGridViewBlinds.Size = new System.Drawing.Size(430, 230);
            this.dataGridViewBlinds.AllowUserToAddRows = false;
            this.dataGridViewBlinds.AllowUserToDeleteRows = false;
            this.dataGridViewBlinds.AllowUserToResizeColumns = false;
            this.dataGridViewBlinds.AllowUserToResizeRows = false;
            this.dataGridViewBlinds.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBlinds.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewBlinds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBlinds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_Blind,
            this.column_window_Blind,
            this.column_nameRoom_Blind,
            this.column_aperture_Blind});
            this.dataGridViewBlinds.Location = new System.Drawing.Point(129, 24);
            this.dataGridViewBlinds.Name = "dataGridViewBlinds";
            this.dataGridViewBlinds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBlinds.MultiSelect = false;
            this.dataGridViewBlinds.TabIndex = 0;
            // 
            // column_nameBlind
            // 
            this.column_Blind.HeaderText = "Blind Id";
            this.column_Blind.Name = "column_nameBlind";
            this.column_Blind.ReadOnly = true;
            // 
            // column_nameRoom_Blind
            // 
            this.column_nameRoom_Blind.HeaderText = "Room";
            this.column_nameRoom_Blind.Name = "column_nameRoom_blind";
            this.column_nameRoom_Blind.ReadOnly = true;
            // 
            // column_aperture_Blind
            // 
            this.column_aperture_Blind.HeaderText = "Aperture";
            this.column_aperture_Blind.Name = "column_aperture_blind";
            this.column_aperture_Blind.ReadOnly = true;
            // 
            // column_window_Blind
            // 
            this.column_window_Blind.HeaderText = "Window Id";
            this.column_window_Blind.Name = "column_window_blind";
            this.column_window_Blind.ReadOnly = true;

            //Add the element to the tabPageBlind
            this.tabPageBlinds.Controls.Add(this.dataGridViewBlinds);
            //Add tapPageHeaters to the tabControl
            this.tabControl.Controls.Add(tabPageBlinds);

        }

        public void fillDataGridViewBlinds()
        {
            List<Floor> f = gateway.getFloors();
            int numRowSelected = 0;
            if (dataGridViewBlinds.RowCount > 0)
                numRowSelected = dataGridViewBlinds.SelectedRows[0].Index;
            //Clear the dataGridViewBlinds
            dataGridViewBlinds.Rows.Clear();
            for (int i = 0; i < f.Count; i++)
            {
                List<Room> r = f[i].getRooms();
                for (int j = 0; j < r.Count; j++)
                {
                    List<WindowCtrl> w = gateway.windowMng_findWindowsCtrlByRoom(r[j].getId());

                    for (int k = 0; k < w.Count; k++)
                    {
                        List<BlindCtrl> b = gateway.blindMng_findblindsCtrlByWindow(w[k].getId());

                        for (int l = 0; l < b.Count; l++)
                        {
                            BlindSensor bs = gateway.blindMng_findBlindSensorByidBlind(b[l].getId());
                            dataGridViewBlinds.Rows.Add(new string[] {b[l].getId().ToString(),
                                                                      w[k].getId().ToString(),
                                                                      r[j].getName(),
                                                                      bs.getValue().ToString()});
                        }//for
                    }//for                    
                }//for
            }//for 
            if (dataGridViewBlinds.RowCount > 0)
                dataGridViewBlinds.Rows[numRowSelected].Selected = true;
        }//fillDataGridViewBlinds

        #region IDeviceObserver Members

        void blindMng_registerObserver()
        {
            List<BlindCtrl> b = gateway.blindMng_getBlinds();
            List<BlindSensor> bs = gateway.blindMng_getBlindsSensors();
            for (int i = 0; i < b.Count; i++)
            {
                b[i].registerObserver(this);
            }//for
            for (int j = 0; j < bs.Count; j++)
            {
                bs[j].registerObserver(this);
            }//for
        }//blindMng_registerObserver         

        #endregion
    }//SimulatorGUI
}//SmartHome
