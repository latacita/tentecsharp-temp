using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartHome;

namespace MyHome
{
    partial class MyHome_BlindSensor : BlindSensor
    {
        public MyHome_BlindSensor(int id, int id_blindCtrl)
            : base(id, id_blindCtrl) { }
    }
}
