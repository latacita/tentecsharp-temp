using System;
using System.Collections.Generic;
// This is the content of the class named "Actuator", which is 
// in the package: "HeaterMng", from the "Data" model. 
namespace Data{	
	 	 abstract  class Actuator : Device{
 
		// Properties from the current class 		 
		
		 
		 
		
		// Utility methods from the current class 
		
		public  virtual  override bool Equals (Object o);
		public  virtual  override int CompareTo (Object o);
		public  virtual  override int GetHashCode ( );
		public  virtual  override Type GetType ( );
		public  virtual  override string ToString( );

		
		// Constructor and methods from the from the current class		
		private void HeaterMng_initActuator ( ) {}
		private  virtual void HeaterMng_getValue ( ) {}
		private  virtual void HeaterMng_setValue ( ) {}
			
	
	
	}
} 
  




