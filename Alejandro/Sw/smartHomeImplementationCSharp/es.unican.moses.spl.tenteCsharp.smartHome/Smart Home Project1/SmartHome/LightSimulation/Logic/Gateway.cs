using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
    //=================================================================================================//
    // This class represents the central gateway of the Smart Home which process all commands          //
    // This file only contains the functionality related to the LightSimulation                        //
    //=================================================================================================//
    public partial class Gateway : ISubjectGatewayLightSimulation
    {
        /// <summary>
        /// Atribute to indicate if the LightSimulation is on/off
        /// </summary>
        protected bool statusLigthSimulation = false;
        //Observer list
        ICollection<IGatewayGUILightSimulationObserver> observersGatewayLightSimulation = new LinkedList<IGatewayGUILightSimulationObserver>();

        /// <summary>
        /// Constructor to initialize the LightSimulation feature
        /// </summary>
        public void initLightSimulation()
        {
            time.registerObserver(this);
        }// initLightSimulation

        /// <summary>
        /// Method to switch on the lightSimulation
        /// </summary>
        public void lightSimulation_switchOn()
        {
            this.statusLigthSimulation = true;
            lightSimulation_checkTime(time.getHour(), time.getMinutes());
            notifySwitchOnLightSimulationToObsevers();
        }// lightSimulation_switchOn

        /// <summary>
        /// Method to switch off the blindSimulation
        /// </summary>
        public void lightSimulation_switchOff()
        {
            this.statusLigthSimulation = false;
            lightMng_allAdjustLights(0);
            notifySwitchOffLightSimulationToObsevers();
        }// lightSimulation_switchOff

        /// <summary>
        /// Method to check the current time, and if this time is in a moment when the home is empty, the
        /// LightSimulation will be off
        /// </summary>
        /// <param name="hour">Current hour</param>
        /// <param name="minutes">Current minutes</param>
        public void lightSimulation_checkTime(int hour, int minutes)
        {
            String t = hour.ToString() + "," + minutes.ToString();
            double time = Convert.ToDouble(t);
            if (statusLigthSimulation)
            {
                List<LightCtrl> l = lightMng_getLigths();
                if (time % 1 == 0)//everyHour
                {
                    for (int i = 0; i < l.Count; i++)
                    {
                        Random r = new Random(DateTime.Now.Millisecond);
                        int id = l[i].getId();
                        if (r.NextDouble() > 0.5)
                            lightMng_adjustLight(id, Convert.ToInt32(r.Next(0, 100)));
                        else
                            lightMng_adjustLight(id, 0);
                    }//for
                }//if
            }//if            
        }// lightSimulation_checkTime

        #region Subject-Observer Pattern
        /// <summary>
        ///     Register a new observer in the observer list
        /// </summary>
        /// <param name="obs">The observer to be registered</param>
        public void registerObserverLightSimulation(IGatewayGUILightSimulationObserver observer)
        {
            this.observersGatewayLightSimulation.Add(observer);
        }// registerObserverSmartEnergy

        protected void notifySwitchOnLightSimulationToObsevers()
        {
            foreach (IGatewayGUILightSimulationObserver observer in observersGatewayLight)
            {
                observer.switchOnLightSimulation();
            } // foreach
        } // notifySwitchOnSmartEnergyToObsevers

        protected void notifySwitchOffLightSimulationToObsevers()
        {
            foreach (IGatewayGUILightSimulationObserver observer in observersGatewayLight)
            {
                observer.switchOffLightSimulation();
            } // foreach
        } // notifySwitchOffSmartEnergyToObsevers
        #endregion
    }// Gateway
}// SmartHome
