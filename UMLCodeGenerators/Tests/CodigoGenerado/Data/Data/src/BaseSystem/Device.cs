using System;
using System.Collections.Generic;
// This is the content of the class named "Device", which is 
// in the package: "BaseSystem", from the "Data" model. 
namespace Data{	
	 	 abstract  class Device{
 
		// Properties from the current class 		 
		
		private  Int  id;
		public  Int  Id {
			get { return this.id; }
			set { this.id= value; }
		}
		 
		 
		
		// Utility methods from the current class 
		
		public  virtual  override bool Equals (Object o);
		public  virtual  override int CompareTo (Object o);
		public  virtual  override int GetHashCode ( );
		public  virtual  override Type GetType ( );
		public  virtual  override string ToString( );

		
		// Constructor and methods from the from the current class		
		private void BaseSystem_initDevice ( ) {}
			
	
	
	}
} 
  




