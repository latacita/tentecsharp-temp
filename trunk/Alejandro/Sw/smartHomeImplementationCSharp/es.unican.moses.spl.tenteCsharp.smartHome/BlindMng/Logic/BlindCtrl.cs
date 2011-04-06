using System;
using System.Collections.Generic;

namespace SmartHome
{
    public partial class BlindCtrl : Actuator
    {
        // A window can be opened/closed partially by specifying a value inside the 
        // range [CLOSED..OPEN], where CLOSED is the lower bound and OPEN the upper 
        // bound
        protected const double OPEN = 100.0;
        protected const double CLOSED = 0.0;
        protected int id_window;
        
       //Constructor
        public BlindCtrl(int id,int id_window)
            : base(id)
        {
            this.deviceValue = CLOSED;           
            this.id_window = id_window;
        } // BlindCtrl(int)      

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

        public int getIdWindow()
        {
            return id_window;
        }//getIdWindow

    } // BlindCtrl


}
