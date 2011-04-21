using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
    //=================================================================================================//
    // This class represents the central gateway of the Smart Home which process all commands          //
    // This file only contains the functionality related to the BlindMng feature                       //
    //=================================================================================================//

    public partial class Gateway : ISubjectGatewayBlind
    {
        // BlindCtrl collection
        protected List<BlindCtrl> blinds = null;
        // BlindSensor collection
        protected List<BlindSensor> blindsSensors = null;
        //List of observers
        ICollection<IGatewayGUIBlindObserver> observersGatewayBlind = new LinkedList<IGatewayGUIBlindObserver>();

        /// <summary>
        /// Constructor to initialize the BlindMng feature
        /// </summary>
        public void initBlindMng()
        {
            this.blinds = new List<BlindCtrl>();
            this.blindsSensors = new List<BlindSensor>();
        }//initBlindMng

        #region Getters and Setters
        public List<BlindCtrl> blindMng_getBlinds()
        {
            return blinds;
        }//blindMng_getBlinds

        public List<BlindSensor> blindMng_getBlindsSensors()
        {
            return blindsSensors;
        }//blindMng_getBlindsSensors
        #endregion

        /// <summary>
        /// Add a new blind actuator in the gateway
        /// </summary>
        /// <param name="b">A new BlindCtrl</param>
        public void blindMng_addBlindCtrl(BlindCtrl b)
        {
            this.actuators.Add(b);
            this.blinds.Add(b);
        } // blindMng_addBlindCtrl

        /// <summary>
        /// Add a new blind sensor in the gateway
        /// </summary>
        /// <param name="bs">A new BlindSensor</param>
        public void blindMng_addBlindSensor(BlindSensor bs)
        {
            this.sensors.Add(bs);
            this.blindsSensors.Add(bs);
        }// blindMng_addBlindSensor(BlindSensor)

        /// <summary>
        /// Adjust all blinds with a specific aperture
        /// </summary>
        /// <param name="aperture">Number of degerees(0-100) to open/close all blinds</param>
        public void blindMng_allAdjustBlinds(int aperture)
        {
            for (int i = 0; i < blinds.Count; i++)
            {
                //Change the Blind actuator
                blindMng_adjustBlind(blinds[i].getId(), aperture);
                //Change the Blind sensor
                blindMng_findBlindSensorByidBlind(blinds[i].getId()).setValue(aperture);
            }//for
            notifyAdjustAllBlindToObsevers(aperture);
        }// adjustAllblinds(int)

        /// <summary>
        /// Method to find a blind sensor through its blind actuator identifier
        /// </summary>
        /// <param name="id_blind">blind actuator identifier</param>
        /// <returns>BlindSensor</returns>
        public BlindSensor blindMng_findBlindSensorByidBlind(int id_blind)
        {
            for (int i = 0; i < blindsSensors.Count; i++)
            {
                if (blindsSensors[i].getIdActuator() == id_blind) return blindsSensors[i];
            }
            return null;
        }// blindMng_findBlindSensorByidBlind(int)

        /// <summary>
        /// Method to find a BlindCtrl list that belongs to the same window
        /// </summary>
        /// <param name="id_window">Window identifier</param>
        /// <returns>BlindCtrl list</returns>
        public List<BlindCtrl> blindMng_findblindsCtrlByWindow(int id_window)
        {
            List<BlindCtrl> b = new List<BlindCtrl>();
            for (int i = 0; i < blinds.Count; i++)
            {
                if (blinds[i].getIdWindow() == id_window) b.Add(blinds[i]);

            }//for
            return b;
        }//blindMng_findblindsCtrlByRoom
        
        /// <summary>
        /// Method to find a blind actuator through its identifier
        /// </summary>
        /// <param name="id_blind">BlindCtrl identifier</param>
        /// <returns>BlindCtrl</returns>
        public BlindCtrl blindMng_findBlindCtrl(int id_blind)
        {
            for (int i = 0; i < blinds.Count; i++)
            {
                if (blinds[i].getId() == id_blind) return blinds[i];

            }//for
            return null;

        }//blindMng_findBlindCtrl

        /// <summary>
        /// Adjust a blind with a specific aperture
        /// </summary>
        /// <param name="id_blind">Identifier for the blind actuator</param>
        /// <param name="aperture">Number of degerees(0-100) to open/close the blind</param>
        public void blindMng_adjustBlind(int id_blind, int aperture)
        {
            //Change the Blind actuator
            blindMng_findBlindCtrl(id_blind).setValue(aperture);
            //Change the Blind sensor
            blindMng_findBlindSensorByidBlind(id_blind).setValue(aperture);
            notifyAdjustBlindByRoomToObsevers(id_blind, aperture);
        }//blindMng_adjustBlind

        #region Subject-Observer Pattern
        /// <summary>
        ///     Register a new observer in the observer list
        /// </summary>
        /// <param name="obs">The observer to be registered</param>
        public void registerObserverBlind(IGatewayGUIBlindObserver observer)
        {
            this.observersGatewayBlind.Add(observer);
        }// registerObserverBlind

        /// <summary>
        ///     Notify that the value of the sensor has changed to all the observers registered
        ///     in the observer list
        /// </summary>
        protected void notifyAdjustBlindByRoomToObsevers(int id_blind, int aperture)
        {
            foreach (IGatewayGUIBlindObserver observer in observersGatewayBlind)
            {
                observer.adjustBlindByRoom(id_blind, aperture);
            } // foreach
        } // notifyAdjustBlindByRoomToObsevers

        protected void notifyAdjustAllBlindToObsevers(int aperture)
        {
            foreach (IGatewayGUIBlindObserver observer in observersGatewayBlind)
            {
                observer.adjustAllBlinds(aperture);
            } // foreach
        } // notifySwitchOnByRoomToObsevers

        #endregion
    }
}
