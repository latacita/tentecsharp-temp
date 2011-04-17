using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
    public interface ISubjectGatewayLigth
    {
        void registerObserverLigth(IGatewayGUILigthObserver g);
    }// ISubjectGatewayWindow
}
