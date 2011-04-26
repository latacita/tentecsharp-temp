using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
    /// <summary>
    ///     This interface is implemented by all classes playing the role
    ///     of subject gateway smartEnergyMng in implementations of the Subject-Observer Pattern. 
    ///     For further information on this design pattern, refer to 
    ///     Erich Gamma, Richard Helm, Ralph Johnson and John M. Vlissides. 
    ///     "Design Patterns: Elements of Reusable Object-Oriented Software".
    ///     Addison-Wesley, 1994.
    /// </summary>
    public interface ISubjectGatewaySmartEnergy
    {
        void registerObserverSmartEnergy(IGatewayGUISmartEnergyObserver g);
    }// ISubjectGatewaySmartEnergy
}// SmartHome
