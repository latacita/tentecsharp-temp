using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
    public interface IGatewayGUIHeaterObserver
    {
        void switchOnByRoom(int id_heater);
        void switchOffByRoom(int id_heater);
        void adjustHeaterByRoom(int id_heater, double temp);
        void allAdjustHeaters(double temp);
        void allSwitchOn();
        void allSwitchOff();
    }
}
