using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartHome
{
    partial class SimulatorGUI
    {
        private TabPage tabPageHeaters = new TabPage();
        private DataGridView dataGridViewHeaters= new DataGridView();
        private DataGridViewTextBoxColumn column_heater = new DataGridViewTextBoxColumn();
        private DataGridViewTextBoxColumn column_nameRoom_heater = new DataGridViewTextBoxColumn();
        private DataGridViewTextBoxColumn column_status_heater = new DataGridViewTextBoxColumn();
        private DataGridViewTextBoxColumn column_working_heater = new DataGridViewTextBoxColumn();
        private DataGridViewTextBoxColumn column_degrees_heater = new DataGridViewTextBoxColumn();
        private DataGridViewTextBoxColumn column_tempIndoor_heater = new DataGridViewTextBoxColumn();
        private System.Windows.Forms.TextBox textBoxTemperature = new System.Windows.Forms.TextBox();
        private System.Windows.Forms.Label labelTemperature = new System.Windows.Forms.Label();
        private System.Windows.Forms.RichTextBox richTextBoxSimulated = new RichTextBox();
        private System.Windows.Forms.Label labelSimulated = new Label();
        private int selected = 0;
        
        

        public void addHeaterMng()
        {
            initTabPageHeaters();
            fillDataGridViewHeaters();
            if (dataGridViewHeaters.Rows.Count > 0)
            {
                this.labelTemperature.Visible = true;
                this.textBoxTemperature.Visible = true;
            }
            
        }//addHeaterMng

        public void fillDataGridViewHeaters()
        {

            List<Floor> f = gateway.getFloors();
            String status;
            String degrees;
            String work;
            //Clear the dataGridViewHeaters
            dataGridViewHeaters.Rows.Clear();            
            for (int i = 0; i < f.Count; i++)
            {
                List<Room> r = f[i].getRooms();
                for (int j = 0; j < r.Count; j++)
                {
                    List<HeaterCtrl> h = gateway.findHeatersByRoom(r[j].getId());                    
                    for (int k = 0; k < h.Count; k++)
                    {

                        if (h[k].status())
                        {
                            status = "ON";
                            degrees = h[k].getValue().ToString();
                        }//if
                        else
                        {
                            status = "OFF";
                            degrees = "-";
                        }//else
                        if (h[k].getWork()) work = "ON";
                        else work = "OFF";
                        Thermometer t = gateway.findThermometerByHeater(h[k].getId());
                        dataGridViewHeaters.Rows.Add(new string[] { h[k].getId().ToString(), 
                                                                    r[j].getName(),
                                                                    status,
                                                                     work,
                                                                    degrees,
                                                                    t.getValue().ToString()});
                    }//for                    
                }//for
            }//for
   
            //dataGridViewHeaters.ClearSelection();
            
        }//fillDataGridViewHeaters


        public void initTabPageHeaters()
        {
            // 
            // richTextBoxSimulated
            // 
            this.richTextBoxSimulated.Location = new System.Drawing.Point(232, 272);
            this.richTextBoxSimulated.Name = "richTextBoxSimulated";
            this.richTextBoxSimulated.ReadOnly = true;
            this.richTextBoxSimulated.Size = new System.Drawing.Size(241, 37);
            this.richTextBoxSimulated.TabIndex = 11;
            this.richTextBoxSimulated.Text = "";
            // 
            // labelSimulated
            // 
            this.labelSimulated.AutoSize = true;
            this.labelSimulated.Location = new System.Drawing.Point(276, 256);
            this.labelSimulated.Name = "labelSimulated";
            this.labelSimulated.Size = new System.Drawing.Size(146, 13);
            this.labelSimulated.TabIndex = 10;
            this.labelSimulated.Text = "Simulated accions for heaters";
            
            //
            // tabPageHeaters
            //
           
            this.tabPageHeaters.Text = "Heaters";
            this.tabPageHeaters.Location = new System.Drawing.Point(4, 22);
            this.tabPageHeaters.Size = new System.Drawing.Size(663, 313);
            // 
            // dataGridViewRooms
            // 
            this.dataGridViewHeaters.Size = new System.Drawing.Size(630, 230);
            this.dataGridViewHeaters.AllowUserToAddRows = false;
            this.dataGridViewHeaters.AllowUserToDeleteRows = false;
            this.dataGridViewHeaters.AllowUserToResizeColumns = false;
            this.dataGridViewHeaters.AllowUserToResizeRows = false;
            this.dataGridViewHeaters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewHeaters.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewHeaters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHeaters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_heater,
            this.column_nameRoom_heater,
            this.column_status_heater,
            this.column_working_heater,
            this.column_degrees_heater,
            this.column_tempIndoor_heater});
            this.dataGridViewHeaters.Location = new System.Drawing.Point(20, 6);
            this.dataGridViewHeaters.Name = "dataGridViewHeaters";
            this.dataGridViewHeaters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHeaters.MultiSelect = false;
            this.dataGridViewHeaters.TabIndex = 0;
            //this.dataGridViewHeaters.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHeaters_selectedRowsButton_Click);
            // 
            // column_nameHeater
            // 
            this.column_heater.HeaderText = "Heater Id";
            this.column_heater.Name = "column_nameHeater";
            this.column_heater.ReadOnly = true;
            // 
            // column_nameRoom_heater
            // 
            this.column_nameRoom_heater.HeaderText = "Room";
            this.column_nameRoom_heater.Name = "column_nameRoom_heater";
            this.column_nameRoom_heater.ReadOnly = true;
            // 
            // column_status_heater
            // 
            this.column_status_heater.HeaderText = "Status";
            this.column_status_heater.Name = "column_status_heater";
            this.column_status_heater.ReadOnly = true;
            // 
            // column_working_heater
            // 
            this.column_working_heater.HeaderText = "Working";
            this.column_working_heater.Name = "column_working_heater";
            this.column_working_heater.ReadOnly = true;
            // 
            // column_degrees_heater
            // 
            this.column_degrees_heater.HeaderText = "Degrees";
            this.column_degrees_heater.Name = "column_degrees_heater";
            this.column_degrees_heater.ReadOnly = true;
            // 
            // column_tempIndoor_heater
            // 
            this.column_tempIndoor_heater.HeaderText = "Temp. Indoor";
            this.column_tempIndoor_heater.Name = "column_tempIndoor_heater";
            this.column_tempIndoor_heater.ReadOnly = true;
            //
            // TextBoxTemperature
            //
            this.textBoxTemperature.Location = new System.Drawing.Point(155, 5);
            this.textBoxTemperature.Name = "textBoxTemperature";
            this.textBoxTemperature.Size = new System.Drawing.Size(30, 20);
            this.textBoxTemperature.TabIndex = 9;
            this.textBoxTemperature.Visible = false;
            this.textBoxTemperature.KeyDown += new KeyEventHandler(textTemp_KeyDown);
            this.richTextBoxSimulated.Controls.Add(this.textBoxTemperature);
            //
            //LabelTemperature
            //
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.Location = new System.Drawing.Point(45, 5);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(102, 13);
            this.labelTemperature.TabIndex = 10;
            this.labelTemperature.Text = "Temperature indoor:";
            this.labelTemperature.Visible = false;
            this.richTextBoxSimulated.Controls.Add(this.labelTemperature);
            
            //Add the element to the tabPageHeaters
            this.tabPageHeaters.Controls.Add(this.dataGridViewHeaters);
            //Add tapPageHeaters to the tabControl
            this.tabControl.Controls.Add(tabPageHeaters);
            this.tabPageHeaters.Controls.Add(richTextBoxSimulated);
            this.tabPageHeaters.Controls.Add(labelSimulated);
        }

       
             
        
    }//SimulatorGUI
}//SmartHome