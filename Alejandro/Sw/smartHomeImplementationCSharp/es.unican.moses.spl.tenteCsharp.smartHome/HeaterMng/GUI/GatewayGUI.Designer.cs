using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SmartHome
{
    partial class GatewayGUI
    {
        private TabPage tabPage_heaters;
        private TrackBar trackBar_main;
        private Button buttonSwitch;
        private Label labTemp;
        private TextBox textTemp;
        private PictureBox pictureTherm;
        private Dictionary<int, Button> dictionaryButtonSwitchByRoom = new Dictionary<int,Button>();
        private Dictionary<Button, int> inverseDictionaryButton = new Dictionary<Button, int>();
        private Dictionary<int, TrackBar> dictionaryTrackBarByRoom = new Dictionary<int, TrackBar>();
        private Dictionary<TrackBar, int> inverseDictionaryTrackBar = new Dictionary<TrackBar, int>();
        private Dictionary<int, Label> dictionaryLabelByRoom = new Dictionary<int, Label>();
        private Dictionary<int, TextBox> dictionaryTextTempByRoom = new Dictionary<int, TextBox>();
        private Dictionary<TextBox, int> inverseDictionaryTextTemp = new Dictionary<TextBox,int>();
       

        public void addHeaterMng()
        {
            List<HeaterCtrl> heaters = gateway.getHeaters();
            tabPage_heaters = new TabPage();
            tabPage_heaters.Text = "Heaters";
            tabPage_heaters.BorderStyle = BorderStyle.Fixed3D;
            tabControl_main.Controls.Add(tabPage_heaters);
            addTrackBar();
            addButton();
            addLabelTemp();
            addTextTemp();
            addThermometer();
            addHeaterByRoom(heaters);

        }// addHeaterMng
        

        private void addButton()
        {
            buttonSwitch = new Button();
            buttonSwitch.Text = "OFF";
            buttonSwitch.BackColor = System.Drawing.Color.Red;
            tabPage_heaters.Controls.Add(buttonSwitch);
            buttonSwitch.Location = new System.Drawing.Point(width/2, height/6);
            buttonSwitch.Click += new System.EventHandler(this.buttonSwitch_Click);
        }//addButton      

        private void addTrackBar()
        {
            trackBar_main = new TrackBar();
            trackBar_main.Location= new System.Drawing.Point(width/3, height/2);
            trackBar_main.Size = new System.Drawing.Size(width/3, height/16);
            trackBar_main.Maximum = 40;
            trackBar_main.Minimum = 0;
            tabPage_heaters.Controls.Add(trackBar_main);
            trackBar_main.Visible = false;
            trackBar_main.Scroll += new System.EventHandler(this.trackbar_Scroll);            
        }//addTrackBar

        private void addLabelTemp()
        {
            labTemp = new Label();
            labTemp.Size = new System.Drawing.Size(180, 20);
            labTemp.Text = "Select temperature (Celsius): ";
            labTemp.Location = new System.Drawing.Point((width-30)/3, (height+80)/3);
            tabPage_heaters.Controls.Add(labTemp);
            labTemp.Visible = false;
        }//addLabelTemp

        private void addTextTemp()
        {
            textTemp = new TextBox();
            textTemp.Text = "20.0";
            textTemp.Size = new System.Drawing.Size(30, 20);
            textTemp.Location = new System.Drawing.Point(width/4, height/2);
            //textTemp.Enabled = false;
            textTemp.KeyDown += new KeyEventHandler(textTemp_KeyDown);
            tabPage_heaters.Controls.Add(textTemp);
            textTemp.Visible = false;

        }//addTextTemp

        private void addThermometer()
        {
            pictureTherm = new PictureBox();
            pictureTherm.Image = System.Drawing.Image.FromFile(".\\ImagesDebug\\thermometer.jpg"); //TEMPORAL
            pictureTherm.Location = new System.Drawing.Point(width/8, height/16);
            pictureTherm.Size = new System.Drawing.Size(75, 84);
            tabPage_heaters.Controls.Add(pictureTherm);
        }

       //By Room
       private void addHeaterByRoom(List<HeaterCtrl> heaters)
        {
            for (int i = 0; i < heaters.Count; i++)
            {
                int id_room = heaters[i].getIdRoom();
                int id_heater = heaters[i].getId();
                DictionaryTabPageDevice.Add(id_heater,new TabPage("Heater "+id_heater));
                DictionaryTabControlDevice[id_room].Controls.Add(DictionaryTabPageDevice[id_heater]);
                addButtonByRoom(id_heater);
                addTrackBarByRoom(id_heater);
                addThermometerByRoom(id_heater);
                addLabelTempByRoom(id_heater);
                addTextTempByRoom(id_heater);
            }//for

        }//addHeaterByRoom

       private void addButtonByRoom(int id_heater)
        {
            dictionaryButtonSwitchByRoom.Add(id_heater, new Button());
            //To know which button calls the event
            inverseDictionaryButton.Add(dictionaryButtonSwitchByRoom[id_heater], id_heater);
            dictionaryButtonSwitchByRoom[id_heater].Text = "OFF";
            dictionaryButtonSwitchByRoom[id_heater].BackColor = System.Drawing.Color.Red;
            dictionaryButtonSwitchByRoom[id_heater].Location = new System.Drawing.Point(width / 2, height/6);
            DictionaryTabPageDevice[id_heater].Controls.Add(dictionaryButtonSwitchByRoom[id_heater]);            
            dictionaryButtonSwitchByRoom[id_heater].Click += new System.EventHandler(this.buttonSwitchByRoom_Click);
        }//addButtonByRoom    

        private void allChangeSwitch(bool status)
        {
            List<HeaterCtrl> h=gateway.getHeaters();
            for (int i = 0; i < h.Count; i++)
            {
               changeSwitch(h[i].getId(), status);
              
            }//for
        }//allChangeSwitch
        private void allChangeTextTemp(String temp)
        {
            List<HeaterCtrl> h = gateway.getHeaters();
            for (int i = 0; i < h.Count; i++)
            {
                if (h[i].status() == true)
                {
                    dictionaryTextTempByRoom[h[i].getId()].Text = temp;
                }
            }//for
            
        }

        private void allChangeTrackBar(int temp)
        {
            List<HeaterCtrl> h = gateway.getHeaters();
            for (int i = 0; i < h.Count; i++)
            {
                if (h[i].status() == true)
                {
                    dictionaryTrackBarByRoom[h[i].getId()].Value = temp;
                    dictionaryTextTempByRoom[h[i].getId()].Text = temp + ",0";
                }
            }//for          

        }//allChangeTrackBar

        private void changeSwitch(int id_heater, bool status)
        {
            if (status == true)
            {
                dictionaryButtonSwitchByRoom[id_heater].Text = "ON";
                dictionaryButtonSwitchByRoom[id_heater].BackColor = System.Drawing.Color.Green;
                dictionaryTrackBarByRoom[id_heater].Visible = true;
                dictionaryTextTempByRoom[id_heater].Visible = true;
                dictionaryLabelByRoom[id_heater].Visible = true;
            }// if
            else
            {
                dictionaryButtonSwitchByRoom[id_heater].Text = "OFF";
                dictionaryButtonSwitchByRoom[id_heater].BackColor = System.Drawing.Color.Red;
                dictionaryTrackBarByRoom[id_heater].Visible = false;
                dictionaryTextTempByRoom[id_heater].Visible = false;
                dictionaryLabelByRoom[id_heater].Visible = false;
            }// else

        }//changeSwitch

        private void addTrackBarByRoom(int id_heater)
        {
            dictionaryTrackBarByRoom.Add(id_heater,new TrackBar());
            inverseDictionaryTrackBar.Add(dictionaryTrackBarByRoom[id_heater], id_heater);
            dictionaryTrackBarByRoom[id_heater].Location = new System.Drawing.Point(width / 3, (height+50) / 3);
            dictionaryTrackBarByRoom[id_heater].Size = new System.Drawing.Size(width / 3, height / 16);
            dictionaryTrackBarByRoom[id_heater].Maximum = 40;
            dictionaryTrackBarByRoom[id_heater].Minimum = 0;
            dictionaryTrackBarByRoom[id_heater].Visible = false;
            DictionaryTabPageDevice[id_heater].Controls.Add(dictionaryTrackBarByRoom[id_heater]);            
            dictionaryTrackBarByRoom[id_heater].Scroll += new System.EventHandler(this.trackbarByRoom_Scroll);            
        }//addTrackBarByRoom

        private void addLabelTempByRoom(int id_heater)
        {
            dictionaryLabelByRoom.Add(id_heater, new Label());
            dictionaryLabelByRoom[id_heater].Size = new System.Drawing.Size(180, 20);
            dictionaryLabelByRoom[id_heater].Text = "Select temperature (Celsius): ";
            dictionaryLabelByRoom[id_heater].Location = new System.Drawing.Point((width - 30) / 3, (height) / 3);
            dictionaryLabelByRoom[id_heater].Visible = false;
            DictionaryTabPageDevice[id_heater].Controls.Add(dictionaryLabelByRoom[id_heater]);            
        }//addLabelTempByRoom

        private void addTextTempByRoom(int id_heater)
        {
            dictionaryTextTempByRoom.Add(id_heater, new TextBox());
            inverseDictionaryTextTemp.Add(dictionaryTextTempByRoom[id_heater], id_heater);
            dictionaryTextTempByRoom[id_heater].Text = "20,0";
            dictionaryTextTempByRoom[id_heater].Size = new System.Drawing.Size(30, 20);
            dictionaryTextTempByRoom[id_heater].Location = new System.Drawing.Point((width-25) / 4, (height + 50) / 3);
            //textTemp.Enabled = false;
            dictionaryTextTempByRoom[id_heater].KeyDown += new KeyEventHandler(textTempByRoom_KeyDown);
            DictionaryTabPageDevice[id_heater].Controls.Add(dictionaryTextTempByRoom[id_heater]);
            dictionaryTextTempByRoom[id_heater].Visible = false;

        }//addTextTempByRoom

        private void addThermometerByRoom(int id_heater)
        {
            PictureBox pictureThermByRoom = new PictureBox();
            pictureThermByRoom.Image = System.Drawing.Image.FromFile(".\\ImagesDebug\\thermometer.jpg"); //TEMPORAL
            pictureThermByRoom.Location = new System.Drawing.Point(width/8, height/16);
            pictureThermByRoom.Size = new System.Drawing.Size(75, 84);
            DictionaryTabPageDevice[id_heater].Controls.Add(pictureThermByRoom);            
        }//addThermometerByRoom
    }
}

