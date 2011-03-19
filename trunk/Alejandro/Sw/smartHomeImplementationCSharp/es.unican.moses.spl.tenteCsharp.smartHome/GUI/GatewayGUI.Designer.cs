using System;
using System.Collections.Generic;
namespace SmartHome
{
    partial class GatewayGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GatewayGUI));
            this.listBoxFloors = new System.Windows.Forms.ListBox();
            this.labelFloors = new System.Windows.Forms.Label();
            this.listBoxRooms = new System.Windows.Forms.ListBox();
            this.labelRooms = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxFloors
            // 
            this.listBoxFloors.FormattingEnabled = true;
            this.listBoxFloors.Location = new System.Drawing.Point(12, 29);
            this.listBoxFloors.Name = "listBoxFloors";
            this.listBoxFloors.Size = new System.Drawing.Size(120, 95);
            this.listBoxFloors.TabIndex = 0;
            this.listBoxFloors.SelectedIndexChanged += new System.EventHandler(this.listBoxFloors_SelectedIndexChanged);
            // 
            // labelFloors
            // 
            this.labelFloors.AutoSize = true;
            this.labelFloors.Location = new System.Drawing.Point(13, 11);
            this.labelFloors.Name = "labelFloors";
            this.labelFloors.Size = new System.Drawing.Size(35, 13);
            this.labelFloors.TabIndex = 1;
            this.labelFloors.Text = "Floors";
            // 
            // listBoxRooms
            // 
            this.listBoxRooms.FormattingEnabled = true;
            this.listBoxRooms.Location = new System.Drawing.Point(150, 29);
            this.listBoxRooms.Name = "listBoxRooms";
            this.listBoxRooms.Size = new System.Drawing.Size(120, 95);
            this.listBoxRooms.TabIndex = 2;
            // 
            // labelRooms
            // 
            this.labelRooms.AutoSize = true;
            this.labelRooms.Location = new System.Drawing.Point(153, 12);
            this.labelRooms.Name = "labelRooms";
            this.labelRooms.Size = new System.Drawing.Size(40, 13);
            this.labelRooms.TabIndex = 3;
            this.labelRooms.Text = "Rooms";
            // 
            // GatewayGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(384, 326);
            this.Controls.Add(this.labelRooms);
            this.Controls.Add(this.listBoxRooms);
            this.Controls.Add(this.labelFloors);
            this.Controls.Add(this.listBoxFloors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GatewayGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gateway";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFloors;
        private System.Windows.Forms.Label labelFloors;
        private System.Windows.Forms.ListBox listBoxRooms;
        private System.Windows.Forms.Label labelRooms;
        private List<Floor> floors;

        
        public void addFloors(List<Floor> f)
        {
            floors = f;
            for (int i = 0; i < f.Count; i++)
            {
                listBoxFloors.Items.Add(f[i].getName());
            }//for            
        }//addFloors

        public void addRooms(List<Room> r)
        {
            for (int i = 0; i < r.Count; i++)
            {
                listBoxRooms.Items.Add(r[i].getName());
            }//for
        }//addRooms
    }
}//SmartHome