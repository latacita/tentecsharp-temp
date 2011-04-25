using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
    /// <summary>
    ///    Interface to be implemented for all the observers observing gateway of LightMng as subjects, 
    ///    according to the Subject-Observer design pattern. 
    ///    For further information on this design pattern, refer to 
    ///    Erich Gamma, Richard Helm, Ralph Johnson and John M. Vlissides. 
    ///    "Design Patterns: Elements of Reusable Object-Oriented Software".
    ///    Addison-Wesley, 1994.
    /// </summary>
    public interface IGatewayGUILightObserver
    {
        void adjustLigthByRoom(int id_window, int aperture);
        void adjustAllLigth(int aperture);
    }// IGatewayGUILightObserver
}// SmartHome

