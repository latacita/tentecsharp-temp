using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
    public interface IGatewayGUIBlindSimulationObserver
    {
        void switchOnBlindSimulation();
        void switchOffBlindSimulation();
    }//IGatewayGUIBlindSimulationObserver
}

