//=====================================================================================================//
// Author: Pablo Sánchez (p.sanchez@unican.es) http://personales.unican.es/sanchezbp                   //
// Author: Elio López                                                                                  //
// Project: SmartHome Implementation using C# partial classes                                          // 
// File: LightMng/Gateway.cs                                                                           //
//=====================================================================================================//     

using System;
using System.Collections.Generic;

namespace SmartHome
{

    //=================================================================================================//
    // This class represent the central gateway of the Smart Home which process all commands           //
    // This file only contains the functionality related to the LightMng feature                       //
    //=================================================================================================//
    public partial class Gateway 
    {
        // lights collection
        protected List<LightCtrl> lights = null;

        // Constructor
        public void initLightMng()
        {
            this.lights = new List<LightCtrl>();
        } // Gateway()

        // Attributes manipulators
        public void addLightCtrl(LightCtrl l) {
            this.actuators.Add(l);
            this.lights.Add(l);
        } // addSensor


        // Class methods
        public bool switchLight(int id) {

            bool result = false;
            LightCtrl light = null;

            List<LightCtrl>.Enumerator it = lights.GetEnumerator();

            while ((it.MoveNext() == true) && (light == null)) {
                if (it.Current.getId() == id) {
                    light = it.Current;
                } // if
            } //while

            if (light != null) {
                light.lightSwitch();
                result = true;
            } // if

            return result;
        } // switchLight

        
    } // Gateway

} // namespace