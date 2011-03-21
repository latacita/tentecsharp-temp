using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHome
{
    public abstract partial class Sensor
    {
        // Device identifier
        protected int id = 0;
        // Device currrent value
        protected double deviceValue = 0.0;
        // Gateway reference
        protected Gateway gtw = null;
        protected int roomId;
        
        // Class emprty constructor
        public Sensor()
        {
        } // Sensor()

        // Class constructor with device identifier 
        public Sensor(int id)
        {
            this.id = id;
        } // Sensor(int)

        public Sensor(int id, int roomId)
        {
            this.id = id;
            this.roomId = roomId;
        }

        // Getters and setters 
        public virtual void setId(int id)
        {
            this.id = id;
        } // setId

        public virtual int getId()
        {
            return this.id;
        } // getId

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

        public virtual void setIdRoom(int roomId)
        {
            this.roomId = roomId;
        }//setIdRoom

        public virtual int getIdRoom()
        {
            return roomId;
        }//roomId
    }
} // namespace SmartHome
