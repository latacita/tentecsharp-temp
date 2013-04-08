using System;
using System.Collections.Generic;
// This is the content of the class named "ClaseHijo1", which is 
// in the package: "PruebasInterfaces", from the "Data" model. 

namespace Data{	
 
		
	partial class ClaseHijo1:   Interface_ClasePadre1_1,  Interface_ClasePadre1_2{
		// Properties from the current class 
 
		private ISet <ClasePadre1_2> relationFromClass_ClasePadre1_2;
		public ISet <ClasePadre1_2> RelationFromClass_ClasePadre1_2 {
			get { return this.relationFromClass_ClasePadre1_2; }
			set { this.relationFromClass_ClasePadre1_2= value; }
		}
 
		private ISet <ClasePadre1_1> relationFromClass_ClasePadre1_1;
		public ISet <ClasePadre1_1> RelationFromClass_ClasePadre1_1 {
			get { return this.relationFromClass_ClasePadre1_1; }
			set { this.relationFromClass_ClasePadre1_1= value; }
		}
	     
		// Utility methods from the current class 
		
		public  virtual  override bool Equals (Object o);
		public  virtual  override int CompareTo (Object o);
		public  virtual  override int GetHashCode ( );
		public  virtual  override Type GetType ( );
		public  virtual  override string ToString( );
 
		
		// Constructor and methods from the from the current class	
		
		private void PruebasInterfaces_initClaseHijo1 ( ) {}
		public virtual 	int 
		 PruebasInterfaces_operacionHijo ( ) {}
		 
	}
} 