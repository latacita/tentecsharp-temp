using System;
using System.Collections.Generic;
// This is the content of the class named "Node", which is 
// in the package: "BasicGraph", from the "Data" model. 
namespace Data{	
	 	partial class Node{
 
		// Properties from the current class 		 
		
		private int id;
		public int Id {
			get { return this.id; }
			set { this.id= value; }
		}
		 
		 
		
		// Utility methods from the current class 
		
		public  virtual  override bool Equals (Object o);
		public  virtual  override int CompareTo (Object o);
		public  virtual  override int GetHashCode ( );
		public  virtual  override Type GetType ( );
		public  virtual  override string ToString( );

		
		// Constructor and methods from the from the current class		
		private void BasicGraph_initNode ( ) {}
		public virtual void BasicGraph_print ( ) {}
			
	
	
	}
} 
  




