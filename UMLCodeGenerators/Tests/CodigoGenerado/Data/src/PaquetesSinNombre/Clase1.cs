using System;
using System.Collections.Generic;
// This is the content of the class named "Clase1", which is 
// in the package: "PaquetesSinNombre", from the "Data" model. 
namespace Data{	
	 	partial class Clase1{
 
		// Properties from the current class 		 
		
		private ISet <Clase2> a;
		public ISet <Clase2> A {
			get { return this.a; }
			set { this.a= value; }
		}
		 
		 
		
		// Utility methods from the current class 
		
		public  virtual  override bool Equals (Object o);
		public  virtual  override int CompareTo (Object o);
		public  virtual  override int GetHashCode ( );
		public  virtual  override Type GetType ( );
		public  virtual  override string ToString( );

		
		// Constructor and methods from the from the current class		
		private void PaquetesSinNombre_initClase1 ( ) {}
			
	
	
	}
} 
  




