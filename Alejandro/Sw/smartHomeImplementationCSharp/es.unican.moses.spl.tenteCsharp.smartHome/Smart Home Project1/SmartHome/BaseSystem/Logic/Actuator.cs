using System;
using System.Collections.Generic;

namespace SmartHome
{

    //=================================================================================================//
    // This class is an abstract class the represents the common supertype for all actuators           //
    //=================================================================================================//
    public abstract partial class Actuator : Device
    {

        // Id of the room where is installed the Actuator
        protected int id_room;
        

        //Constructor
        public Actuator(int id)
            : base(id)
        {
            this.id = id;
        } // Actuator(int)

        public Actuator(int id, int id_room)
            : base(id)
        {
            //this.id = id;
            this.id_room = id_room;
        }// Actuator(int, int)

        public virtual int getIdRoom()
        {
            return this.id_room;
        }//getIdRoom

        public virtual void setIdRoom(int id_room)
        {
            this.id_room = id_room;
        }

        public virtual void switchOn()
        {
            this.setStatus(true);
        }// switchOn

        public virtual void switchOff()
        {
            this.setStatus(false);
        }// switchOff       
    } // Actuator
} // namespace SmartHome

