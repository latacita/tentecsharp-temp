using System;
using System.Collections.Generic;
// This is the content of the class named "HeaterCtrl", which is 
// in the package: "MyHome", from the "My_Data" model. 
namespace My_Data{
	public class HeaterCtrl{ 
		// Constructor and methods from the from the current class		
		public virtual void HeaterCtrl ( ){
			HeaterMng_initHeaterCtrl ( );
		}
		public virtual void setValue ( double temp ){
			HeaterMng_setValue ( temp );
		}

	
	 
	}
} 
  