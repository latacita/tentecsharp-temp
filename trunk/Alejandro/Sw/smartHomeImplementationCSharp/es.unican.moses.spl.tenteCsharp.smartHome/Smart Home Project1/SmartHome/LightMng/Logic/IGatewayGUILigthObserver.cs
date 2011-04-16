using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
    public interface IGatewayGUILigthObserver
    {
        void adjustLigthByRoom(int id_window, int aperture);
        void adjustAllLigth(int aperture);
    }
}

