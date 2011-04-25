using System;
using System.Collections.Generic;

namespace SmartHome
{
    //============================================================================================================================//
    // Class representing a heater device. Heaters are temperature controlling actuators, which are able to heat and cool rooms.  //
    //============================================================================================================================//
    
    public partial class HeaterCtrl : Actuator
    {
        // Maximum allowed temparature
        protected const double MAX_TEMP = 40.0;
        // Standard average temperature in earth surface
        protected const double DEFAULT_TEMP = 25.0;
        protected bool work = false;

        #region Constructor
        // Constructor
        public HeaterCtrl(int id)
            : base(id)
        {
            this.deviceValue = DEFAULT_TEMP;
        } // HeaterCtrl(int)

        public HeaterCtrl(int id, int id_room)
            : base(id, id_room)
        {
            this.deviceValue = DEFAULT_TEMP;

        }// HeaterCtrl(int, int)
        #endregion

        #region Getters and Setters
        
        public bool getWork()
        {
            return work;
        }// getWork

        public void setWork(bool work)
        {
            this.work = work;
            // We notify the change to the observers
            this.notifyChangeToObsevers();
        }// setWork

        public override void setValue(double value)
        {
            if ((0.0 <= value) && (value <= MAX_TEMP))
            {
                base.setValue(value);
            } // if
            // We notify the change to the observers
            this.notifyChangeToObsevers();
        } // setValue
        #endregion

       public override void switchOff()
        {
            base.switchOff();
            setWork(false);
            // We notify the change to the observers
            this.notifyChangeToObsevers();
        }//switchOff      

    } // LightCtrl
}// SmartHome

