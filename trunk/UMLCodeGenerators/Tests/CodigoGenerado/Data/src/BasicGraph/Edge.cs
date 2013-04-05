using System;
using System.Collections.Generic;
// This is the content of the class named "Edge", which is 
// in the package: "BasicGraph", from the "Data" model. 
namespace Data{	
	 	partial class Edge{
 
		// Properties from the current class 		 
		
		private Node a;
		public Node A {
			get { return this.a; }
			set { this.a= value; }
		}
		private Node b;
		public Node B {
			get { return this.b; }
			set { this.b= value; }
		}
		 
		 
		
		// Utility methods from the current class 
		
		public virtual override bool Equals (Object o);
		public virtual override int CompareTo (Object o);
		public virtual override int GetHashCode ();
		public virtual override Type GetType ();
		public virtual override string ToString();

		
		// Constructor and methods from the from the current class		
		private void BasicGraph_initEdge () {}
		public  virtual void BasicGraph_print (	 
		) {}
			
	
	
	}
} 
  




