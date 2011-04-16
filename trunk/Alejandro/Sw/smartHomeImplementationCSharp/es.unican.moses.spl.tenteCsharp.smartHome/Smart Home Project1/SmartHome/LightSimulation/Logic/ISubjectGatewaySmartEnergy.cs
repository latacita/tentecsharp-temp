using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
    public interface ISubjectGatewayLightSimulation
    {
        void registerObserverLightSimulation(IGatewayGUILightSimulationObserver g);
    }// ISubjectGatewayLightSimulation
}
