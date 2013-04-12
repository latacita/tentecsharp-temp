using System;
using System.Collections.Generic; 
 
// This is the content of the class named "C", which is 
// in the package: "PruebasInterfaces", from the "Data" model. 
namespace Data{	
	partial class C:  Interface_C, D{
		  
		// Utility methods from the current class  
		public  virtual  override bool Equals (Object o);
		public  virtual  override int CompareTo (Object o);
		public  virtual  override int GetHashCode ( );
		public  virtual  override Type GetType ( );
		public  virtual  override string ToString( );

		// Constructor and methods from the from the current interface		
		private void PruebasInterfaces_initC ( ) {}
			
	}
} 