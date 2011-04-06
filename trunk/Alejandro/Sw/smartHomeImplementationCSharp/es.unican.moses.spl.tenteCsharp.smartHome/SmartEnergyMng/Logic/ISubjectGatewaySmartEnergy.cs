using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
    public interface ISubjectGatewaySmartEnergy
    {
        void registerObserverSmartEnergy(IGatewayGUISmartEnergyObserver g);
    }// ISubjectGatewaySmartEnergy
}
