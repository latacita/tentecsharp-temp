using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHome
{
    public abstract partial class Sensor: Device
    {
        // Device currrent value
        protected double deviceValue = 0.0;
        // Gateway reference
        protected Gateway gtw = null;
        // Actuator id
        protected int id_actuator;

        #region Constructors
        /// <summary>
        ///  Class  constructor accepting a device id as input parameter 
        /// </summary>
        /// <param name="id">Unique identifier for the sensor. All devices in the house
        /// are uniquely identified by an id</param>
        public Sensor(int id)  :base(id)
        {
            this.id = id;
        } // Sensor(int)

        public Sensor(int id, int id_actuator)
            :base(id)
        {
            this.id = id;
            this.id_actuator = id_actuator;
        }
        #endregion

        #region Getters and Setters

        /// <summary>
        ///  Set method for the sensor. In a real setting, *sensors are never set values*,
        ///  but this method has been included here for simulation purposes, as we need 
        ///  to alter manually the values perceived by sensors to check how the house works
        /// </summary>
        /// <param name="value">The value to be set in this sensors</param>
        public virtual void setValue(double value)
        {
            this.deviceValue=value;
        }//setValue

        public virtual double getValue()
        {
            return this.deviceValue;
        }//getValue

        public virtual void setGateway(Gateway gtw)
        {
            this.gtw = gtw;
        }//setGateway

        public virtual void setIdActuator(int id_actuator)
        {
            this.id_actuator = id_actuator;
        }//setIdRoom

        public virtual int getIdActuator()
        {
            return id_actuator;
        }//roomId

        #endregion


        /// <summary>
        ///   NOTA(Pablo): ¿Estos métodos los estamos usando para algo, o son arrastrados de 
        ///   la versión de la casa para el artículo del FOSD 2010?
        /// </summary>
        public virtual void sentUrgentSignal()
        {
            gtw.emergence(this, this.deviceValue);
        }//setUrgentSignal


        #region ISubject<ISensorObserver> Members

   

        #endregion
    } // Sensor
} // namespace SmartHome
