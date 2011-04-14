using System.Collections.Generic;
using System.Windows;
using System;

namespace SmartHome
{
    partial class SimulatorGUI:IDeviceObserver
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimulatorGUI));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageRooms = new System.Windows.Forms.TabPage();
            this.dataGridViewRooms = new System.Windows.Forms.DataGridView();
            this.column_nameRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_id_room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_floor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.tabPageRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageRooms);
            this.tabControl.Location = new System.Drawing.Point(-2, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(684, 340);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageRooms
            // 
            this.tabPageRooms.Controls.Add(this.dataGridViewRooms);
            this.tabPageRooms.Location = new System.Drawing.Point(4, 22);
            this.tabPageRooms.Name = "tabPageRooms";
            this.tabPageRooms.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRooms.Size = new System.Drawing.Size(676, 314);
            this.tabPageRooms.TabIndex = 0;
            this.tabPageRooms.Text = "Rooms";
            this.tabPageRooms.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRooms
            // 
            this.dataGridViewRooms.AllowUserToAddRows = false;
            this.dataGridViewRooms.AllowUserToDeleteRows = false;
            this.dataGridViewRooms.AllowUserToResizeColumns = false;
            this.dataGridViewRooms.AllowUserToResizeRows = false;
            this.dataGridViewRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRooms.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_nameRoom,
            this.column_id_room,
            this.column_floor});
            this.dataGridViewRooms.Location = new System.Drawing.Point(169, 24);
            this.dataGridViewRooms.MultiSelect = false;
            this.dataGridViewRooms.Name = "dataGridViewRooms";
            this.dataGridViewRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRooms.Size = new System.Drawing.Size(343, 258);
            this.dataGridViewRooms.TabIndex = 0;            
            // 
            // column_nameRoom
            // 
            this.column_nameRoom.HeaderText = "Name";
            this.column_nameRoom.Name = "column_nameRoom";
            this.column_nameRoom.ReadOnly = true;
            // 
            // column_id_room
            // 
            this.column_id_room.HeaderText = "Id Room";
            this.column_id_room.Name = "column_id_room";
            this.column_id_room.ReadOnly = true;
            // 
            // column_floor
            // 
            this.column_floor.HeaderText = "Floor";
            this.column_floor.Name = "column_floor";
            this.column_floor.ReadOnly = true;
            // 
            // SimulatorGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 336);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SimulatorV2";
            this.Text = "Simulator";
            this.tabControl.ResumeLayout(false);
            this.tabPageRooms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageRooms;
        private System.Windows.Forms.DataGridView dataGridViewRooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_nameRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_id_room;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_floor;
        private Gateway gateway;
        private List<string[]> listRows = new List<string[]>();
        //<Index of DataGridView, id_room>
        private Dictionary<int, int> dictionaryRooms = new Dictionary<int, int>();

        public SimulatorGUI(Gateway gateway)
        {
            this.gateway = gateway;
            InitializeComponent();            
            addRooms();                      
        }//Simulator

        private void addRooms()
        {
            
            List<Floor> f=gateway.getFloors();
            for (int i = 0; i < f.Count; i++)
            {
                List<Room> r = f[i].getRooms();
                for (int j = 0; j < r.Count; j++)
                {
                   dataGridViewRooms.Rows.Add(new string[] { r[j].getName(), r[j].getId().ToString(), f[i].getName()});
                   dictionaryRooms.Add(dataGridViewRooms.Rows.Count-1, r[j].getId());
                }//for
            }//for
        }//addRooms 

        #region Observer-pattern
        void IDeviceObserver.deviceValueChanged(Device dev)
        {
            //Variable Method
            observerRefreshDataGrid(); 
        }
        #endregion
       
    }


}