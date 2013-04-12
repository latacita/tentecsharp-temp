using System;
using System.Collections.Generic;
// This is the content of the class named "ClaseHijo", which is 
// in the package: "PruebasInterfaces", from the "Data" model. 

namespace Data{	
 
		
	partial class ClaseHijo:   Interface_ClasePadre1,  Interface_ClasePadre2 {
		// Properties from the current class
		private ISet <ClasePadre2> relationFromClass_ClasePadre2;
		public ISet <ClasePadre2> RelationFromClass_ClasePadre2 {
			get { return this.relationFromClass_ClasePadre2; }
			set { this.relationFromClass_ClasePadre2=value; }
		}
		private ISet <ClasePadre1> relationFromClass_ClasePadre1;
		public ISet <ClasePadre1> RelationFromClass_ClasePadre1 {
			get { return this.relationFromClass_ClasePadre1; }
			set { this.relationFromClass_ClasePadre1=value; }
		}
		
		private float hijo;
		public float Hijo {
			get { return this.hijo; }
			set { this.hijo= value; }
		}
		 
		  
		
		// Utility methods from the current class 
		
		public  virtual  override bool Equals (Object o);
		public  virtual  override int CompareTo (Object o);
		public  virtual  override int GetHashCode ( );
		public  virtual  override Type GetType ( );
		public  virtual  override string ToString( );
 
		
		// Constructor and methods from the from the current class	
		
		private void PruebasInterfaces_initClaseHijo ( ) {}
		public virtual int PruebasInterfaces_operacionHijo ( ) {}
		 
	}
} 