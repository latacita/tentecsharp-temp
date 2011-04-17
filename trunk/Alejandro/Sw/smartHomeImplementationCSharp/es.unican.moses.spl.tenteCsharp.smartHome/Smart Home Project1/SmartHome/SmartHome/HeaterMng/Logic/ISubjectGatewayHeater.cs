using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
    public interface ISubjectGatewayHeater
    {
        void registerObserverHeater(IGatewayGUIHeaterObserver g);

    } // ISubjectGatewayHeater
}
