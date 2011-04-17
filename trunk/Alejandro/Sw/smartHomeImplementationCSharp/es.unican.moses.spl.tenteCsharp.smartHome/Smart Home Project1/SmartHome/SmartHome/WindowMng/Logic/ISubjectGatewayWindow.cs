using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
    public interface ISubjectGatewayWindow
    {
        void registerObserverWindow(IGatewayGUIWindowObserver g);
    }// ISubjectGatewayWindow
}
