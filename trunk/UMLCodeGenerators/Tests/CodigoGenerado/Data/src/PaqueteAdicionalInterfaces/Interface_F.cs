using System;
using System.Collections.Generic; 

// This is the content of the interface named "F", which is 
// in the package: "PaqueteAdicionalInterfaces",  from the "Data" model. 
namespace Data{	
	partial interface Interface_F{ 
		// Properties from the current interface 		 
		private String unnamed1;
		public String Unnamed1 {
			get { return this.unnamed1; }
			set { this.unnamed1= value; }
		}
				
		 
		
		// Utility methods from the current class 		
		public  virtual  override bool Equals (Object o);
		public  virtual  override int CompareTo (Object o);
		public  virtual  override int GetHashCode ( );
		public  virtual  override Type GetType ( );
		public  virtual  override string ToString( );
 		
		// Constructor and methods from the from the current class			
		private void PaqueteAdicionalInterfaces_initF ( ) {}
		 
	}
} 
  