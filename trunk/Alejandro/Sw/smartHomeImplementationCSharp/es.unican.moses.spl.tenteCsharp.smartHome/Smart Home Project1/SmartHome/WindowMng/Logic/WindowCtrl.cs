using System;
using System.Collections.Generic;

namespace SmartHome
{
    //=======================================================================================================================//
    //This class represents an actuator device for a window                                                                  //
    //=======================================================================================================================//
    public partial class WindowCtrl : Actuator
    {
        // A window can be opened/closed partially by specifying a value inside the 
        // range [CLOSED..OPEN], where CLOSED is the lower bound and OPEN the upper 
        // bound
        protected const double OPEN = 100.0;
        protected const double CLOSED = 0.0;

        //Constructor
        public WindowCtrl(int id, int id_room)
            : base(id)
        {
            this.deviceValue = CLOSED;
            this.id_room = id_room;
        } // WindowCtrl(int)      

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

        public override void setValue(double value)
        {
            if ((CLOSED <= value) && (value <= OPEN))
            {
                base.setValue(value);
            } // if
        } // setValue

    } // WindowCtrl    
}// SmartHome
