using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
    public partial class LigthSensor: Sensor
    {
          public LigthSensor(int id)
            :base(id)
        {
            this.id = id;
        }// LigthSensor(int)

        public LigthSensor(int id, int id_ligthCtrl)
            : base(id, id_ligthCtrl)
        {
            this.id = id;
            this.id_actuator = id_ligthCtrl;
        }// LigthSensor(id,id_ligthCtrl)
    }// LigthSensor
}// SmartHome

