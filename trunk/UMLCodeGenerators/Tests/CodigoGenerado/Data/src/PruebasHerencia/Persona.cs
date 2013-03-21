using System;
using System.Collections.Generic;
// This is the content of the class named "Persona", which is 
// in the package: "PruebasHerencia", from the "Data" model. 
namespace Data{	
	 	public partial class Persona{

		// Properties from the current class 
 
		private String name;
		public String Name {
			get { return this.Name; }
			set { this.Name= value; }
		}
		private String surname;
		public String Surname {
			get { return this.Surname; }
			set { this.Surname= value; }
		}
		
		// Utility methods from the current class 
		
		public virtual override bool Equals (Object o);
		public virtual override int CompareTo (Object o);
		public virtual override int GetHashCode ();
		public virtual override Type GetType ();
		public virtual override string ToString();

		// Constructor and methods from the from the current class		
	        	
		private void PruebasHerencia_initPersona () {}
			
	

	
	
	}
} 
  




