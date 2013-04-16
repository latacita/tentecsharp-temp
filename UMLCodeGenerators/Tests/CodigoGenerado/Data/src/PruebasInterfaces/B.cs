using System;
using System.Collections.Generic; 
 
// This is the content of the class named "B", which is 
// in the package: "PruebasInterfaces", from the "Data" model. 
namespace Data{	
	partial class B:  Interface_B,  Interface_E,  Interface_F{
		private ISet <E> relationFromClass_E;
		public ISet <E> RelationFromClass_E {
			get { return this.relationFromClass_E; }
			set { this.relationFromClass_E=value; }
		}
		private ISet <F> relationFromClass_F;
		public ISet <F> RelationFromClass_F {
			get { return this.relationFromClass_F; }
			set { this.relationFromClass_F=value; }
		}
		  
		// Utility methods from the current class  
		public  virtual  override bool Equals (Object o);
		public  virtual  override int CompareTo (Object o);
		public  virtual  override int GetHashCode ( );
		public  virtual  override Type GetType ( );
		public  virtual  override string ToString( );

		// Constructor and methods from the from the current interface		
		private void PruebasInterfaces_initB ( ) {}
		public virtual void PruebasInterfaces_oper ( ) {}
			
	}
} 