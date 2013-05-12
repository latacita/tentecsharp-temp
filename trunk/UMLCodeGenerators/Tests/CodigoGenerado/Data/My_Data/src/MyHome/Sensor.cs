using System;
using System.Collections.Generic;
// This is the content of the class named "Sensor", which is 
// in the package: "MyHome", from the "My_Data" model. 
namespace My_Data{
	public class Sensor{ 
		// Constructor and methods from the from the current class		
		public virtual void Sensor ( ){
			HeaterMng_initSensor ( );
		}
		public virtual void getValue ( ){
			HeaterMng_getValue ( );
		}

	
	 
	}
} 
  