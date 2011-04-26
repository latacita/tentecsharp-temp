namespace SmartHome
{
    partial class Gateway : ITimeObserver
    {
        
        public virtual void heaterAdjustTemperature(int id, double temperature){ }

        #region Subject-Obsever Pattern for Time

        /// <summary>
        ///     Time has changed
        /// </summary>
        /// <param name="timer">The new timer</param>
        public virtual void timeChanged(int hour, int minutes){ } 

        #endregion
    }
}
