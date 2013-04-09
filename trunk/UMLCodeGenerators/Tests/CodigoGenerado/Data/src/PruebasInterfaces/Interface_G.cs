using System;
using System.Collections.Generic; 

// This is the content of the interface named "G", which is 
// in the package: "PruebasInterfaces",  from the "Data" model. 
namespace Data{	
	partial interface Interface_G{ 
		// Properties from the current class 		 
		private String atribG;
		public String AtribG {
			get { return this.atribG; }
			set { this.atribG= value; }
		}
				
		 
	}
} 
  