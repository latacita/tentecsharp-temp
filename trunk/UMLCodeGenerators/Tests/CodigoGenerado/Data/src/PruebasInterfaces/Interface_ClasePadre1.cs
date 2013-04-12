using System;
using System.Collections.Generic; 

// This is the content of the interface named "ClasePadre1", which is 
// in the package: "PruebasInterfaces",  from the "Data" model. 
namespace Data{	
	partial interface Interface_ClasePadre1{ 
		// Properties from the current interface 		 
		private int padre1;
		public int Padre1 {
			get { return this.padre1; }
			set { this.padre1= value; }
		}
				
		 
		
		// Utility methods from the current class 		
		public  virtual  override bool Equals (Object o);
		public  virtual  override int CompareTo (Object o);
		public  virtual  override int GetHashCode ( );
		public  virtual  override Type GetType ( );
		public  virtual  override string ToString( );
 		
		// Constructor and methods from the from the current class			
		private void PruebasInterfaces_initClasePadre1 ( ) {}
		public virtual void PruebasInterfaces_operacionPadre1 ( ) {}
		 
	}
} 
  