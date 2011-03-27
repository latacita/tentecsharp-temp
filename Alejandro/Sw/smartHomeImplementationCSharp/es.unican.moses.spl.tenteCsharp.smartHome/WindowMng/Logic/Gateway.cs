using System;
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

        public List<WindowCtrl> getWindows(){
            return windows;
        }//getWindows

        public List<WindowSensor> getSensors(){
            return windowsSensors;
        }//getSensors

        public void addWindowCtrl(WindowCtrl w)
        {
            this.actuators.Add(w);
            this.windows.Add(w);
        } // addWindowCtrl

        public void addWindowSensor(WindowSensor ws)
        {
            this.sensors.Add(ws);
            this.windowsSensors.Add(ws);
        }// addWindowSensor

        public void allAdjustWindows(int aperture)
        {
            for (int i = 0; i < windows.Count; i++)
            {
                //Change the window actuator
                windows[i].setValue(aperture);
                //Change the window sensor
                findWindowSensorByidWindow(windows[i].getId()).setValue(aperture);                
            }//for
        }//adjustAllWindows

        public WindowSensor findWindowSensorByidWindow(int id_window)
        {
            for (int i = 0; i < windowsSensors.Count; i++)
            {
                if (windowsSensors[i].getIdActuator() == id_window) return windowsSensors[i];
            }
            return null;
        }//findWindowSensorByidWindow

        public List<WindowCtrl> findWindowsCtrlByRoom(int id_room)
        {
            List<WindowCtrl> w=new List<WindowCtrl>();
            for (int i = 0; i < windows.Count; i++)
            {
                if (windows[i].getIdRoom() == id_room) w.Add(windows[i]);
                
            }//for
            return w;
        }//findWindowsCtrlByRoom

        public WindowCtrl findWindowCtrl(int id_window)
        {
            for (int i = 0; i < windows.Count; i++)
            {
                if (windows[i].getId() == id_window) return windows[i];

            }//for
            return null;

        }//findWindowCtrl

        public void ajustWindow(int id_window, int aperture)
        {
            //Change the window actuator
            findWindowCtrl(id_window).setValue(aperture);
            //Change the window sensor
            findWindowSensorByidWindow(id_window).setValue(aperture);
        }//ajustWindow
    }
}
