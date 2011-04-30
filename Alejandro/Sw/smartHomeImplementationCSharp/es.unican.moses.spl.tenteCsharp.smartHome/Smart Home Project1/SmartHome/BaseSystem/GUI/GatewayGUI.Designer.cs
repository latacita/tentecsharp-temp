using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SmartHome
{
    //============================================================================================================================//
    // This class represents the visual interface for the Gateway                                                                 //
    //============================================================================================================================//
    partial class GatewayGUI
    {
        //Values for windows size
        private const int height = 330;
        private const int width = 380;

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
        }// Dispose

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
            this.tabControl_floors.Location = new System.Drawing.Point(-2, 1);
            this.tabControl_floors.Name = "tabControl_floors";
            this.tabControl_floors.SelectedIndex = 0;
            this.tabControl_floors.Size = new System.Drawing.Size(width - 6, height - 25);
            this.tabControl_floors.TabIndex = 4;
            // 
            // tabControl_main
            // 
            this.tabControl_main.Controls.Add(this.tabPage_floors);
            this.tabControl_main.Location = new System.Drawing.Point(-1, -1);
            this.tabControl_main.Name = "tabControl_main";
            this.tabControl_main.SelectedIndex = 0;
            this.tabControl_main.Size = new System.Drawing.Size(width, height);
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
            this.tabPage_floors.Size = new System.Drawing.Size(width - 8, height - 26);
            this.tabPage_floors.TabIndex = 0;
            this.tabPage_floors.Text = "Floors";
            this.tabPage_floors.UseVisualStyleBackColor = true;
            // 
            // GatewayGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(width, height);
            this.Controls.Add(this.tabControl_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GatewayGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gateway";
            this.tabControl_main.ResumeLayout(false);
            this.tabPage_floors.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        /// <summary>
        /// Gateway object
        /// </summary>
        Gateway gateway = new Gateway();
        /// <summary>
        /// Visual components
        /// </summary>
        protected TabControl tabControl_main;
        protected TabPage tabPage_floors;
        protected TabControl tabControl_floors;
        protected List<TabControl> listTabControl_rooms = new List<TabControl>();
        protected List<TabPage> listTabPageFloors = new List<TabPage>();
        protected Dictionary<int, TabPage> DictionaryTabPageRooms = new Dictionary<int, TabPage>();
        protected Dictionary<int, TabControl> DictionaryTabControlDevice = new Dictionary<int, TabControl>();
        protected Dictionary<int, TabPage> DictionaryTabPageDevice = new Dictionary<int, TabPage>();
        //protected SimulatorGUI simulator;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="g">An object of Gateway class</param>
        public GatewayGUI(Gateway g)
        {
            this.gateway = g;
            InitializeComponent();            
        }//GatewayGUI(Gateway)

        /// <summary>
        /// Method to add floors and rooms in GUI
        /// </summary>
        public void addBaseSystem()
        {
            List<Floor> f = gateway.getFloors();
            for (int i = 0; i < f.Count; i++)
            {
                listTabPageFloors.Add(new TabPage());
                listTabPageFloors[i].Text = "FloorGUI: " + f[i].getName();
                listTabPageFloors[i].BorderStyle = BorderStyle.Fixed3D;
                tabControl_floors.Controls.Add(listTabPageFloors[i]);
                //tabControl for rooms
                List<Room> aux = f[i].getRooms();
                listTabControl_rooms.Add(new TabControl());
                this.listTabControl_rooms[i].Name = "tabControl_room " + i;
                this.listTabControl_rooms[i].Size = new System.Drawing.Size(width - 12, height - 26);
                this.listTabPageFloors[i].Controls.Add(listTabControl_rooms[i]);
                //tabPage for rooms
                for (int j = 0; j < aux.Count; j++)
                {
                    int auxIdRoom = aux[j].getId();
                    this.DictionaryTabPageRooms.Add(auxIdRoom, new TabPage(aux[j].getName()));
                    this.DictionaryTabPageRooms[auxIdRoom].BorderStyle = BorderStyle.Fixed3D;
                    this.listTabControl_rooms[i].Controls.Add(DictionaryTabPageRooms[auxIdRoom]);
                    //TabControl for room devices
                    this.DictionaryTabControlDevice.Add(auxIdRoom, new TabControl());
                    this.DictionaryTabControlDevice[auxIdRoom].Size = new System.Drawing.Size(width - 14, height - 30);
                    this.DictionaryTabPageRooms[auxIdRoom].Controls.Add(this.DictionaryTabControlDevice[auxIdRoom]);
                }// for
            }// for            
        }// addFloors       
    }// GatewayGUI
}//SmartHome