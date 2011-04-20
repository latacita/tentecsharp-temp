using System;
using System.Collections.Generic;

namespace SmartHome
{

    //=================================================================================================//
    // This class is an abstract class the represents the common supertype for all actuators           //
    //=================================================================================================//
    public abstract partial class Actuator : Device
    {

        /// <summary>
        /// Id of the room where is installed the Actuator
        /// </summary> 
        protected int id_room;

        #region Constructors
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
        #endregion

        #region Getters and Setters
        public virtual int getIdRoom()
        {
            return this.id_room;
        }//getIdRoom

        public virtual void setIdRoom(int id_room)
        {
            this.id_room = id_room;
        }
        #endregion

        /// <summary>
        /// Method to switch On the current Actuator
        /// </summary>
        public virtual void switchOn()
        {
            this.setStatus(true);
        }// switchOn

        /// <summary>
        /// Method to switch Off the current Actuator
        /// </summary>
        public virtual void switchOff()
        {
            this.setStatus(false);
        }// switchOff       
    } // Actuator
} // SmartHome

