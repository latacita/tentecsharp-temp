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
            initSmartEnergyMng();
        } // Gateway()

        public bool adjustTemparature(int id, double temperature) {
            return this.smartEnergyAdjustTemparature(id,temperature);
        } // adjustTemparature

    } // Gateway
} // namespace SmartHome
