namespace SmartHome
{
    partial class Gateway
    {
        // Class methods
        public virtual void heaterAdjustTemperature(int id, double temperature)
        {
            this.smartEnergy_HeaterAdjustTemperature(id, temperature);
        }
    }
}
