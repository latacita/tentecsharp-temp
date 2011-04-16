namespace SmartHome
{
    partial class Gateway :ITimeObserver
    {
        // Class methods
        public virtual void heaterAdjustTemperature(int id, double temperature) { }
                   
            
        #region Subject-Obsever Pattern for Time

        /// <summary>
        ///     Time has changed
        /// </summary>
        /// <param name="hour">The new hour</param>
        /// /// <param name="minutes">The new minutes</param>
        public virtual void timeChanged(int hour, int minutes) { }      

        #endregion
    }
}
