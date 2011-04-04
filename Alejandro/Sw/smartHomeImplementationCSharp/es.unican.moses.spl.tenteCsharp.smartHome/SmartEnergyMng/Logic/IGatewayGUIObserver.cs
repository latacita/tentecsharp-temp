using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
    public interface IGatewayGUIObserver
    {
        void refreshWindow(int aperture, int id_window);
    }
}
