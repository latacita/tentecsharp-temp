using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartHome
{
    //=====================================================================================================================//
    // This class represents the visual interface for the Simulator, where you can view the current values of the sensors. //
    // This file only contains the funcionality related to the LightMng feature.                                           //                                                                                                                                             
    //=====================================================================================================================//
    public partial class SimulatorGUI : IDeviceObserver
    {
        //Visual components
        protected TabPage tabPageLigths = new TabPage();
        protected DataGridView dataGridViewLigths = new DataGridView();
        protected DataGridViewTextBoxColumn column_ligth = new DataGridViewTextBoxColumn();
        protected DataGridViewTextBoxColumn column_nameRoom_ligth = new DataGridViewTextBoxColumn();
        protected DataGridViewTextBoxColumn column_ligthing_ligth = new DataGridViewTextBoxColumn();

        /// <summary>
        /// Constructor to add the lightMng to SimulatorGUI
        /// </summary>
        public void addLightMng()
        {
            initTabPageLigthMng();
            filldataGridViewLigths();
            lightMng_registerObserver();

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
                    List<LightCtrl> l = gateway.lightMng_findLigthCtrlByRoom(r[j].getId());

                    for (int k = 0; k < l.Count; k++)
                    {
                        LightSensor ls = gateway.lightMng_findLigthSensorByIdLigth(l[k].getId());
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

        void lightMng_registerObserver()
        {
            List<LightCtrl> l = gateway.lightMng_getLights();
            List<LightSensor> ls = gateway.lightMng_getLigthsSensors();
            for (int i = 0; i < l.Count; i++)
            {
                l[i].registerObserver(this);
            }//for
            for (int j = 0; j < ls.Count; j++)
            {
                ls[j].registerObserver(this);
            }//for
        }//lightMng_registerObserver

        #endregion
    }//SimulatorGUI
}//SmartHome
