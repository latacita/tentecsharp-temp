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
        public HeaterCtrl findHeater(int id)
        {            
            for (int i = 0; i < heaters.Count; i++)
            {
                if (heaters[i].getId() == id){
                    return heaters[i];
                }//if
            }//for
            return null;
        } // findHeater

        // Class methods
        public virtual bool heaterAdjustTemparature(int id, double temperature)
        {
            bool result = false;

            HeaterCtrl heater = findHeater(id);
            Thermometer t = findThermometerByRoom(heater.getIdRoom());
            if (heater != null)
            {
                if (heater.getValue() != t.getValue())
                {
                    heater.switchOn();
                    heater.setValue(temperature);
                    t.setValue(temperature);
                }// if
                else
                {
                    heater.switchOff();                   
                }// else
                result = true;
            } // if
            return result;
        } // adjustTemparature

        public virtual void allHeaterAdjustTemperature(double temperature)
        {
            for (int i = 0; i < heaters.Count; i++)
            {
                Thermometer t=findThermometerByRoom(heaters[i].getIdRoom());
                if (t.getValue() != temperature)
                {
                    heaters[i].switchOn();
                    heaters[i].setValue(temperature);
                    t.setValue(temperature);
                }//if
                else
                {
                    heaters[i].switchOff();
                }//else
            }//for
            allThermometerAdjustTemperature(temperature);
        }//allHeaterAdjustTemperature

        public virtual Thermometer findThermometerByRoom(int id_room)
        {
            for (int i = 0; i < thermometers.Count; i++)
            {
                if (thermometers[i].getIdRoom() == id_room)
                {
                    return thermometers[i];
                }//if
            }//for
            return null;
        }//findThermometerByRoom

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
