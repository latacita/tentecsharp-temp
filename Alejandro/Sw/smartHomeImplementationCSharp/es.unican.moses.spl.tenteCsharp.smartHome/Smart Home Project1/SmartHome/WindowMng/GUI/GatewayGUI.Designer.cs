using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartHome
{

    //============================================================================================================================//
    // This class represents the visual interface for the Gateway                                                                 //
    // This file only contains the funcionality related to the WindowMng feature                                                  //
    //============================================================================================================================//

    public partial class GatewayGUI : IGatewayGUIWindowObserver
    {
        //Visual components
        protected TabPage tabPage_window;
        protected TrackBar trackBar_aperture;
        protected Label lab_aperture;
        protected TextBox text_aperture;
        protected PictureBox pict_window;
        //Dictionaries
        protected Dictionary<int, TrackBar> dictionaryTrackBarApertureByRoom = new Dictionary<int, TrackBar>();
        protected Dictionary<TrackBar, int> inverseDictionaryTrackBarAperture = new Dictionary<TrackBar, int>();
        protected Dictionary<int, Label> dictionaryLabelApertureByRoom = new Dictionary<int, Label>();
        protected Dictionary<int, TextBox> dictionaryTextApertureByRoom = new Dictionary<int, TextBox>();
        protected Dictionary<TextBox, int> inverseDictionaryTextAperture = new Dictionary<TextBox, int>();

        /// <summary>
        /// Constructor to add the WindowMng to GatewayGUI
        /// </summary>
        public void addWindowMng()
        {
            initWindowMng();
            addWindowByRoom(gateway.windowMng_getWindows());
            gateway.registerObserverWindow(this);
        }//addWindowMng

        public void initWindowMng()
        {
            //
            //TabPage
            //
            tabPage_window = new TabPage();
            tabPage_window.Text = "Windows";
            tabPage_window.BorderStyle = BorderStyle.Fixed3D;
            tabControl_main.Controls.Add(tabPage_window);
            //
            //TrackBar
            //
            trackBar_aperture = new TrackBar();
            trackBar_aperture.Location = new System.Drawing.Point(width / 4, height / 2);
            trackBar_aperture.Size = new System.Drawing.Size((width + 40) / 2, height / 16);
            trackBar_aperture.Maximum = 100;
            trackBar_aperture.Minimum = 0;
            tabPage_window.Controls.Add(trackBar_aperture);
            trackBar_aperture.Visible = true;
            trackBar_aperture.Scroll += new System.EventHandler(this.trackbar_Scroll_aperture);
            //
            //Label
            //
            lab_aperture = new Label();
            lab_aperture.Size = new System.Drawing.Size(180, 20);
            lab_aperture.Text = "Select aperture (0-100 degrees): ";
            lab_aperture.Location = new System.Drawing.Point((width - 30) / 3, (height + 80) / 3);
            tabPage_window.Controls.Add(lab_aperture);
            lab_aperture.Visible = true;
            //
            //TextTemp
            //
            text_aperture = new TextBox();
            text_aperture.Text = "0";
            text_aperture.Size = new System.Drawing.Size(30, 20);
            text_aperture.Location = new System.Drawing.Point(width / 6, height / 2);
            text_aperture.KeyDown += new KeyEventHandler(textAperture_KeyDown);
            tabPage_window.Controls.Add(text_aperture);
            text_aperture.Visible = true;
            //
            //Image
            //
            pict_window = new PictureBox();
            pict_window.Image = System.Drawing.Image.FromFile("..\\..\\Images\\window.jpg"); //TEMPORAL
            pict_window.Location = new System.Drawing.Point((width + 45) / 3, height / 16);
            pict_window.Size = new System.Drawing.Size(100, 94);
            tabPage_window.Controls.Add(pict_window);
        }

        private void addWindowByRoom(List<WindowCtrl> windows)
        {
            for (int i = 0; i < windows.Count; i++)
            {
                int id_room = windows[i].getIdRoom();
                int id_window = windows[i].getId();
                DictionaryTabPageDevice.Add(id_window, new TabPage("Window " + id_window));
                DictionaryTabControlDevice[id_room].Controls.Add(DictionaryTabPageDevice[id_window]);
                initWindowMngByRoom(id_window);
            }//for

        }//addWindowByRoom

        private void initWindowMngByRoom(int id_window)
        {
            //
            //TrackBar
            //
            dictionaryTrackBarApertureByRoom.Add(id_window, new TrackBar());
            inverseDictionaryTrackBarAperture.Add(dictionaryTrackBarApertureByRoom[id_window], id_window);
            dictionaryTrackBarApertureByRoom[id_window].Location = new System.Drawing.Point(width / 4, (height + 50) / 3);
            dictionaryTrackBarApertureByRoom[id_window].Size = new System.Drawing.Size(width / 2, height / 16);
            dictionaryTrackBarApertureByRoom[id_window].Maximum = 100;
            dictionaryTrackBarApertureByRoom[id_window].Minimum = 0;
            dictionaryTrackBarApertureByRoom[id_window].Visible = true;
            DictionaryTabPageDevice[id_window].Controls.Add(dictionaryTrackBarApertureByRoom[id_window]);
            dictionaryTrackBarApertureByRoom[id_window].Scroll += new System.EventHandler(this.trackbarApertureByRoom_Scroll);
            //
            //Label
            //
            dictionaryLabelApertureByRoom.Add(id_window, new Label());
            dictionaryLabelApertureByRoom[id_window].Size = new System.Drawing.Size(180, 20);
            dictionaryLabelApertureByRoom[id_window].Text = "Select aperture (0-100 degrees): ";
            dictionaryLabelApertureByRoom[id_window].Location = new System.Drawing.Point((width - 30) / 3, (height) / 3);
            dictionaryLabelApertureByRoom[id_window].Visible = true;
            DictionaryTabPageDevice[id_window].Controls.Add(dictionaryLabelApertureByRoom[id_window]);
            //
            //TextAperture
            //
            dictionaryTextApertureByRoom.Add(id_window, new TextBox());
            inverseDictionaryTextAperture.Add(dictionaryTextApertureByRoom[id_window], id_window);
            dictionaryTextApertureByRoom[id_window].Text = "0";
            dictionaryTextApertureByRoom[id_window].Size = new System.Drawing.Size(30, 20);
            dictionaryTextApertureByRoom[id_window].Location = new System.Drawing.Point((width - 140) / 4, (height + 50) / 3);
            dictionaryTextApertureByRoom[id_window].KeyDown += new KeyEventHandler(textApertureByRoom_KeyDown);
            DictionaryTabPageDevice[id_window].Controls.Add(dictionaryTextApertureByRoom[id_window]);
            dictionaryTextApertureByRoom[id_window].Visible = true;
            //
            //Image
            //
            PictureBox pict_window = new PictureBox();
            pict_window.Image = System.Drawing.Image.FromFile("..\\..\\Images\\window.jpg"); //TEMPORAL
            pict_window.Location = new System.Drawing.Point((width + 45) / 3, height / 16);
            pict_window.Size = new System.Drawing.Size(100, 94);
            DictionaryTabPageDevice[id_window].Controls.Add(pict_window);
        }

        public void adjustWindowByRoom(int id_window, int aperture)
        {
            dictionaryTrackBarApertureByRoom[id_window].Value = aperture;
            dictionaryTextApertureByRoom[id_window].Text = aperture.ToString();

        }//adjustWindow

        public void adjustAllWindow(int aperture)
        {
            text_aperture.Text = aperture.ToString();
            trackBar_aperture.Value = aperture;
        }//adjustAllWindow  
    }// GatewayGUI
}// SmartHome
