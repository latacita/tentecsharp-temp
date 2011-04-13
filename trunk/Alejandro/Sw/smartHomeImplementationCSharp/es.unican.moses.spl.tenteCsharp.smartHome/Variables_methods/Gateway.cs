namespace SmartHome
{
    partial class Gateway :ITimeObserver
    {
        // Class methods
        public virtual void heaterAdjustTemperature(int id, double temperature)
        {
            this.smartEnergy_HeaterAdjustTemperature(id, temperature);
            
        }//heaterAdjustTemperature


        #region Subject-Obsever Pattern for Time

        /// <summary>
        ///     Time has changed
        /// </summary>
        /// <param name="timer">The new timer</param>
        public virtual void timeChanged(int hour, int minutes)
        {
            smartEnergy_checkTime(hour, minutes);
            ligthSimulation_checkTime(hour, minutes);
            blindSimulation_checkTime(hour,minutes);
        } // timeChanged        

        #endregion
    }
}
