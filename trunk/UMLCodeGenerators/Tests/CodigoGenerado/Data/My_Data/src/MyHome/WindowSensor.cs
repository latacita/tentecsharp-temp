using System;
using System.Collections.Generic;
// This is the content of the class named "WindowSensor", which is 
// in the package: "MyHome", from the "My_Data" model. 
namespace My_Data{
	public class WindowSensor{ 
		// Constructor and methods from the from the current class		
		public virtual void WindowSensor ( ){
			WindowMng_initWindowSensor ( );
		}
		public virtual  Int  getAperture ( ){
			WindowMng_getAperture ( );
		}

	
	 
	}
} 
  