using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHome
{
    //=======================================================================================================================//
    //This class represents a sensor device for a window                                                                     //
    //=======================================================================================================================//
    public partial class WindowSensor : Sensor
    {
        #region Constructors
        public WindowSensor(int id)
            : base(id)
        {
            this.id = id;
        }//WindowSensor(int)

        public WindowSensor(int id, int id_windowCtrl)
            : base(id, id_windowCtrl)
        {
            this.id = id;
            this.id_actuator = id_windowCtrl;
        }// WindowSensor(id,id_windowCtrl)
        #endregion
    }// WindowSensor
}// SmartHome
