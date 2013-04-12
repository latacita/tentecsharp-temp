using System;
using System.Collections.Generic;
// This is the content of the class named "Node", which is 
// in the package: "Recursive", from the "Data" model. 
namespace Data{	
	 	partial class Node{
 
		// Properties from the current class 		 
		
		private Graph childGraph;
		public Graph ChildGraph {
			get { return this.childGraph; }
			set { this.childGraph= value; }
		}
		 
		 
		
		// Utility methods from the current class 
		
		public  virtual  override bool Equals (Object o);
		public  virtual  override int CompareTo (Object o);
		public  virtual  override int GetHashCode ( );
		public  virtual  override Type GetType ( );
		public  virtual  override string ToString( );

		
		// Constructor and methods from the from the current class		
		private void Recursive_initNode ( ) {}
		public virtual void Recursive_print ( ) {}
			
	
	
	}
} 
  




