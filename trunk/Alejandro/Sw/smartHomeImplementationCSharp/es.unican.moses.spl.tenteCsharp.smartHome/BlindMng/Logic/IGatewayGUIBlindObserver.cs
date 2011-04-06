using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
    public interface IGatewayGUIBlindObserver
    {
        void adjustBlindByRoom(int id_blind,int aperture);
        void adjustAllBlinds(int aperture);
    }//IGatewayGUIBlindObserver
}
