using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHome
{
    /// <summary>
    /// 
    /// </summary>
    public partial class WindowSensor: Sensor
    {
        public WindowSensor(int id)
            :base(id)
        {
            this.id = id;
        }//WindowSensor(int)

        public WindowSensor(int id, int id_windowCtrl)
            : base(id, id_windowCtrl)
        {
            this.id = id;
            this.id_actuator = id_windowCtrl;
        }// WindowSensor(id,id_windowCtrl)




    }// WindowSensor
}// SmartHome
