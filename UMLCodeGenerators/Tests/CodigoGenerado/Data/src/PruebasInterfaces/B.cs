using System;
using System.Collections.Generic; 
 
// This is the content of the class named "B", which is 
// in the package: "PruebasInterfaces", from the "Data" model. 
namespace Data{	
	partial class B:  Interface_B,  Interface_E,  Interface_F{
		// Utility methods from the current class  
		public  virtual  override bool Equals (Object o);
		public  virtual  override int CompareTo (Object o);
		public  virtual  override int GetHashCode ( );
		public  virtual  override Type GetType ( );
		public  virtual  override string ToString( );

		// Constructor and methods from the from the current interface		
		private void PruebasInterfaces_initB ( ) {}
			
	}
} 