//=====================================================================================================//
// Author: Pablo Sánchez (p.sanchez@unican.es) http://personales.unican.es/sanchezbp                   //
// Author: Elio López                                                                                  //
// Project: SmartHome Implementation using C# partial classes                                          // 
// File: SamartEnergyMng/Gateway.cs                                                                    //
//=====================================================================================================//     


using System;
using System.Collections.Generic;

namespace SmartHome
{
    public partial class ThermometerCtrl : Sensor
    {

         // Standard average temperature in earth surface
        protected const double DEFAULT_TEMP = 25.0;
        
        public ThermometerCtrl() : base() { 
            this.deviceValue = DEFAULT_TEMP;
        } // ThermometerCtrl()

        public ThermometerCtrl(int id) : base(id) {
            this.deviceValue = DEFAULT_TEMP;
        } // ThermometerCtrl(int)

        public double getTemperature() {
            return this.deviceValue;
        } // getTemperature

        // NOTE: This method is here for debugging purposes. It should be removed in the release version
        public void setTemperature(double t) {
            this.deviceValue = t;
        } // if

    } // setTemperature
   
}
