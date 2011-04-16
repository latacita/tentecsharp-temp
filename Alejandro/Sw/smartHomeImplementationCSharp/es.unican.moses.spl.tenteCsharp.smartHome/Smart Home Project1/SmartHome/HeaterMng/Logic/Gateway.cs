using System;
using System.Collections.Generic;

namespace SmartHome
{

    //=================================================================================================//
    // This class represent the central gateway of the Smart Home which process all commands           //
    // This file only contains the functionality related to the HeaterMng feature                      //
    //=================================================================================================//
    public partial class Gateway : ISubjectGatewayHeater
    {
        // heater collection
        protected List<HeaterCtrl> heaters = null;
        // thermometers collection
        protected List<Thermometer> thermometers = null;
        //Desired temperature
        protected double desiredTemperature = 20.0;
        //Observers
        ICollection<IGatewayGUIHeaterObserver> observersGatewayHeater = new LinkedList<IGatewayGUIHeaterObserver>();

        // Constructor
        public void initHeaterMng()
        {
            this.heaters = new List<HeaterCtrl>();
            this.thermometers = new List<Thermometer>();

        } // Gateway()


        public void heaterMng_addHeaterCtrl(HeaterCtrl h)
        {
            this.actuators.Add(h);
            this.heaters.Add(h);
        } // heaterMng_addHeaterCtrl

        public void heaterMng_addThermometer(Thermometer t)
        {
            this.sensors.Add(t);
            this.thermometers.Add(t);
        }// heaterMng_addThermometer


        public List<HeaterCtrl> heaterMng_getHeaters()
        {
            return heaters;
        }//heaterMng_getHeaters

        public List<Thermometer> heaterMng_getThermometers()
        {
            return thermometers;
        }//heaterMng_getThermometers

        // Helper methods
        public HeaterCtrl heaterMng_findHeater(int id)
        {
            for (int i = 0; i < heaters.Count; i++)
            {
                if (heaters[i].getId() == id)
                {
                    return heaters[i];
                }//if
            }//for
            return null;
        } // heaterMng_findHeater

        public List<HeaterCtrl> heaterMng_findHeatersByRoom(int id_room)
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

        public virtual void heaterMng_HeaterAdjustTemperature(int id, double temperature)
        {
            //bool result = false;

            HeaterCtrl heater = heaterMng_findHeater(id);
            Thermometer t = heaterMng_findThermometerByHeater(id);
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
                //result = true;
            } // if
            notifyadjustHeaterByRoomToObsevers(id, temperature);
        } // adjustTemparature

        public virtual void heaterMng_switchOnHeater(int id_heater)
        {
            heaterMng_HeaterAdjustTemperature(id_heater, desiredTemperature);
            notifySwitchOnByRoomToObsevers(id_heater);
        }//heaterMng_switchOnHeater

        public virtual void heaterMng_switchOffHeater(int id_heater)
        {
            heaterMng_findHeater(id_heater).switchOff();
            notifySwitchOffByRoomToObsevers(id_heater);
        }//heaterMng_switchOffHeater

        public virtual void heaterMng_allHeaterAdjustTemperature(double temperature)
        {
            for (int i = 0; i < heaters.Count; i++)
            {
                heaterAdjustTemperature(heaters[i].getId(), temperature);
            }//for
            notifyadjustAllHeaterToObsevers(temperature);
        }//heaterMng_allHeaterAdjustTemperature

        public virtual Thermometer heaterMng_findThermometerByHeater(int id_heater)
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

        private void heaterMng_allThermometerAdjustTemperature(double temperature)
        {
            for (int i = 0; i < thermometers.Count; i++)
            {
                thermometers[i].setValue(temperature);
            }//for
        }//heaterMng_allThermometerAdjustTemperature

        public void heaterMng_adjustThermometer(int id_heater, double temp)
        {
            Thermometer t = heaterMng_findThermometerByHeater(id_heater);
            HeaterCtrl h = heaterMng_findHeater(id_heater);
            t.setValue(temp);
            if (h.getStatus() == true)
            {
                if (h.getValue() == temp) h.setWork(false);
                else h.setWork(true);
            }
        }// heaterMng_adjustThermometer

        public virtual void heaterMng_allSwitchOffHeaters()
        {
            for (int i = 0; i < heaters.Count; i++)
            {
                heaterMng_switchOffHeater(heaters[i].getId());
            }//for
            notifySwitchOffAllHeaterToObsevers();
        }//heaterMng_allSwitchOffHeaters

        public virtual void heaterMng_allSwitchOnHeaters(double temperature)
        {
            for (int i = 0; i < heaters.Count; i++)
            {
                heaterMng_switchOnHeater(heaters[i].getId());
            }//for
            notifySwitchOnAllHeaterToObsevers();
        }//heaterMng_allSwitchOnHeaters

        public double heaterMng_getDesiredTemperature()
        {
            return desiredTemperature;
        }//heaterMng_getDesiredTemperature

        public void heaterMng_setDesiredTemperature(double temperature)
        {
            this.desiredTemperature = temperature;
        }//smartEnergyMng_setTemperature

        #region Subject-Observer Pattern

        /// <summary>
        ///     Register a new observer in the observer list
        /// </summary>
        /// <param name="obs">The observer to be registered</param>
        public void registerObserverHeater(IGatewayGUIHeaterObserver observer)
        {
            this.observersGatewayHeater.Add(observer);
        }

        /// <summary>
        ///     Notify that the value of the sensor has changed to all the observers registered
        ///     in the observer list
        /// </summary>
        protected void notifySwitchOnByRoomToObsevers(int id_heater)
        {
            foreach (IGatewayGUIHeaterObserver observer in observersGatewayHeater)
            {
                observer.switchOnByRoom(id_heater);
            } // foreach
        } // notifySwitchOnByRoomToObsevers

        protected void notifySwitchOffByRoomToObsevers(int id_heater)
        {
            foreach (IGatewayGUIHeaterObserver observer in observersGatewayHeater)
            {
                observer.switchOffByRoom(id_heater);
            } // foreach
        } // notifySwitchOffByRoomToObsevers

        protected void notifyadjustHeaterByRoomToObsevers(int id_heater, double temp)
        {
            foreach (IGatewayGUIHeaterObserver observer in observersGatewayHeater)
            {
                observer.adjustHeaterByRoom(id_heater, temp);
            } // foreach
        } // notifySwitchOffByRoomToObsevers

        protected void notifyadjustAllHeaterToObsevers(double temp)
        {
            foreach (IGatewayGUIHeaterObserver observer in observersGatewayHeater)
            {
                observer.allAdjustHeaters(temp);
            } // foreach
        } // notifySwitchOffByRoomToObsevers

        protected void notifySwitchOnAllHeaterToObsevers()
        {
            foreach (IGatewayGUIHeaterObserver observer in observersGatewayHeater)
            {
                observer.allSwitchOn();
            } // foreach
        } // notifySwitchOffByRoomToObsevers

        protected void notifySwitchOffAllHeaterToObsevers()
        {
            foreach (IGatewayGUIHeaterObserver observer in observersGatewayHeater)
            {
                observer.allSwitchOff();
            } // foreach
        } // notifySwitchOffByRoomToObsevers

        #endregion
    } // Gateway

} // namespace
