using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
     
    public partial class Gateway:ISubjectGatewayLightSimulation
    {
        protected bool statusLigthSimulation = false;
        ICollection<IGatewayGUILightSimulationObserver> observersGatewayLightSimulation= new LinkedList<IGatewayGUILightSimulationObserver>();
       

        public void initLightSimulation()
        {
            time.registerObserver(this);
        }

        public void ligthSimulation_switchOn()
        {
            this.statusLigthSimulation = true;
            ligthSimulation_checkTime(time.getHour(),time.getMinutes());
            notifySwitchOnLightSimulationToObsevers();
        }//ligthSimulation_switchOn

        public void ligthSimulation_switchOff()
        {
            this.statusLigthSimulation = false;
            ligthMng_allAdjustLigths(0);
            notifySwitchOffLightSimulationToObsevers();
        }//ligthSimulation_switchOff

        public void ligthSimulation_checkTime(int hour, int minutes)
        {
            String t = hour.ToString() + "," + minutes.ToString();
            double time = Convert.ToDouble(t);
            if (statusLigthSimulation)
            {
                List<LightCtrl> l = ligthMng_getLigths();
                if (time % 1 == 0)//everyHour
                {
                    for (int i = 0; i < l.Count; i++)
                    {
                        Random r = new Random(DateTime.Now.Millisecond);
                        int id = l[i].getId();
                        if (r.NextDouble() > 0.5)
                            ligthMng_adjustLigth(id, Convert.ToInt32(r.Next(0, 100)));
                        else
                            ligthMng_adjustLigth(id, 0);
                    }//for
                }//if
            }//if            
        }//ligthSimulation_checkTime

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
            foreach (IGatewayGUILightSimulationObserver observer in observersGatewayLigth)
            {
                observer.switchOnLightSimulation();
            } // foreach
        } // notifySwitchOnSmartEnergyToObsevers

        protected void notifySwitchOffLightSimulationToObsevers()
        {
            foreach (IGatewayGUILightSimulationObserver observer in observersGatewayLigth)
            {
                observer.switchOffLightSimulation();
            } // foreach
        } // notifySwitchOffSmartEnergyToObsevers
        #endregion
    }
}
