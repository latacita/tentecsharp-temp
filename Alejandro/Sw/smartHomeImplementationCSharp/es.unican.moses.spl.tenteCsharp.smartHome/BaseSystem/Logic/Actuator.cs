using System;
using System.Collections.Generic;

namespace SmartHome
{

    //=================================================================================================//
    // This class is an abstract class the represents the common supertype for all actuators           //
    //=================================================================================================//
    public abstract partial class Actuator
    {
        // Device identifier
        protected int id = 0;
        protected double deviceValue = 0.0;
        // Id of the room where is installed the Actuator
        protected int id_room;
        //switchOn, default value is false
        protected bool on = false;
       
        public Actuator()
        {
        } // Actuator()

        public Actuator(int id)
        {
            this.id = id;
        } // Actuator(int)

        public Actuator(int id, int id_room)
        {
            this.id = id;
            this.id_room = id_room;
        }// Actuator(int, int)

        public virtual void setId(int id)
        {
            this.id = id;
        } // setId
        
        public virtual int getId()
        {
            return this.id;
        } // getId

        public virtual int getIdRoom()
        {
            return this.id_room;
        }//getIdRoom

        public virtual void setIdRoom(int id_room)
        {
            this.id_room = id_room;
        }

        public virtual void setValue(double value)
        {
            this.deviceValue = value;
        } // setValue

        public virtual double getValue()
        {
            return deviceValue;
        }//getValue

        public virtual void switchOn()
        {
            this.on = true;
        }// switchOn

        public virtual void switchOff()
        {
            this.on = false;
        }// switchOff
        public virtual bool status()
        {
            return on;
        }
    } // Actuator

} // namespace SmartHome

