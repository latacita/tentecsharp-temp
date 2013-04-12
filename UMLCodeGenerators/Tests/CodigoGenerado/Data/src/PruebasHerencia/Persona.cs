using System;
using System.Collections.Generic;
// This is the content of the class named "Persona", which is 
// in the package: "PruebasHerencia", from the "Data" model. 
namespace Data{	
	 	partial class Persona{
 
		// Properties from the current class 		 
		
		private String name;
		public String Name {
			get { return this.name; }
			set { this.name= value; }
		}
		private String surname;
		public String Surname {
			get { return this.surname; }
			set { this.surname= value; }
		}
		 
		 
		
		// Utility methods from the current class 
		
		public  virtual  override bool Equals (Object o);
		public  virtual  override int CompareTo (Object o);
		public  virtual  override int GetHashCode ( );
		public  virtual  override Type GetType ( );
		public  virtual  override string ToString( );

		
		// Constructor and methods from the from the current class		
		private void PruebasHerencia_initPersona ( ) {}
			
	
	
	}
} 
  




