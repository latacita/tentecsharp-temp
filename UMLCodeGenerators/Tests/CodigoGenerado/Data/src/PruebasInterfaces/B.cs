using System;
using System.Collections.Generic;
// This is the content of the class named "B", which is 
// in the package: "PruebasInterfaces", from the "Data" model. 

namespace Data{	
 
		
	partial class B:   Interface_E,  Interface_F,  Interface_G, InterfazHijo2_1{
		// Properties from the current class 
 
		private ISet <E> relationFromClass_E;
		public ISet <E> RelationFromClass_E {
			get { return this.relationFromClass_E; }
			set { this.relationFromClass_E= value; }
		}
 
		private ISet <F> relationFromClass_F;
		public ISet <F> RelationFromClass_F {
			get { return this.relationFromClass_F; }
			set { this.relationFromClass_F= value; }
		}
 
		private ISet <G> relationFromClass_G;
		public ISet <G> RelationFromClass_G {
			get { return this.relationFromClass_G; }
			set { this.relationFromClass_G= value; }
		}
	     
		// Utility methods from the current class 
		
		public  virtual  override bool Equals (Object o);
		public  virtual  override int CompareTo (Object o);
		public  virtual  override int GetHashCode ( );
		public  virtual  override Type GetType ( );
		public  virtual  override string ToString( );
 
		
		// Constructor and methods from the from the current class	
		
		private void PruebasInterfaces_initB ( ) {}
		 
	}
} 