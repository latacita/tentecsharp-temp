//=====================================================================================================//
// Author: Pablo Sánchez (p.sanchez@unican.es) http://personales.unican.es/sanchezbp                   //
// Author: Elio López                                                                                  //
// Project: SmartHome Implementation using C# partial classes                                          // 
// File: InitialModel/Gateway.cs                                                                       //
// Papers: Fosd2010                                                                                    //
//=====================================================================================================//  

using System;
using System.Collections.Generic;

namespace SmartHome
{
    public partial class LightCtrl : Actuator
    {
        // Constant values for representing the switch on and off status
        protected const double ON  = 100.0;
        protected const double OFF = 0.0;

                // Constructor
        public LightCtrl() : base() { 
        } // LightCtrl

        public LightCtrl(int id) : base(id) {
            this.deviceValue = OFF;
        } // LightCtrl(int)

        // Class methods
        public void lightSwitch() {
            if (this.deviceValue == ON)
            {
                this.deviceValue = OFF;
            }
            else {
                this.deviceValue = ON;
            } // if      
        } // lightSwitch
        
    } // LightCtrl
} // nameSpace smartHome
