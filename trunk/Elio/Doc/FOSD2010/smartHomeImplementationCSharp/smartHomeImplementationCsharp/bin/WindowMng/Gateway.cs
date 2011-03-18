//=====================================================================================================//
// Author: Pablo Sánchez (p.sanchez@unican.es) http://personales.unican.es/sanchezbp                   //
// Author: Elio López                                                                                  //
// Project: SmartHome Implementation using C# partial classes                                          // 
// File: Window/Gateway.cs                                                                       //
// Papers: Fosd2010                                                                                    //
//=====================================================================================================//     

using System;
using System.Collections.Generic;

namespace SmartHome
{

    //=================================================================================================//
    // This class represent the central gateway of the Smart Home which process all commands           //
    // This file only contains the functionality related to the WindowMng feature                       //
    //=================================================================================================//
    public partial class Gateway
    {
        // windows collection
        protected List<WindowCtrl> windows = null;

        // Constructor
        public void initWindowMng()
        {
            this.windows = new List<WindowCtrl>();
        } // Gateway()

        // Attributes manipulators
        public void addWindowCtrl(WindowCtrl w)
        {
            this.actuators.Add(w);
            this.windows.Add(w);
        } // addWindowCtrl


        // Helper methods
        protected WindowCtrl findWindow(int id) {
            WindowCtrl window = null;

            List<WindowCtrl>.Enumerator it = windows.GetEnumerator();

            while ((it.MoveNext() == true) && (window == null))
            {
                if (it.Current.getId() == id)
                {
                    window = it.Current;
                } // if
            } //while

            it.Dispose();

            return window;

        } // findWindow

        // Class methods
        public bool windowOpenWindow(int id)
        {
            bool result = false;

            WindowCtrl window = findWindow(id);
            if (window != null)
            {
                window.open();
                result = true;
            } // if

            return result;
        } // openWindow

        public bool windowCloseWindow(int id)
        {
            bool result = false;

            WindowCtrl window = findWindow(id);
            if (window != null)
            {
                window.close();
                result = true;
            } // if

            return result;
        } // openWindow

        public bool windowOpenPartiallyWindow(int id, double openess) {
            bool result = false;

            WindowCtrl window = findWindow(id);
            if (window != null)
            {
                window.setValue(openess);
                result = true;
            } // if

            return result;
        } // openPartiallyWindow


    } // Gateway

} // namespace