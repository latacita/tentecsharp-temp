using System;
using System.Collections.Generic;
// This is the content of the class named "A", which is 
// in the package: "PruebasInterfaces", from the "Data" model. 

namespace Data{	
 
		
	partial class A:   Interface_B,  Interface_C{
		// Properties from the current class 
 
		private ISet <B> relationFromClass_B;
		public ISet <B> RelationFromClass_B {
			get { return this.relationFromClass_B; }
			set { this.relationFromClass_B= value; }
		}
 
		private ISet <C> relationFromClass_C;
		public ISet <C> RelationFromClass_C {
			get { return this.relationFromClass_C; }
			set { this.relationFromClass_C= value; }
		}
	     
		// Utility methods from the current class 
		
		public  virtual  override bool Equals (Object o);
		public  virtual  override int CompareTo (Object o);
		public  virtual  override int GetHashCode ( );
		public  virtual  override Type GetType ( );
		public  virtual  override string ToString( );
 
		
		// Constructor and methods from the from the current class	
		
		private void PruebasInterfaces_initA ( ) {}
		public virtual 	ICollection <int> 
		 PruebasInterfaces_operacionG ( ) {}
		 
	}
} 