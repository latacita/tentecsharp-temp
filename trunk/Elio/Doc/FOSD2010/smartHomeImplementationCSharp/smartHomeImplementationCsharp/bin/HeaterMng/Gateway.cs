//=====================================================================================================//
// Author: Pablo Sánchez (p.sanchez@unican.es) http://personales.unican.es/sanchezbp                   //
// Author: Elio López                                                                                  //
// Project: SmartHome Implementation using C# partial classes                                          // 
// File: Heater/Gateway.cs                                                                             //
// Papers: Fosd2010                                                                                    //
//=====================================================================================================//     

using System;
using System.Collections.Generic;

namespace SmartHome
{

    //=================================================================================================//
    // This class represent the central gateway of the Smart Home which process all commands           //
    // This file only contains the functionality related to the HeaterMng feature                      //
    //=================================================================================================//
    public partial class Gateway
    {
        // heater collection
        protected List<HeaterCtrl> heaters = null;

        // Constructor
        public void initHeaterMng()
        {
            this.heaters = new List<HeaterCtrl>();
        } // Gateway()

        // Attributes manipulators
        public void addHeaterCtrl(HeaterCtrl h)
        {
            this.actuators.Add(h);
            this.heaters.Add(h);
        } // addHeaterCtrl

        // Helper methods
        protected HeaterCtrl findHeater(int id) {
            HeaterCtrl heater = null;

            List<HeaterCtrl>.Enumerator it = heaters.GetEnumerator();

            while ((it.MoveNext() == true) && (heater == null))
            {
                if (it.Current.getId() == id)
                {
                    heater = it.Current;
                } // if
            } //while

            return heater;

        } // findWindow

        // Class methods
        public virtual bool heaterAdjustTemparature(int id, double temperature) {
            bool result = false;

            HeaterCtrl heater = findHeater(id);
            if (heater != null)
            {
                heater.setValue(temperature);
                result = true;
            } // if

            return result;
        } // adjustTemparature


    } // Gateway

} // namespace