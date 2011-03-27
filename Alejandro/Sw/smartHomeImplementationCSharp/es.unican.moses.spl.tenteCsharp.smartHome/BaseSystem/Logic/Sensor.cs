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
        
        

        // Class constructor with device identifier 
        public Sensor(int id)
            :base(id)
        {
            this.id = id;
        } // Sensor(int)

        public Sensor(int id, int id_actuator)
            :base(id)
        {
            this.id = id;
            this.id_actuator = id_actuator;
        }

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

        // Class methods
        public virtual void setUrgentSignal()
        {
            gtw.emergence(this, this.deviceValue);
        }//setUrgentSignal

        public virtual void setIdActuator(int id_actuator)
        {
            this.id_actuator = id_actuator;
        }//setIdRoom

        public virtual int getIdActuator()
        {
            return id_actuator;
        }//roomId
    }
} // namespace SmartHome
