using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
    public partial class Time
    {
        protected double time;

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
        }//setTime

        #endregion
    }
}
