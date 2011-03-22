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
        // thermometers collection
        protected List<Thermometer> thermometers = null;

        // Constructor
        public void initHeaterMng()
        {
            this.heaters = new List<HeaterCtrl>();
            this.thermometers = new List<Thermometer>();
            
        } // Gateway()

        
        public void addHeaterCtrl(HeaterCtrl h)
        {
           this.actuators.Add(h);
           this.heaters.Add(h);           
        } // addHeaterCtrl

        public void addThermometer(Thermometer t)
        {
            this.sensors.Add(t);
            this.thermometers.Add(t);            
        }// addThermometer


        public List<HeaterCtrl> getHeaters()
        {
            return heaters;
        }//getHeaters
        // Helper methods
        protected HeaterCtrl findHeater(int id)
        {
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

        } // findHeater

        // Class methods
        public virtual bool heaterAdjustTemparature(int id, double temperature)
        {
            bool result = false;

            HeaterCtrl heater = findHeater(id);
            if (heater != null)
            {
                heater.switchOn();
                heater.setValue(temperature);                
                result = true;
            } // if

            return result;
        } // adjustTemparature

        public virtual void allHeaterAdjustTemperature(double temperature)
        {
            for (int i = 0; i < heaters.Count; i++)
            {
                heaters[i].switchOn();
                heaters[i].setValue(temperature);                
            }//for
            allThermometerAdjustTemperature(temperature);
        }//allHeaterAdjustTemperature

        private void allThermometerAdjustTemperature(double temperature)
        {
            for (int i = 0; i < thermometers.Count; i++)
            {
                thermometers[i].setValue(temperature);
            }//for
        }//allThermometerAdjustTemperature

        public virtual void allSwitchOffHeaters()
        {
            for (int i = 0; i < heaters.Count; i++)
            {
                heaters[i].switchOff();
            }//for
        }//allSwitchOffHeaters
    } // Gateway

} // namespace
