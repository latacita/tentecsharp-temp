using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartHome;

namespace MyFirstHome
{
    partial class MyFirstHome_GatewayGUI : GatewayGUI
    {
        public MyFirstHome_GatewayGUI(Gateway g, SimulatorGUI sim)
            : base(g, sim) { }
        public override void refreshSimulator()
        {
            simulator.fillDataGridViewHeaters();
            simulator.fillDataGridViewWindows();
        }//refreshSimulator
    }
}
