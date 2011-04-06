using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHome
{
    /// <summary>
    /// 
    /// </summary>
    public partial class BlindSensor: Sensor
    {
        public BlindSensor(int id)
            :base(id)
        {
            this.id = id;
        }//BlindSensor(int)

        public BlindSensor(int id, int id_blindCtrl)
            : base(id, id_blindCtrl)
        {
            this.id = id;
            this.id_actuator = id_blindCtrl;
        }// BlindSensor(id,id_blindCtrl)
    }// BlindSensor
}// SmartHome
