using System;
using System.Collections.Generic;
using System.Text;
using SmartHome;

namespace MyHome
{
    partial class MyHome_Gateway:Gateway
    {
        public MyHome_Gateway()
            : base() { }
        // Class methods
        public override void heaterAdjustTemperature(int id, double temperature)
        {
            this.smartEnergy_HeaterAdjustTemperature(id, temperature);
        }
    }
}