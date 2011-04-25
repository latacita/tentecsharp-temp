using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
    /// <summary>
    ///    Interface to be implemented for all the observers observing gateway of HeaterMng as subjects, 
    ///    according to the Subject-Observer design pattern. 
    ///    For further information on this design pattern, refer to 
    ///    Erich Gamma, Richard Helm, Ralph Johnson and John M. Vlissides. 
    ///    "Design Patterns: Elements of Reusable Object-Oriented Software".
    ///    Addison-Wesley, 1994.
    /// </summary>
    public interface IGatewayGUIHeaterObserver
    {
        void switchOnByRoom(int id_heater);
        void switchOffByRoom(int id_heater);
        void adjustHeaterByRoom(int id_heater, double temp);
        void allAdjustHeaters(double temp);
        void allSwitchOn();
        void allSwitchOff();
    }// IGatewayGUIHeaterObserver
}// SmartHome
