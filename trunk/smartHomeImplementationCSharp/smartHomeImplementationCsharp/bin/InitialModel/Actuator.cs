//=====================================================================================================//
// Author: Pablo Sánchez (p.sanchez@unican.es) http://personales.unican.es/sanchezbp                   //
// Author: Elio López                                                                                  //
// Project: SmartHome Implementation using C# partial classes                                          // 
// File: InitialModel/Actuator.cs                                                                      //
// Papers: Fosd2010                                                                                    //
//=====================================================================================================// 

using System;
using System.Collections.Generic;

namespace SmartHome
{

    //=================================================================================================//
    // This class is an abstract class the represents the common supertype for all actuators           //
    //=================================================================================================//
    public abstract partial class Actuator
    {
        // Device identifier
        protected int id = 0; 
        protected double deviceValue = 0.0;

        public Actuator() { 
        } // Actuator()

        public Actuator(int id){
            this.id = id;
        } // Actuator(int)

        public virtual void setId(int id) {
            this.id = id;
        } // setId

        public virtual int getId() {
           return this.id;     
        } // getId

        public virtual void setValue(double value) {
            this.deviceValue = value;
        } // setValue

    } // Actuator

} // namespace SmartHome

