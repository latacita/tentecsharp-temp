﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
    public partial class Gateway
    {
        // WindowCtrl collection
        protected List<WindowCtrl> windows = null;
        // WindowSensor collection
        protected List<WindowSensor> windowsSensors = null;

        //Constructor
        public void initWindowMng()
        {
            this.windows = new List<WindowCtrl>();
            this.windowsSensors = new List<WindowSensor>();
        }//initWindowMng

        public List<WindowCtrl> windowMng_getWindows(){
            return windows;
        }//windowMng_getWindows

        public List<WindowSensor> windowMng_getWindowsSensors(){
            return windowsSensors;
        }//windowMng_getWindowsSensors

        public void windowMng_addWindowCtrl(WindowCtrl w)
        {
            this.actuators.Add(w);
            this.windows.Add(w);
        } // windowMng_addWindowCtrl

        public void windowMng_addWindowSensor(WindowSensor ws)
        {
            this.sensors.Add(ws);
            this.windowsSensors.Add(ws);
        }// windowMng_addWindowSensor

        public void windowMng_allAdjustWindows(int aperture)
        {
            for (int i = 0; i < windows.Count; i++)
            {
                //Change the window actuator
                windows[i].setValue(aperture);
                //Change the window sensor
                windowMng_findWindowSensorByidWindow(windows[i].getId()).setValue(aperture);                
            }//for
        }//adjustAllWindows

        public WindowSensor windowMng_findWindowSensorByidWindow(int id_window)
        {
            for (int i = 0; i < windowsSensors.Count; i++)
            {
                if (windowsSensors[i].getIdActuator() == id_window) return windowsSensors[i];
            }
            return null;
        }//windowMng_findWindowSensorByidWindow

        public List<WindowCtrl> windowMng_findWindowsCtrlByRoom(int id_room)
        {
            List<WindowCtrl> w=new List<WindowCtrl>();
            for (int i = 0; i < windows.Count; i++)
            {
                if (windows[i].getIdRoom() == id_room) w.Add(windows[i]);
                
            }//for
            return w;
        }//windowMng_findWindowsCtrlByRoom

        public WindowCtrl windowMng_findWindowCtrl(int id_window)
        {
            for (int i = 0; i < windows.Count; i++)
            {
                if (windows[i].getId() == id_window) return windows[i];

            }//for
            return null;

        }//windowMng_findWindowCtrl

        public void windowMng_adjustWindow(int id_window, int aperture)
        {
            //Change the window actuator
            windowMng_findWindowCtrl(id_window).setValue(aperture);
            //Change the window sensor
            windowMng_findWindowSensorByidWindow(id_window).setValue(aperture);
        }//windowMng_adjustWindow
    }
}
