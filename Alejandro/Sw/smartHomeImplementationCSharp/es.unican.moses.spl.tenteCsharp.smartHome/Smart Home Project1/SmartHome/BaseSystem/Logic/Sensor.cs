using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHome
{
    //=================================================================================================//
    // This class is an abstract class that represents the common supertype for all sensors             //
    //=================================================================================================//
    public abstract partial class Sensor : Device
    {

        // Actuator id
        protected int id_actuator;

        #region Constructors
        /// <summary>
        ///  Class  constructor accepting a device id as input parameter 
        /// </summary>
        /// <param name="id">Unique identifier for the sensor. All devices in the house
        /// are uniquely identified by an id</param>
        public Sensor(int id)
            : base(id)
        {
            this.id = id;
        } // Sensor(int)

        /// <summary>
        /// Class constructor accepting a device id and id_actuator as input parameters
        /// </summary>
        /// <param name="id">Unique identifier for the sensor</param>
        /// <param name="id_actuator">Identifier for the actuator that this sensor is related</param>
        public Sensor(int id, int id_actuator)
            : base(id)
        {
            this.id = id;
            this.id_actuator = id_actuator;
        } // Sensor(int, int)
        #endregion

        #region Getters and Setters

        public virtual void setIdActuator(int id_actuator)
        {
            this.id_actuator = id_actuator;
        }//setIdRoom

        public virtual int getIdActuator()
        {
            return id_actuator;
        }//roomId
        #endregion
       
    } // Sensor
} // namespace SmartHome
