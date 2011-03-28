using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
    partial class GatewayGUI
    {
        public void refreshSimulator()
        {
            simulator.fillDataGridViewHeaters();
            simulator.fillDataGridViewWindows();
        }//refreshSimulator
    }//GatewayGUI
}