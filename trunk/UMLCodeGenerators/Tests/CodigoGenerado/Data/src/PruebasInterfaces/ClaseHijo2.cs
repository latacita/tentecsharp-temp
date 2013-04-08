using System;
using System.Collections.Generic;
// This is the content of the class named "ClaseHijo2", which is 
// in the package: "PruebasInterfaces", from the "Data" model. 

namespace Data{	
 
		
	partial class ClaseHijo2:   Interface_ClasePadre2_5,  Interface_ClasePadre2_3,  Interface_ClasePadre2_4, InterfazHijo2_1, InterfazHijo2_2{
		// Properties from the current class 
 
		private ISet <ClasePadre2_5> relationFromClass_ClasePadre2_5;
		public ISet <ClasePadre2_5> RelationFromClass_ClasePadre2_5 {
			get { return this.relationFromClass_ClasePadre2_5; }
			set { this.relationFromClass_ClasePadre2_5= value; }
		}
 
		private ISet <ClasePadre2_4> relationFromClass_ClasePadre2_4;
		public ISet <ClasePadre2_4> RelationFromClass_ClasePadre2_4 {
			get { return this.relationFromClass_ClasePadre2_4; }
			set { this.relationFromClass_ClasePadre2_4= value; }
		}
 
		private ISet <ClasePadre2_3> relationFromClass_ClasePadre2_3;
		public ISet <ClasePadre2_3> RelationFromClass_ClasePadre2_3 {
			get { return this.relationFromClass_ClasePadre2_3; }
			set { this.relationFromClass_ClasePadre2_3= value; }
		}
	     
		// Utility methods from the current class 
		
		public  virtual  override bool Equals (Object o);
		public  virtual  override int CompareTo (Object o);
		public  virtual  override int GetHashCode ( );
		public  virtual  override Type GetType ( );
		public  virtual  override string ToString( );
 
		
		// Constructor and methods from the from the current class	
		
		private void PruebasInterfaces_initClaseHijo2 ( ) {}
		 
	}
} 