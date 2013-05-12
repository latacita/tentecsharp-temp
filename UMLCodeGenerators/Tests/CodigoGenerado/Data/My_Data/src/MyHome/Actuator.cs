using System;
using System.Collections.Generic;
// This is the content of the class named "Actuator", which is 
// in the package: "MyHome", from the "My_Data" model. 
namespace My_Data{
	public class Actuator{ 
		// Constructor and methods from the from the current class		
		public virtual void setValue ( ){
			HeaterMng_setValue ( );
		}
		public virtual void Actuator ( ){
			HeaterMng_initActuator ( );
		}
		public virtual void getValue ( ){
			HeaterMng_getValue ( );
		}

	
	 
	}
} 
  