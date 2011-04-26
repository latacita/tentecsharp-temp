using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
    //=======================================================================================================================//
    //This class represents a sensor device for a Light                                                                      //
    //=======================================================================================================================//
    public partial class LightSensor : Sensor
    {
        public LightSensor(int id)
            : base(id)
        {
            this.id = id;
        }// LightSensor(int)

        public LightSensor(int id, int id_ligthCtrl)
            : base(id, id_ligthCtrl)
        {
            this.id = id;
            this.id_actuator = id_ligthCtrl;
        }// LightSensor(id,id_ligthCtrl)
    }// LightSensor
}// SmartHome

