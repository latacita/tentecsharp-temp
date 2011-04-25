using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
    //=================================================================================================================================//
    //This class represents a sensor device(thermometer) for a heater                                                                  //
    //=================================================================================================================================//
    public partial class Thermometer : Sensor
    {
        protected double outsideTemp = 0;
        // Standard average temperature in earth surface
        protected const double DEFAULT_TEMP = 25.0;

        #region Constructors
        public Thermometer(int id, int id_heater)
            : base(id, id_heater)
        {
            this.outsideTemp = DEFAULT_TEMP;

        }// Thermometer(int, int)
        #endregion

        #region Getters and Setters
        //This method is called each timer the temperature changes
        public void setOutsideTemp(double outsideTemp)
        {
            this.outsideTemp = outsideTemp;
        }//setOutsideTemp

        public double getOutsideTemp()
        {
            return outsideTemp;
        }//getOutsideTemp          
        #endregion
    }// Thermometer
}// SmartHome
