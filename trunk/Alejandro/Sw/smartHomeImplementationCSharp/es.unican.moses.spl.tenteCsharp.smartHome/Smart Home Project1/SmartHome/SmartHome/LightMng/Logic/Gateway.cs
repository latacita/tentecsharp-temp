using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
    public partial class Gateway : ISubjectGatewayLigth
    {
        // LightCtrl collection
        protected List<LightCtrl> ligths = null;
        // LightSensor collection
        protected List<LightSensor> ligthsSensors = null;
        //List of observers
        ICollection<IGatewayGUILigthObserver> observersGatewayLigth = new LinkedList<IGatewayGUILigthObserver>();

        //Constructor
        public void initLightMng()
        {
            this.ligths = new List<LightCtrl>();
            this.ligthsSensors = new List<LightSensor>();
        }//initLightMng

        public List<LightCtrl> ligthMng_getLigths()
        {
            return ligths;
        }//ligthMng_getLigths

        public List<LightSensor> ligthwMng_getLigthsSensors()
        {
            return ligthsSensors;
        }//ligthwMng_getLigthsSensors

        public void lightMng_addLightCtrl(LightCtrl l)
        {
            this.actuators.Add(l);
            this.ligths.Add(l);
        } // lightMng_addLightCtrl

        public void lightMng_addLightSensor(LightSensor ls)
        {
            this.sensors.Add(ls);
            this.ligthsSensors.Add(ls);
        }// ligthMng_addWindowSensor

        public void ligthMng_allAdjustLigths(int lighting)
        {
            for (int i = 0; i < ligths.Count; i++)
            {
                //Change the window actuator
                ligthMng_adjustLigth(ligths[i].getId(), lighting);
                //Change the window sensor
                ligthMng_findLigthSensorByIdLigth(ligths[i].getId()).setValue(lighting);
            }//for
            notifyAdjustAllLigthToObsevers(lighting);

        }//ligthMng_allAdjustLigths

        public LightSensor ligthMng_findLigthSensorByIdLigth(int id_ligth)
        {
            for (int i = 0; i < ligthsSensors.Count; i++)
            {
                if (ligthsSensors[i].getIdActuator() == id_ligth) return ligthsSensors[i];
            }
            return null;
        }//ligthMng_findLigthSensorByIdLigth

        public List<LightCtrl> ligthMng_findLigthCtrlByRoom(int id_room)
        {
            List<LightCtrl> l = new List<LightCtrl>();
            for (int i = 0; i < ligths.Count; i++)
            {
                if (ligths[i].getIdRoom() == id_room) l.Add(ligths[i]);

            }//for
            return l;
        }//ligthMng_findLigthCtrlByRoom

        public LightCtrl ligthMng_findLigthCtrl(int id_ligth)
        {
            for (int i = 0; i < ligths.Count; i++)
            {
                if (ligths[i].getId() == id_ligth) return ligths[i];

            }//for
            return null;

        }//ligthMng_findLigthCtrl

        public void ligthMng_adjustLigth(int id_ligth, int lighting)
        {
            //Change the ligth actuator
            ligthMng_findLigthCtrl(id_ligth).setValue(lighting);
            //Change the ligth sensor
            ligthMng_findLigthSensorByIdLigth(id_ligth).setValue(lighting);
            notifyAdjustLigthByRoomToObsevers(id_ligth, lighting);

        }//ligthMng_adjustWindow

        #region Subject-Observer Pattern
        /// <summary>
        ///     Register a new observer in the observer list
        /// </summary>
        /// <param name="obs">The observer to be registered</param>
        public void registerObserverLigth(IGatewayGUILigthObserver observer)
        {
            this.observersGatewayLigth.Add(observer);
        }// registerObserverWindow

        /// <summary>
        ///     Notify that the value of the sensor has changed to all the observers registered
        ///     in the observer list
        /// </summary>
        protected void notifyAdjustLigthByRoomToObsevers(int id_ligth, int ligthing)
        {
            foreach (IGatewayGUILigthObserver observer in observersGatewayLigth)
            {
                observer.adjustLigthByRoom(id_ligth, ligthing);
            } // foreach
        } // notifyAdjustWindowByRoomToObsevers

        protected void notifyAdjustAllLigthToObsevers(int ligthing)
        {
            foreach (IGatewayGUILigthObserver observer in observersGatewayLigth)
            {
                observer.adjustAllLigth(ligthing);
            } // foreach
        } // notifySwitchOnByRoomToObsevers

        #endregion

    }// Gateway
}// SmartHome
