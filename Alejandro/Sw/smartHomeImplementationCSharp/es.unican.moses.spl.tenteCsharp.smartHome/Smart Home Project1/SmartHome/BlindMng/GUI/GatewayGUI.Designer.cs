using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartHome
{
    //============================================================================================================================//
    // This class represents the visual interface for the Gateway                                                                 //
    // This file only contains the funcionality related to the BlindMng feature                                                   //
    //============================================================================================================================//
   
    public partial class GatewayGUI : IGatewayGUIBlindObserver
    {
        //Visual components
        protected TabPage tabPage_blind;
        protected TrackBar trackBar_apertureBlind;
        protected Label lab_apertureBlind;
        protected TextBox text_apertureBlind;
        protected PictureBox pict_blind;
        protected Dictionary<int, TrackBar> dictionaryTrackBarApertureBlindByRoom = new Dictionary<int, TrackBar>();
        protected Dictionary<TrackBar, int> inverseDictionaryTrackBarApertureBlind = new Dictionary<TrackBar, int>();
        protected Dictionary<int, Label> dictionaryLabelApertureBlindByRoom = new Dictionary<int, Label>();
        protected Dictionary<int, TextBox> dictionaryTextApertureBlindByRoom = new Dictionary<int, TextBox>();
        protected Dictionary<TextBox, int> inverseDictionaryTextApertureBlind = new Dictionary<TextBox, int>();

        /// <summary>
        /// Constructor to add the blindMng to GatewayGUI
        /// </summary>
        public void addBlindMng()
        {

            initblindMng();
            addBlindByRoom(gateway.blindMng_getBlinds());
            gateway.registerObserverBlind(this);
        }//addBlindMng

        protected void initblindMng()
        {
            //
            //TabPage
            //
            tabPage_blind = new TabPage();
            tabPage_blind.Text = "Blinds";
            tabPage_blind.BorderStyle = BorderStyle.Fixed3D;
            tabControl_main.Controls.Add(tabPage_blind);
            //
            //TrackBar
            //
            trackBar_apertureBlind = new TrackBar();
            trackBar_apertureBlind.Location = new System.Drawing.Point(width / 4, height / 2);
            trackBar_apertureBlind.Size = new System.Drawing.Size((width + 40) / 2, height / 16);
            trackBar_apertureBlind.Maximum = 100;
            trackBar_apertureBlind.Minimum = 0;
            tabPage_blind.Controls.Add(trackBar_apertureBlind);
            trackBar_apertureBlind.Visible = true;
            trackBar_apertureBlind.Scroll += new System.EventHandler(this.trackbar_Scroll_apertureBlind);
            //
            //Label
            //
            lab_apertureBlind = new Label();
            lab_apertureBlind.Size = new System.Drawing.Size(180, 20);
            lab_apertureBlind.Text = "Select aperture (0-100): ";
            lab_apertureBlind.Location = new System.Drawing.Point((width - 30) / 3, (height + 80) / 3);
            tabPage_blind.Controls.Add(lab_apertureBlind);
            lab_apertureBlind.Visible = true;
            //
            //TextTemp
            //
            text_apertureBlind = new TextBox();
            text_apertureBlind.Text = "0";
            text_apertureBlind.Size = new System.Drawing.Size(30, 20);
            text_apertureBlind.Location = new System.Drawing.Point(width / 6, height / 2);
            text_apertureBlind.KeyDown += new KeyEventHandler(textApertureBlind_KeyDown);
            tabPage_blind.Controls.Add(text_apertureBlind);
            text_apertureBlind.Visible = true;
            //
            //Image
            //
            pict_blind = new PictureBox();
            pict_blind.Image = System.Drawing.Image.FromFile("..\\..\\Images\\blind.jpg"); //TEMPORAL
            pict_blind.Location = new System.Drawing.Point((width + 45) / 3, height / 16);
            pict_blind.Size = new System.Drawing.Size(100, 94);
            tabPage_blind.Controls.Add(pict_blind);
        }

        protected void addBlindByRoom(List<BlindCtrl> blinds)
        {
            for (int i = 0; i < blinds.Count; i++)
            {
                int id_window = blinds[i].getIdWindow();
                int id_blind = blinds[i].getId();
                WindowCtrl w = gateway.windowMng_findWindowCtrl(id_window);
                int id_room = w.getIdRoom();
                DictionaryTabPageDevice.Add(id_blind, new TabPage("Blind " + id_blind));
                DictionaryTabControlDevice[id_room].Controls.Add(DictionaryTabPageDevice[id_blind]);
                initBlindMngByRoom(id_blind);
            }//for

        }//addblindByRoom

        protected void initBlindMngByRoom(int id_blind)
        {
            //
            //TrackBar
            //
            dictionaryTrackBarApertureBlindByRoom.Add(id_blind, new TrackBar());
            inverseDictionaryTrackBarApertureBlind.Add(dictionaryTrackBarApertureBlindByRoom[id_blind], id_blind);
            dictionaryTrackBarApertureBlindByRoom[id_blind].Location = new System.Drawing.Point(width / 4, (height + 50) / 3);
            dictionaryTrackBarApertureBlindByRoom[id_blind].Size = new System.Drawing.Size(width / 2, height / 16);
            dictionaryTrackBarApertureBlindByRoom[id_blind].Maximum = 100;
            dictionaryTrackBarApertureBlindByRoom[id_blind].Minimum = 0;
            dictionaryTrackBarApertureBlindByRoom[id_blind].Visible = true;
            DictionaryTabPageDevice[id_blind].Controls.Add(dictionaryTrackBarApertureBlindByRoom[id_blind]);
            dictionaryTrackBarApertureBlindByRoom[id_blind].Scroll += new System.EventHandler(this.trackbarApertureBlindByRoom_Scroll);
            //
            //Label
            //
            dictionaryLabelApertureBlindByRoom.Add(id_blind, new Label());
            dictionaryLabelApertureBlindByRoom[id_blind].Size = new System.Drawing.Size(180, 20);
            dictionaryLabelApertureBlindByRoom[id_blind].Text = "Select aperture (0-100): ";
            dictionaryLabelApertureBlindByRoom[id_blind].Location = new System.Drawing.Point((width - 30) / 3, (height) / 3);
            dictionaryLabelApertureBlindByRoom[id_blind].Visible = true;
            DictionaryTabPageDevice[id_blind].Controls.Add(dictionaryLabelApertureBlindByRoom[id_blind]);
            //
            //TextapertureBlind
            //
            dictionaryTextApertureBlindByRoom.Add(id_blind, new TextBox());
            inverseDictionaryTextApertureBlind.Add(dictionaryTextApertureBlindByRoom[id_blind], id_blind);
            dictionaryTextApertureBlindByRoom[id_blind].Text = "0";
            dictionaryTextApertureBlindByRoom[id_blind].Size = new System.Drawing.Size(30, 20);
            dictionaryTextApertureBlindByRoom[id_blind].Location = new System.Drawing.Point((width - 140) / 4, (height + 50) / 3);
            dictionaryTextApertureBlindByRoom[id_blind].KeyDown += new KeyEventHandler(textApertureBlindByRoom_KeyDown);
            DictionaryTabPageDevice[id_blind].Controls.Add(dictionaryTextApertureBlindByRoom[id_blind]);
            dictionaryTextApertureBlindByRoom[id_blind].Visible = true;
            //
            //Image
            //
            PictureBox pict_blind = new PictureBox();
            pict_blind.Image = System.Drawing.Image.FromFile("..\\..\\Images\\blind.jpg"); 
            pict_blind.Location = new System.Drawing.Point((width + 45) / 3, height / 16);
            pict_blind.Size = new System.Drawing.Size(100, 94);
            DictionaryTabPageDevice[id_blind].Controls.Add(pict_blind);
        }

        /// <summary>
        /// Method to adjust all visual blind components of a specific blind
        /// </summary>
        /// <param name="id_blind">Blind identifier</param>
        /// <param name="apertureBlind">Aperture</param>
        public void adjustBlindByRoom(int id_blind, int apertureBlind)
        {
            dictionaryTrackBarApertureBlindByRoom[id_blind].Value = apertureBlind;
            dictionaryTextApertureBlindByRoom[id_blind].Text = apertureBlind.ToString();

        }//adjustblind

        /// <summary>
        /// Method to adjust all visual blind components 
        /// </summary>
        /// <param name="apertureBlind">Aperture</param>
        public void adjustAllBlinds(int apertureBlind)
        {
            text_apertureBlind.Text = apertureBlind.ToString();
            trackBar_apertureBlind.Value = apertureBlind;
        }//adjustAllBlinds  
    }
}
