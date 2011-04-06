using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
    public partial class Gateway: ISubjectGatewayBlind
    {
        // BlindCtrl collection
        protected List<BlindCtrl> blinds = null;
        // BlindSensor collection
        protected List<BlindSensor> blindsSensors = null;
        //List of observers
        ICollection<IGatewayGUIBlindObserver> observersGatewayBlind = new LinkedList<IGatewayGUIBlindObserver>();

        //Constructor
        public void initBlindMng()
        {
            this.blinds = new List<BlindCtrl>();
            this.blindsSensors = new List<BlindSensor>();
        }//initBlindMng

        public List<BlindCtrl> blindMng_getBlinds(){
            return blinds;
        }//blindMng_getBlinds

        public List<BlindSensor> blindMng_getBlindsSensors(){
            return blindsSensors;
        }//blindMng_getBlindsSensors

        public void blindMng_addBlindCtrl(BlindCtrl b)
        {
            this.actuators.Add(b);
            this.blinds.Add(b);
        } // blindMng_addBlindCtrl

        public void blindMng_addBlindSensor(BlindSensor bs)
        {
            this.sensors.Add(bs);
            this.blindsSensors.Add(bs);
        }// blindMng_addBlindSensor

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
        }//adjustAllblinds

        public BlindSensor blindMng_findBlindSensorByidBlind(int id_blind)
        {
            for (int i = 0; i < blindsSensors.Count; i++)
            {
                if (blindsSensors[i].getIdActuator() == id_blind) return blindsSensors[i];
            }
            return null;
        }//blindMng_findBlindSensorByidBlind

        public List<BlindCtrl> blindMng_findblindsCtrlByWindow(int id_window)
        {
            List<BlindCtrl> b=new List<BlindCtrl>();
            for (int i = 0; i < blinds.Count; i++)
            {
                if (blinds[i].getIdWindow() == id_window) b.Add(blinds[i]);
                
            }//for
            return b;
        }//blindMng_findblindsCtrlByRoom

        public BlindCtrl blindMng_findBlindCtrl(int id_blind)
        {
            for (int i = 0; i < blinds.Count; i++)
            {
                if (blinds[i].getId() == id_blind) return blinds[i];

            }//for
            return null;

        }//blindMng_findBlindCtrl

        public void blindMng_adjustBlind(int id_blind, int aperture)
        {
            //Change the Blind actuator
            blindMng_findBlindCtrl(id_blind).setValue(aperture);
            //Change the Blind sensor
            blindMng_findBlindSensorByidBlind(id_blind).setValue(aperture);
            notifyAdjustBlindByRoomToObsevers(id_blind,aperture);
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
                 observer.adjustBlindByRoom(id_blind,aperture);
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
