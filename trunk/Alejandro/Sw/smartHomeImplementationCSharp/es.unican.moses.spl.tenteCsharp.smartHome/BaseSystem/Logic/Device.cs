using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
    public partial class Device : ISubject<IDeviceObserver>
    {
        // Device identifier
        protected int id;
        // Device value
        protected double deviceValue = 0.0;

        // Observers list
        ICollection<IDeviceObserver> observers = new LinkedList<IDeviceObserver>();

        public Device(int id)
        {
            this.id = id;
        }//Device(int)

        #region Getters and Setters

        /// <summary>
        ///  Set method for the Devices(this class is going to be inherit by Actuator and Sensor classes).
        ///  In a real setting, *sensors are never set values*, but this method has been included 
        ///  here for simulation purposes, as we need to alter manually the values perceived by sensors to check 
        ///  how the house works
        /// </summary>
        /// <param name="value">The value to be set in this sensors and actuators</param>
        public virtual int getId()
        {
            return id;
        }//getId

        public virtual void setId(int id)
        {
            this.id = id;
        }//setId

        public virtual double getValue()
        {
            return deviceValue;
        }//getValue

        public virtual void setValue(double deviceValue)
        {
            this.deviceValue = deviceValue;
            //Observer Pattern
            notifyChangeToObsevers();
        }//setValue(double)
        #endregion

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
