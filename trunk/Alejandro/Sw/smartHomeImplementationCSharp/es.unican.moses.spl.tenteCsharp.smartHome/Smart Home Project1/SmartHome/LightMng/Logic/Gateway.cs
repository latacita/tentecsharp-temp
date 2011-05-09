using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
    //=================================================================================================//
    // This class represent the central gateway of the Smart Home which process all commands           //
    // This file only contains the functionality related to the LightMng feature                       //
    //=================================================================================================//
    public partial class Gateway : ISubjectGatewayLight
    {
        // LightCtrl collection
        protected List<LightCtrl> lights = null;
        // LightSensor collection
        protected List<LightSensor> lightsSensors = null;
        //List of observers
        ICollection<IGatewayGUILightObserver> observersGatewayLight = new LinkedList<IGatewayGUILightObserver>();

        #region Constructor
        //Constructor
        public void initLightMng()
        {
            this.lights = new List<LightCtrl>();
            this.lightsSensors = new List<LightSensor>();
        }//initLightMng
        #endregion

        public void lightMng_addLightCtrl(LightCtrl l)
        {
            this.actuators.Add(l);
            this.lights.Add(l);
        } // lightMng_addLightCtrl

        public void lightMng_addLightSensor(LightSensor ls)
        {
            this.sensors.Add(ls);
            this.lightsSensors.Add(ls);
        }// ligthMng_addLightSensor

        #region Getters and Setters

        public List<LightCtrl> lightMng_getLigths()
        {
            return lights;
        }//lightMng_getLigths

        public List<LightSensor> lightMng_getLigthsSensors()
        {
            return lightsSensors;
        }//lightMng_getLigthsSensors

        #endregion

        /// <summary>
        /// Method to adjust the lighting of a all lights
        /// </summary>
        /// <param name="lighting">Lighting</param>
        public void lightMng_allAdjustLights(int lighting)
        {
            for (int i = 0; i < lights.Count; i++)
            {
                //Change the light actuator
                lightMng_adjustLight(lights[i].getId(), lighting);               
            }//for
            notifyAdjustAllLightToObsevers(lighting);

        }//lightMng_allAdjustLights

        /// <summary>
        /// Method to find a light sensor through its identifier
        /// </summary>
        /// <param name="id_ligth">Light idenfifier</param>
        /// <returns>LightSensor</returns>
        public LightSensor lightMng_findLigthSensorByIdLigth(int id_ligth)
        {
            for (int i = 0; i < lightsSensors.Count; i++)
            {
                if (lightsSensors[i].getIdActuator() == id_ligth) return lightsSensors[i];
            }
            return null;
        }//lightMng_findLigthSensorByIdLigth

        /// <summary>
        /// Method to find all the lights actuators in a specific room
        /// </summary>
        /// <param name="id_room">Room identifier</param>
        /// <returns>LightCtrl list</returns>
        public List<LightCtrl> lightMng_findLigthCtrlByRoom(int id_room)
        {
            List<LightCtrl> l = new List<LightCtrl>();
            for (int i = 0; i < lights.Count; i++)
            {
                if (lights[i].getIdRoom() == id_room) l.Add(lights[i]);

            }//for
            return l;
        }//lightMng_findLigthCtrlByRoom

        /// <summary>
        /// Method to find a specific light actuator thorught its identifier
        /// </summary>
        /// <param name="id_ligth">Light identifier</param>
        /// <returns>LightCtrl</returns>
        public LightCtrl lightMng_findLightCtrl(int id_ligth)
        {
            for (int i = 0; i < lights.Count; i++)
            {
                if (lights[i].getId() == id_ligth) return lights[i];

            }//for
            return null;

        }//lightMng_findLightCtrl

        /// <summary>
        /// Method to adjust the lighting of a specific light
        /// </summary>
        /// <param name="id_ligth">Light identifier</param>
        /// <param name="lighting">Lighting</param>
        public void lightMng_adjustLight(int id_ligth, int lighting)
        {
            //Change the ligth actuator
            lightMng_findLightCtrl(id_ligth).setValue(lighting);
            //Change the ligth sensor(only for simulator purposes)
            lightMng_findLigthSensorByIdLigth(id_ligth).setValue(lighting);
            notifyAdjustLigthByRoomToObsevers(id_ligth, lighting);
        }//ligthMng_adjustWindow

        #region Subject-Observer Pattern
        /// <summary>
        ///     Register a new observer in the observer list
        /// </summary>
        /// <param name="obs">The observer to be registered</param>
        public void registerObserverLigth(IGatewayGUILightObserver observer)
        {
            this.observersGatewayLight.Add(observer);
        }// registerObserverWindow

        /// <summary>
        ///     Notify that the value of the sensor has changed to all the observers registered
        ///     in the observer list
        /// </summary>
        protected void notifyAdjustLigthByRoomToObsevers(int id_ligth, int ligthing)
        {
            foreach (IGatewayGUILightObserver observer in observersGatewayLight)
            {
                observer.adjustLigthByRoom(id_ligth, ligthing);
            } // foreach
            //If all lights have the same lighting, we will change the global lighting
            bool flag = true;
            double preview = lightsSensors[0].getValue();
            for (int i = 1; i < lightsSensors.Count; i++)
            {
                if (preview != lightsSensors[i].getValue()) flag = false;
            }// for
            if (flag == true) notifyAdjustAllLightToObsevers(Convert.ToInt32(preview));
        } // notifyAdjustWindowByRoomToObsevers

        protected void notifyAdjustAllLightToObsevers(int ligthing)
        {
            foreach (IGatewayGUILightObserver observer in observersGatewayLight)
            {
                observer.adjustAllLigth(ligthing);
            } // foreach
        } // notifySwitchOnByRoomToObsevers

        #endregion

    }// Gateway
}// SmartHome
