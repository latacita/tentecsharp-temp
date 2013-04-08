using System;
using System.Collections.Generic; 

// This is the content of the interface named "E", which is 
// in the package: "PruebasInterfaces",  from the "Data" model. 
namespace Data{	
	partial interface Interface_E{ 
		// Properties from the current class 		 
		private ISet <A> atributoDeAEnE;
		public ISet <A> AtributoDeAEnE {
			get { return this.atributoDeAEnE; }
			set { this.atributoDeAEnE= value; }
		}
				
		 
	}
} 
  