using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
    public partial class Device
    {
        // Device identifier
        protected int id;

        // Observers list
        ICollection<IDeviceObserver> observers = new LinkedList<IDeviceObserver>();

        public Device(int id)
        {
            this.id = id;
        }//Device(int)

        public virtual int getId()
        {
            return id;
        }//getId

        public virtual void setId(int id)
        {
            this.id = id;
        }//setId

        #region Subject-Observer Pattern

        /// <summary>
        ///     Register a new observer in the observer list
        /// </summary>
        /// <param name="obs">The observer to be registered</param>
        public void registerObserver(IDeviceObserver observer)
        {
            this.observers.Add(observer);
        }

        /// <summary>
        ///     Notify that the value of the sensor has changed to all the observers registered
        ///     in the observer list
        /// </summary>
        protected void notifyChangeToObsevers()
        {
            foreach (IDeviceObserver observer in observers)
            {
                observer.deviceValueChanged(this);
            } // foreach
        } // notifyChangeToObsevers

        #endregion

    }//Device
}//SmartHome
