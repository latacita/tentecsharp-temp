using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
    public interface ISubjectGatewayBlindSimulation
    {
        void registerObserverBlindSimulation(IGatewayGUIBlindSimulationObserver g);
    }// ISubjectGatewayBlindSimulation
}
