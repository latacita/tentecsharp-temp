using System;
using System.Collections.Generic;

namespace SmartHome
{
    public partial class WindowCtrl : Actuator
    {
        // A window can be opened/closed partially by specifying a value inside the 
        // range [CLOSED..OPEN], where CLOSED is the lower bound and OPEN the upper 
        // bound
        protected const double OPEN   = 100.0;
        protected const double CLOSED = 0.0;

        // Constructor
        public WindowCtrl() : base()
        {
            this.deviceValue = CLOSED;
        } // WindowCtrl

        public WindowCtrl(int id) : base(id)
        {
            this.deviceValue = CLOSED;
        } // LightCtrl(int)

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
        public void sayHello()
        {
            String status = "UNDEFINED";

            if (deviceValue == 0.0)
            {
                status = "CLOSED";
            }
            else if (deviceValue == 100.0)
            {
                status = "OPEN";
            }
            else {
                status = deviceValue.ToString() + "% OPEN";
            } // if
            System.Console.Out.WriteLine("I am the window " + id + " and I am " + status);
        } // sayHello

        public override void setValue(double value)
        {
            if ((CLOSED <= value) && (value <= OPEN)) {
                base.setValue(value);
            } // if
        } // setValue

    } // LightCtrl


}
