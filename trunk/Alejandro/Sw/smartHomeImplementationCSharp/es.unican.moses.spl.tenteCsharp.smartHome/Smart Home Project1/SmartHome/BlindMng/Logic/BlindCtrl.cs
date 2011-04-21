using System;
using System.Collections.Generic;

namespace SmartHome
{
    //=======================================================================================================================//
    //This class represents an actuator device for a blind                                                                   //
    //=======================================================================================================================//

    public partial class BlindCtrl : Actuator
    {
        // A window can be opened/closed partially by specifying a value inside the 
        // range [CLOSED..OPEN], where CLOSED is the lower bound and OPEN the upper 
        // bound
        protected const double OPEN = 100.0;
        protected const double CLOSED = 0.0;
        //Identifier for the window that is contained for the current blind
        protected int id_window;

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id">Unique identifier for this BlindCtrl</param>
        /// <param name="id_window">Identifier for the window that contains the current blind</param>
        public BlindCtrl(int id, int id_window)
            : base(id)
        {
            this.deviceValue = CLOSED;
            this.id_window = id_window;
        } // BlindCtrl(int)      
        #endregion

        // Class methods
        public void open()
        {
            this.deviceValue = OPEN;
        } // open

        public void close()
        {
            this.deviceValue = CLOSED;
        } // close

        // Class methods        

        #region Getters and Setters
        public override void setValue(double value)
        {
            if ((CLOSED <= value) && (value <= OPEN))
            {
                base.setValue(value);
            } // if
        } // setValue

        public int getIdWindow()
        {
            return id_window;
        }//getIdWindow
        #endregion

    }// BlindCtrl
}// SmartHome
