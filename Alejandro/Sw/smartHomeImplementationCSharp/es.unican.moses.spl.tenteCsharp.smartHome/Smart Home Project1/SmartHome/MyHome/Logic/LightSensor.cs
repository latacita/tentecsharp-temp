using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartHome;

namespace MyHome
{
    partial class MyHome_LightSensor : LightSensor
    {
        public MyHome_LightSensor(int id, int id_lightCtrl)
            : base(id, id_lightCtrl) { }
    }
}
