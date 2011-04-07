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
        protected int hour;
        protected int minutes;

        public Time(int hour, int minutes)
        {
            this.hour = hour;
            this.minutes = minutes;
        }//Time(int,int)

        #region Getters and Setters
        public void setTime(int valueHour, int valueMinute )
	    {
	        hour = ( valueHour >= 0 && valueHour < 24 ) ?
	                valueHour : 0;
	        minutes = ( valueMinute >= 0 && valueMinute < 60 ) ?
	        valueMinute : 0;
            notifyObservers();
	    }//setTime
        public int getHour()
        {
            return hour;
        }
        public int getMinutes()
        {
            return minutes;
        }
	  
	    public string getTime()
	    {
	     return String.Format(
	        "{0:D2}:{1:D2}", hour, minutes);
	    }//getTime       

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
                obs.timeChanged(hour, minutes);
            } //     
        } // notifyObservers

        #endregion
    }
}
