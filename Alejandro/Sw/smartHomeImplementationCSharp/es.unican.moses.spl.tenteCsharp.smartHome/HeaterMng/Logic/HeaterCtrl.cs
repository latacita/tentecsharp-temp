using System;
using System.Collections.Generic;

namespace SmartHome
{
    public partial class HeaterCtrl : Actuator
    {
        // Maximum allowed temparature
        protected const double MAX_TEMP = 40.0;
        // Standard average temperature in earth surface
        protected const double DEFAULT_TEMP = 25.0;
      
        // Constructor
        public HeaterCtrl()
            : base()
        {
            this.deviceValue = DEFAULT_TEMP;
        } // HeaterCtrl

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
        } // setValue

        // Class methods
        
        public void sayHello()
        {
            System.Console.Out.WriteLine("I am the heater " + id + " and I am at " + deviceValue + " degrees");
        } // sayHello


    } // LightCtrl


}

