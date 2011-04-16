using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
    public interface IGatewayGUILightSimulationObserver
    {
        void switchOnLightSimulation();
        void switchOffLightSimulation();
    }//IGatewayGUILightSimulationObserver
}

