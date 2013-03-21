using System;
using System.Collections.Generic;
// This is the content of the class named "Edge", which is 
// in the package: "WeightGraph", from the "Data" model. 
namespace Data{	
	 	public partial class Edge{

		// Properties from the current class 
 
		private float w;
		public float W {
			get { return this.w; }
			set { this.w= value; }
		}
		
		// Utility methods from the current class 
		
		public virtual override bool Equals (Object o);
		public virtual override int CompareTo (Object o);
		public virtual override int GetHashCode ();
		public virtual override Type GetType ();
		public virtual override string ToString();

		// Constructor and methods from the from the current class		
	        	
		private void WeightGraph_initEdge () {}
		public virtual void WeightGraph_print (	 
		) {}
			
	

	
	
	}
} 
  




