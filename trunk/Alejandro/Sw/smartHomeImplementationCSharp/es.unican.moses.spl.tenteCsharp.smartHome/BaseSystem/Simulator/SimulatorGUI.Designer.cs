using System;
using System.Collections.Generic;
namespace SmartHome
{
    partial class SimulatorGUI
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
            this.listBoxFloors = new System.Windows.Forms.ListBox();
            this.listBoxRooms = new System.Windows.Forms.ListBox();
            this.labelFloors = new System.Windows.Forms.Label();
            this.labelRooms = new System.Windows.Forms.Label();
            this.listDevices = new System.Windows.Forms.ListBox();
            this.labelDevices = new System.Windows.Forms.Label();
            this.richTextBoxStatus = new System.Windows.Forms.RichTextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelSimulated = new System.Windows.Forms.Label();
            this.richTextBoxSimulated = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // listBoxFloors
            // 
            this.listBoxFloors.FormattingEnabled = true;
            this.listBoxFloors.Location = new System.Drawing.Point(12, 34);
            this.listBoxFloors.Name = "listBoxFloors";
            this.listBoxFloors.Size = new System.Drawing.Size(122, 225);
            this.listBoxFloors.TabIndex = 0;
            this.listBoxFloors.SelectedIndexChanged += new System.EventHandler(this.listBoxFloors_SelectedIndexChanged);
            // 
            // listBoxRooms
            // 
            this.listBoxRooms.FormattingEnabled = true;
            this.listBoxRooms.Location = new System.Drawing.Point(147, 34);
            this.listBoxRooms.Name = "listBoxRooms";
            this.listBoxRooms.Size = new System.Drawing.Size(124, 225);
            this.listBoxRooms.TabIndex = 1;
            // 
            // labelFloors
            // 
            this.labelFloors.AutoSize = true;
            this.labelFloors.Location = new System.Drawing.Point(9, 15);
            this.labelFloors.Name = "labelFloors";
            this.labelFloors.Size = new System.Drawing.Size(35, 13);
            this.labelFloors.TabIndex = 2;
            this.labelFloors.Text = "Floors";
            this.labelFloors.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelRooms
            // 
            this.labelRooms.AutoSize = true;
            this.labelRooms.Location = new System.Drawing.Point(144, 15);
            this.labelRooms.Name = "labelRooms";
            this.labelRooms.Size = new System.Drawing.Size(40, 13);
            this.labelRooms.TabIndex = 3;
            this.labelRooms.Text = "Rooms";
            // 
            // listDevices
            // 
            this.listDevices.FormattingEnabled = true;
            this.listDevices.Location = new System.Drawing.Point(288, 34);
            this.listDevices.Name = "listDevices";
            this.listDevices.Size = new System.Drawing.Size(120, 225);
            this.listDevices.TabIndex = 4;
            // 
            // labelDevices
            // 
            this.labelDevices.AutoSize = true;
            this.labelDevices.Location = new System.Drawing.Point(285, 15);
            this.labelDevices.Name = "labelDevices";
            this.labelDevices.Size = new System.Drawing.Size(46, 13);
            this.labelDevices.TabIndex = 5;
            this.labelDevices.Text = "Devices";
            // 
            // richTextBoxStatus
            // 
            this.richTextBoxStatus.Enabled = false;
            this.richTextBoxStatus.Location = new System.Drawing.Point(427, 34);
            this.richTextBoxStatus.Name = "richTextBoxStatus";
            this.richTextBoxStatus.Size = new System.Drawing.Size(166, 91);
            this.richTextBoxStatus.TabIndex = 6;
            this.richTextBoxStatus.Text = "";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(424, 15);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(37, 13);
            this.labelStatus.TabIndex = 7;
            this.labelStatus.Text = "Status";
            // 
            // labelSimulated
            // 
            this.labelSimulated.AutoSize = true;
            this.labelSimulated.Location = new System.Drawing.Point(430, 141);
            this.labelSimulated.Name = "labelSimulated";
            this.labelSimulated.Size = new System.Drawing.Size(93, 13);
            this.labelSimulated.TabIndex = 8;
            this.labelSimulated.Text = "Simulated accions";
            // 
            // richTextBoxSimulated
            // 
            this.richTextBoxSimulated.Location = new System.Drawing.Point(433, 158);
            this.richTextBoxSimulated.Name = "richTextBoxSimulated";
            this.richTextBoxSimulated.ReadOnly = true;
            this.richTextBoxSimulated.Size = new System.Drawing.Size(160, 101);
            this.richTextBoxSimulated.TabIndex = 9;
            this.richTextBoxSimulated.Text = "";
            // 
            // SimulatorGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 281);
            this.Controls.Add(this.richTextBoxSimulated);
            this.Controls.Add(this.labelSimulated);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.richTextBoxStatus);
            this.Controls.Add(this.labelDevices);
            this.Controls.Add(this.listDevices);
            this.Controls.Add(this.labelRooms);
            this.Controls.Add(this.labelFloors);
            this.Controls.Add(this.listBoxRooms);
            this.Controls.Add(this.listBoxFloors);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SimulatorGUI";
            this.Text = "SimulatorGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.ListBox listBoxFloors;
        private System.Windows.Forms.ListBox listBoxRooms;
        private System.Windows.Forms.Label labelFloors;
        private System.Windows.Forms.Label labelRooms;
        private System.Windows.Forms.ListBox listDevices;
        private System.Windows.Forms.Label labelDevices;
        private System.Windows.Forms.RichTextBox richTextBoxStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelSimulated;
        private System.Windows.Forms.RichTextBox richTextBoxSimulated;
        //Dictionary<index, id_floor>
        private Dictionary<int, int> dictionaryListFloors = new Dictionary<int, int>();
        //Dictionary<index, id_room>
        private Dictionary<int, int> dictionaryListRooms = new Dictionary<int, int>();
        
        public void addBaseSimulator()
        {
            addFloors();
            
            
        }//addBaseSimulator

        private void addFloors()
        {
            List<Floor> f = gateway.getFloors();
            for (int i = 0; i<f.Count; i++)
            {
               listBoxFloors.Items.Add(f[i].getName());
               dictionaryListFloors.Add(i, f[i].getId());
            }// for
        }// addFloors

        private void addRooms(Floor f)
        {
            List<Room> rooms = f.getRooms();
            for (int i = 0; i < rooms.Count; i++)
            {
                dictionaryListRooms.Remove(i);
                listBoxRooms.Items.Add(rooms[i].getName());
                dictionaryListRooms.Add(i, rooms[i].getId());
            }//for
        }//addRooms

        
    }
}