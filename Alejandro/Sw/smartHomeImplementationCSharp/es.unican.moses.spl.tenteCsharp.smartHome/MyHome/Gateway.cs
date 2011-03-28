namespace SmartHome
{
    partial class Gateway
    {
        // Class methods
        public void heaterAdjustTemperature(int id, double temperature)
        {
            switchOnSmartEnergyMng();
            this.smartEnergyHeaterAdjustTemperature(id, temperature);
        }
    }
}
