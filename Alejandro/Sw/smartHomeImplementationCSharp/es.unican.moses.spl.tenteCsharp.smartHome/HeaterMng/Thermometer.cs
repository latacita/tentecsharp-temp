using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
    public partial class Thermometer : Sensor
    {
        protected double outsideTemp = 0;
                
        //This method is called each time the temperature changes
        public void setOutsideTemp(double outsideTemp)
        {
            this.outsideTemp = outsideTemp;
        }//setOutsideTemp

        public double getOutsideTemp()
        {
            return outsideTemp;
        }//getOutsideTemp

        //This method is called each time the temperature changes
        public override void setValue(double temp)
        {
            this.deviceValue = temp;
        }// setValue

        public override double getValue()
        {
            return deviceValue;
        }// getValue        
    }// Thermometer
}// SmartHome
