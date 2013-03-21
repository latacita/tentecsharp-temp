using System;
using System.Collections.Generic;
// This is the content of the class named "Color", which is 
// in the package: "Color", from the "Data" model. 
namespace Data{	
	 	public partial class Color{

		// Properties from the current class 
 
		private int val;
		public int Val {
			get { return this.val; }
			set { this.val= value; }
		}
		
		// Utility methods from the current class 
		
		public virtual override bool Equals (Object o);
		public virtual override int CompareTo (Object o);
		public virtual override int GetHashCode ();
		public virtual override Type GetType ();
		public virtual override string ToString();

		// Constructor and methods from the from the current class		
	        	
		private void Color_initColor () {}
		public virtual void Color_setDisplayColor (	 Color c 
		) {}
			
	

	
	
	}
} 
  




