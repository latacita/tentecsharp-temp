using System;
using System.Collections.Generic;
// This is the content of the class named "Edge", which is 
// in the package: "Color", from the "Data" model. 
namespace Data{	
	 	 partial class Edge{
 
		// Properties from the current class 		 
		
		private Color color;
		public Color Color {
			get { return this.color; }
			set { this.color= value; }
		}
		 
		 
		
		// Utility methods from the current class 
		
		public virtual override bool Equals (Object o);
		public virtual override int CompareTo (Object o);
		public virtual override int GetHashCode ();
		public virtual override Type GetType ();
		public virtual override string ToString();

		
		// Constructor and methods from the from the current class		
		private void Color_initEdge () {}
		public virtual void Color_print (	 
		) {}
			
	
	
	}
} 
  




