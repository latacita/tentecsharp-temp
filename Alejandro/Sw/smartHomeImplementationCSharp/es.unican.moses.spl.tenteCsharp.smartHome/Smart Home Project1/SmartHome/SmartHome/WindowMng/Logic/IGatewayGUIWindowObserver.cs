using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
    public interface IGatewayGUIWindowObserver
    {
        void adjustWindowByRoom(int id_window, int aperture);
        void adjustAllWindow(int aperture);
    }
}
