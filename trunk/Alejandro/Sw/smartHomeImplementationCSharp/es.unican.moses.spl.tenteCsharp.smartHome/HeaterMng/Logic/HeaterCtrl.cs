﻿using System;
using System.Collections.Generic;

namespace SmartHome
{
    /// <summary>
    ///     Class representing a heater device. Heaters are temperature controlling actuators,
    ///     which are able to heat and cool rooms. 
    /// </summary>
    public partial class HeaterCtrl : Actuator
    {
        // Maximum allowed temparature
        protected const double MAX_TEMP = 40.0;
        // Standard average temperature in earth surface
        protected const double DEFAULT_TEMP = 25.0;
        protected bool work=false;
      
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

        // Class methods
        public override void setValue(double value)
        {
            if ((0.0 <= value) && (value <= MAX_TEMP))
            {
                base.setValue(value);
            } // if
            // We notify the change to the observers
            this.notifyChangeToObsevers();
        } // setValue

        public override void switchOff()
        {
            base.switchOff();
            setWork(false);
            // We notify the change to the observers
            this.notifyChangeToObsevers();
        }//switchOff

        // Class methods
        public bool getWork(){
            return work;
        }// getWork

        public void setWork(bool work)
        {
            this.work = work;
            // We notify the change to the observers
            this.notifyChangeToObsevers();
        }// setWork


    } // LightCtrl

}

