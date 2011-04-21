using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHome
{
    //==========================================================================================================================//
    // This class represents a sensor device for a blind                                                                        //
    //==========================================================================================================================//
    public partial class BlindSensor : Sensor
    {

        #region Constructor
        /// <summary>
        /// Constructor with 1 parameter
        /// </summary>
        /// <param name="id">Unique identifier for the current sensor blind</param>
        public BlindSensor(int id)
            : base(id)
        {
            this.id = id;
        }//BlindSensor(int)

        /// <summary>
        /// Constructor with 2 parameter
        /// </summary>
        /// <param name="id">Unique identifier for the current sensor blind</param>
        /// <param name="id_blindCtrl">Identifier for the BlindCtrl that contains the current BlindSensor</param>
        public BlindSensor(int id, int id_blindCtrl)
            : base(id, id_blindCtrl)
        {
            this.id = id;
            this.id_actuator = id_blindCtrl;
        }// BlindSensor(id,id_blindCtrl)
        #endregion

    }// BlindSensor
}// SmartHome
