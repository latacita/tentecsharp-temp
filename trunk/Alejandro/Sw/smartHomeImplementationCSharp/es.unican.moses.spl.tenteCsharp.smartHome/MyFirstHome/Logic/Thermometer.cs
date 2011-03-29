using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartHome;

namespace MyFirstHome
{
    partial class MyFirstHome_Thermometer: Thermometer
    {
        public MyFirstHome_Thermometer(int id, int id_heater)
            : base(id, id_heater) { }
    }
}
