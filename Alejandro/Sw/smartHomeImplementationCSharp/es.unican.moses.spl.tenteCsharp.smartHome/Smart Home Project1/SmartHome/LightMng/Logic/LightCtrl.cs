using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
    //=======================================================================================================================//
    //This class represents an actuator device for a light                                                                   //
    //=======================================================================================================================//
    public partial class LightCtrl : Actuator
    {
        protected const double MINIMUM_LIGTH = 0.0;
        protected const double MAXIMUM_LIGTH = 100.0;

        //Constructor
        public LightCtrl(int id, int id_room)
            : base(id)
        {
            this.deviceValue = MINIMUM_LIGTH;
            this.id_room = id_room;
        } // LightCtrl(int)      

        // Class methods        

        public override void setValue(double value)
        {
            if ((MINIMUM_LIGTH <= value) && (value <= MAXIMUM_LIGTH))
            {
                base.setValue(value);
            } // if
        } // setValue

    } // LightCtrl

}// SmartHome

