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

        public List<HeaterCtrl> findHeatersByRoom(int id_room)
        {
            List<HeaterCtrl> h = new List<HeaterCtrl>();
            for (int i = 0; i < heaters.Count; i++)
            {
                if (heaters[i].getIdRoom() == id_room)
                {
                    h.Add(heaters[i]);
                }//if
            }//for
            return h;
        } // findHeaterByRoom

        // Class methods
        public virtual bool heaterAdjustTemparature(int id, double temperature)
        {
            bool result = false;

            HeaterCtrl heater = findHeater(id);
            Thermometer t = findThermometerByHeater(id);
            if (heater != null)
            {
                heater.switchOn();
                heater.setValue(temperature); 
                if (heater.getValue() != t.getValue())
                {
                    heater.setWork(true);
                                      
                }// if
                else
                {
                    heater.setWork(false);
                    //heater.switchOff();                   
                }// else
                result = true;
            } // if
            return result;
        } // adjustTemparature

        public virtual void allHeaterAdjustTemperature(double temperature)
        {
            for (int i = 0; i < heaters.Count; i++)
            {
                Thermometer t=findThermometerByHeater(heaters[i].getId());
                heaters[i].setValue(temperature);
                if (t.getValue() != temperature)
                {
                    heaters[i].switchOn();                    
                    heaters[i].setWork(true);
                }//if
                else
                {
                    heaters[i].setWork(false);
                    //heaters[i].switchOff();
                }//else
            }//for
            //allThermometerAdjustTemperature(temperature);
        }//allHeaterAdjustTemperature

        public virtual Thermometer findThermometerByHeater(int id_heater)
        {
            for (int i = 0; i < thermometers.Count; i++)
            {
                if (thermometers[i].getIdActuator() == id_heater)
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

        public void changeThermometer(int id_heater, double temp)
        {
            Thermometer t = findThermometerByHeater(id_heater);
            HeaterCtrl h = findHeater(id_heater);
            t.setValue(temp);
            if (h.status() == true)
            {
                if (h.getValue() == temp) h.setWork(false);
                else h.setWork(true);
            }
        }// changeThermometer
        public virtual void allSwitchOffHeaters()
        {
            for (int i = 0; i < heaters.Count; i++)
            {
                heaters[i].switchOff();
                heaters[i].setWork(false);
            }//for
        }//allSwitchOffHeaters
    } // Gateway

} // namespace
