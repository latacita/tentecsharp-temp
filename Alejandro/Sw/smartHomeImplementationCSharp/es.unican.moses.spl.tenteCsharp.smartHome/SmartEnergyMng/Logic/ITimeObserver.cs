using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHome
{
    /// <summary>
    ///     Interface which must be implemented by timer observers according to the 
    ///     Subject-Obsever pattern. 
    ///     For further information on this design pattern, refer to 
    ///     Erich Gamma, Richard Helm, Ralph Johnson and John M. Vlissides. 
    ///     "Design Patterns: Elements of Reusable Object-Oriented Software".
    ///     Addison-Wesley, 1994.
    /// </summary>
    public interface ITimeObserver
    {
        /// <summary>
        ///     This method is onvoked when the timer changes to notify
        ///     timer obsevers the times goes ...
        /// </summary>
        /// <param name="timer">The new timestamp</param>
        void timeChanged(double time); 
    
    } // ITimeObserver
} // SmartHome
