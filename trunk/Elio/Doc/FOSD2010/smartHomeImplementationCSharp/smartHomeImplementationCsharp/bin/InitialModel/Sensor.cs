//=====================================================================================================//
// Author: Pablo Sánchez (p.sanchez@unican.es) http://personales.unican.es/sanchezbp                   //
// Author: Elio López                                                                                  //
// Project: SmartHome Implementation using C# partial classes                                          // 
// File: InitialModel/Sensor.cs                                                                        //
// Papers: Fosd2010                                                                                    //
//=====================================================================================================// 

using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHome
{
    public abstract partial class Sensor
    {
        // Device identifier
        protected int id = 0;  
        // Device currrent value
        protected double deviceValue = 0.0;
        // Gateway reference
        protected Gateway gtw = null;

        // Class emprty constructor
        public Sensor() { 
        } // Sensor()

        // Class constructor with device identifier 
        public Sensor(int id){
            this.id = id;
        } // Sensor(int)

        // Getters and setters 
        public virtual void setId(int id) {
            this.id = id;
        } // setId

        public virtual int getId()
        {
           return this.id;     
        } // getId

        public virtual double getValue()
        {
            return this.deviceValue;
        }

        public virtual void setGateway(Gateway gtw)
        {
            this.gtw = gtw;
        } 

        // Class methods
        public virtual void setUrgentSignal()
        {
            gtw.emergence(this, this.deviceValue);
        }
    }
} // namespace SmartHome
