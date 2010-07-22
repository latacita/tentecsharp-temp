using System;

namespace SmartHome
{
    public partial class Gateway
    {
        public Gateway() {
            initInitialModel();
            initLightMng();
            initWindowMng();
            initHeaterMng();
        } // Gateway()
    } // Gateway
} // namespace SmartHome
