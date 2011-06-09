//=====================================================================================================//
// Author: Pablo Sánchez (p.sanchez@unican.es) http://personales.unican.es/sanchezbp                   //
// Author: Elio López                                                                                  //
// Project: SmartHome Implementation using C# partial classes                                          // 
// File: SmartEnergyMng/Gateway.cs                                                                     //
//=====================================================================================================//     

using System;
using System.Collections.Generic;

namespace SmartHome
{

    //=================================================================================================//
    // This class represent the central gateway of the Smart Home which process all commands           //
    // This file only contains the functionality related to the SmartEnergyMng feature                 //
    //=================================================================================================//

    public partial class Gateway
    {
        protected ThermometerCtrl outsideThermo;
        protected ThermometerCtrl indoorThermo;

        public void initSmartEnergyMng()
        {
            this.outsideThermo = new ThermometerCtrl();
            this.indoorThermo = new ThermometerCtrl();
        } // initSmartEnergyMng


        public bool smartEnergyAdjustTemparature(int id, double temperature) {

            bool result = false;

            double indoorTemperature  = this.indoorThermo.getTemperature();
            double outdoorTemperature = this.outsideThermo.getTemperature();

            // If the current indoor temperature is equal to the requested 
            // temperature, we close the windows so as to preserve the 
            // current indoor termperature
            if (temperature == indoorTemperature)
            {
                this.closeAllWindows();
            } 
            // The outdoor temperature is the desired one
            // We simply open the windows to make the indoor
            // temperature equal to the indoor one        
            else if (temperature == outdoorTemperature) {
                this.openAllWindows();
            } 
            // We need to cool the house and the outdoor temperature 
            // does not help. We switch on the heater and we close 
            // the windows
            else if ((temperature < indoorTemperature) && 
                     (temperature < outdoorTemperature)){

                this.heaterAdjustTemparature(id,temperature);
                this.closeAllWindows();
            }
            // We need to cool the house and the outdoor temperature 
            // helps us. We open the windows
            else if ((temperature < indoorTemperature) && 
                     (outdoorTemperature < temperature)){
                this.openAllWindows();
            } 
            // We need to heat the house and the outdoor temperature 
            // does not help us. We switch on the heater and we close 
            // the windows
            else if ((temperature > indoorTemperature) && 
                     (outdoorTemperature < temperature)){
                this.heaterAdjustTemparature(id,temperature);
                this.closeAllWindows();
            } 
            // We need to heat the house and the outdoor temperature 
            // helps us. We open the windows
            else if ((temperature > indoorTemperature) && 
                     (outdoorTemperature > temperature)){
                this.openAllWindows();
            } // if

            return result;
        
        } // smartEnergyAdjustTemparature

        // These methods are here just for debugging purposes
        public void setOutdoorTemperature(double temperature) {
            this.outsideThermo.setTemperature(temperature);
        } // setOutdoorTemperature

        public void setIndoorTemperature(double temperature)
        {
            this.indoorThermo.setTemperature(temperature);
        } // setIndoorTemperature

        public void windowSayHello(int id) {
            
            WindowCtrl w = findWindow(id);

            w.sayHello();
           
        } // windowSayHello


    } // Gateway

} // namespace