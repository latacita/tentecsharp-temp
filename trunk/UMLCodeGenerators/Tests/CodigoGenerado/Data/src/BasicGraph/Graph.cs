using System;
using System.Collections.Generic;
// This is the content of the class named "Graph", which is 
// in the package: "BasicGraph", from the "Data" model. 
namespace Data{	
	 	partial class Graph{
 
		// Properties from the current class 		 
		
		private ISet <Node> nodes;
		public ISet <Node> Nodes {
			get { return this.nodes; }
			set { this.nodes= value; }
		}
		private ISet <Edge> edges;
		public ISet <Edge> Edges {
			get { return this.edges; }
			set { this.edges= value; }
		}
		 
		 
		
		// Utility methods from the current class 
		
		public  virtual  override bool Equals (Object o);
		public  virtual  override int CompareTo (Object o);
		public  virtual  override int GetHashCode ( );
		public  virtual  override Type GetType ( );
		public  virtual  override string ToString( );

		
		// Constructor and methods from the from the current class		
		private void BasicGraph_initGraph ( ) {}
		public virtual void BasicGraph_print ( ) {}
		public virtual void BasicGraph_addEdge ( Node n, Node m ) {}
			
	
	
	}
} 
  




