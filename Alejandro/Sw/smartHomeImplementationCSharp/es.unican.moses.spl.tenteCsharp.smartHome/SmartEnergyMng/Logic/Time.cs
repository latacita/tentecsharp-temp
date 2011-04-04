using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
    public partial class Time: ISubject<ITimeObserver>
    {
        protected double time;

        // Observers list
        protected ICollection<ITimeObserver> observers = new LinkedList<ITimeObserver>();

        public Time(double time)
        {
            this.time = time;
        }//Time(double)

        #region Getters and Setters
        public double getTime()
        {
            return time;
        }//getTime

        public void setTime(double time)
        {
            this.time = time;
            notifyObservers();
        }//setTime

        #endregion

        #region Subject-Observer Pattern

        /// <summary>
        ///     Register observers in the observers list
        /// </summary>
        /// <param name="observer">The observer to be registered</param>
        public void registerObserver(ITimeObserver observer)
        {
            observers.Add(observer);
        } // registerObserver

        /// <summary>
        ///     Notify to all registered observers that the timer has changed
        /// </summary>
        protected void notifyObservers() {
            foreach (ITimeObserver obs in observers) { 
                obs.timeChanged(time);
            } //     
        } // notifyObservers

        #endregion
    }
}
