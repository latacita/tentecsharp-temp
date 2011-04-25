using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
    //=================================================================================================//
    // This class represents the central gateway of the Smart Home which process all commands          //
    // This file only contains the functionality related to the BlindSimulation                        //
    //=================================================================================================//

    public partial class Gateway : ISubjectGatewayBlindSimulation
    {
        /// <summary>
        /// Atribute to indicate if the BlindSimulation is on/off
        /// </summary>
        protected bool statusBlindSimulation = false;
        //Observer list
        ICollection<IGatewayGUIBlindSimulationObserver> observersGatewayBlindSimulation = new LinkedList<IGatewayGUIBlindSimulationObserver>();

        /// <summary>
        /// Constructor to initialize the BlindSimulation feature
        /// </summary>
        public void initBlindSimulation()
        {
            time.registerObserver(this);
        }// initBlindSimulation

        /// <summary>
        /// Method to switch on the blindSimulation
        /// </summary>
        public void blindSimulation_switchOn()
        {
            this.statusBlindSimulation = true;
            blindSimulation_checkTime(time.getHour(), time.getMinutes());
            notifySwitchOnBlindSimulationToObsevers();
        }//blindSimulation_switchOn

        /// <summary>
        /// Method to switch off the blindSimulation
        /// </summary>
        public void BlindSimulation_switchOff()
        {
            this.statusBlindSimulation = false;
            blindMng_allAdjustBlinds(0);
            notifySwitchOffBlindSimulationToObsevers();
        }//BlindSimulation_switchOff

        /// <summary>
        /// Method to check the current time, and if this time is in a moment when the home is empty, the
        /// blinSimulation will be off
        /// </summary>
        /// <param name="hour">Current hour</param>
        /// <param name="minutes">Current minutes</param>
        public void blindSimulation_checkTime(int hour, int minutes)
        {
            String t = hour.ToString() + "," + minutes.ToString();
            double time = Convert.ToDouble(t);
            if (statusBlindSimulation)
            {
                List<BlindCtrl> b = blindMng_getBlinds();
                if (time % 1 == 0)//everyHour
                {
                    for (int i = 0; i < b.Count; i++)
                    {
                        Random r = new Random(DateTime.Now.Millisecond);
                        int id = b[i].getId();
                        if (r.NextDouble() > 0.5)
                            blindMng_adjustBlind(id, Convert.ToInt32(r.Next(0, 100)));
                        else
                            blindMng_adjustBlind(id, 0);
                    }//for
                }//if
            }//if            
        }//blindSimulation_checkTime

        #region Subject-Observer Pattern
        /// <summary>
        ///     Register a new observer in the observer list
        /// </summary>
        /// <param name="obs">The observer to be registered</param>
        public void registerObserverBlindSimulation(IGatewayGUIBlindSimulationObserver observer)
        {
            this.observersGatewayBlindSimulation.Add(observer);
        }// registerObserverSmartEnergy

        protected void notifySwitchOnBlindSimulationToObsevers()
        {
            foreach (IGatewayGUIBlindSimulationObserver observer in observersGatewayBlind)
            {
                observer.switchOnBlindSimulation();
            } // foreach
        } // notifySwitchOnSmartEnergyToObsevers

        protected void notifySwitchOffBlindSimulationToObsevers()
        {
            foreach (IGatewayGUIBlindSimulationObserver observer in observersGatewayBlind)
            {
                observer.switchOffBlindSimulation();
            } // foreach
        } // notifySwitchOffSmartEnergyToObsevers
        #endregion
    }// Gateway
}// SmartHome
