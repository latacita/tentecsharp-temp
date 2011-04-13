using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartHome;

namespace MyHome
{
    partial class MyHome_Thermometer: Thermometer
    {
        public MyHome_Thermometer(int id, int id_heater)
            : base(id, id_heater) { }
    }
}
