using System;
using System.Collections.Generic;
using System.Windows.Forms;
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
            this.tabControl_floors = new System.Windows.Forms.TabControl();
            this.tabControl_main = new System.Windows.Forms.TabControl();
            this.tabPage_floors = new System.Windows.Forms.TabPage();
            this.tabControl_main.SuspendLayout();
            this.tabPage_floors.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_floors
            // 
            this.tabControl_floors.Location = new System.Drawing.Point(0, 0);
            this.tabControl_floors.Name = "tabControl_floors";
            this.tabControl_floors.SelectedIndex = 0;
            this.tabControl_floors.Size = new System.Drawing.Size(377, 304);
            this.tabControl_floors.TabIndex = 4;
            // 
            // tabControl_main
            // 
            this.tabControl_main.Controls.Add(this.tabPage_floors);
            this.tabControl_main.Location = new System.Drawing.Point(-1, -1);
            this.tabControl_main.Name = "tabControl_main";
            this.tabControl_main.SelectedIndex = 0;
            this.tabControl_main.Size = new System.Drawing.Size(385, 330);
            this.tabControl_main.TabIndex = 5;
            // 
            // tabPage_floors
            // 
            this.tabPage_floors.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage_floors.Controls.Add(this.tabControl_floors);
            this.tabPage_floors.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage_floors.Location = new System.Drawing.Point(4, 22);
            this.tabPage_floors.Name = "tabPage_floors";
            this.tabPage_floors.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_floors.Size = new System.Drawing.Size(377, 304);
            this.tabPage_floors.TabIndex = 0;
            this.tabPage_floors.Text = "Floors";
            this.tabPage_floors.UseVisualStyleBackColor = true;
            // 
            // GatewayGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(384, 326);
            this.Controls.Add(this.tabControl_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GatewayGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gateway";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl_main.ResumeLayout(false);
            this.tabPage_floors.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl_floors;
        private List<TabPage> listTabPage = new List<TabPage> ();
        private List<Floor> floors;


        
        public void addFloors(List<Floor> f)
        {
            
            floors = f;
            //TabPage tabPage1 = new TabPage();

            for (int i = 0; i < f.Count; i++)
            {
                listTabPage.Add(new TabPage());
                //Text
                listTabPage[i].Text ="FloorGUI: " + f[i].getName();
                //Border style
                listTabPage[i].BorderStyle = BorderStyle.Fixed3D;
                tabControl_floors.Controls.Add(listTabPage[i]);
                //listBoxFloors.Items.Add(f[i].getName());
            }//for            
        }//addFloors

        public void addRooms(List<Room> r)
        {
            for (int i = 0; i < r.Count; i++)
            {
                //listBoxRooms.Items.Add(r[i].getName());
            }//for
        }

        private TabControl tabControl_main;
        private TabPage tabPage_floors;//addRooms

        
    }
}//SmartHome