using System;
using System.Collections.Generic;
// This is the content of the class named "Sensor", which is 
// in the package: "HeaterMng", from the "Data" model. 
namespace Data{	
	 	 abstract  class Sensor : Device{
 
		// Properties from the current class 		 
		
		 
		 
		
		// Utility methods from the current class 
		
		public  virtual  override bool Equals (Object o);
		public  virtual  override int CompareTo (Object o);
		public  virtual  override int GetHashCode ( );
		public  virtual  override Type GetType ( );
		public  virtual  override string ToString( );

		
		// Constructor and methods from the from the current class		
		private void HeaterMng_initSensor ( ) {}
		private  virtual void HeaterMng_getValue ( ) {}
			
	
	
	}
} 
  




