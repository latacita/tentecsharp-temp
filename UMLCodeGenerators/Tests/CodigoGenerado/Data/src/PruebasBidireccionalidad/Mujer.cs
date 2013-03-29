using System;
using System.Collections.Generic;
// This is the content of the class named "Mujer", which is 
// in the package: "PruebasBidireccionalidad", from the "Data" model. 
namespace Data{	
	 	 partial class Mujer{
 
		// Properties from the current class 		 
		
		private Hombre marido;
		public Hombre Marido {
			get { return this.marido; }
			set { 

				if (Marido != null)
				{
					if (value.Esposa != null)
					{
						if (this != value.Esposa)
						{
							value.Esposa.SetMarido_aditional(null);
							value.SetEsposa_aditional(null);
							this.Marido.SetEsposa_aditional(null);
							this.SetMarido_aditional(null);
						
							this.SetMarido_aditional(value);
							value.SetEsposa_aditional(this);
						}
					}
					else
					{
						this.Marido.SetEsposa_aditional(null);
						this.SetMarido_aditional(null);
						this.SetMarido_aditional(value);
						value.SetEsposa_aditional(this);
					}
				}
				else
				{
					if (value.Esposa != null)
					{
						value.Esposa.SetMarido_aditional(null);
						value.SetEsposa_aditional(null);
						this.SetMarido_aditional(value);
						value.SetEsposa_aditional(this);
					}
					else
					{
						this.SetMarido_aditional(value);
						value.SetEsposa_aditional(this);
					}
				}
			 }
		}
		 
		
		// Aditional set method to control bidirectional relationship

		public void SetMarido_aditional(Hombre m)
		{
			 this.marido=m;
		}
		 
		
		// Utility methods from the current class 
		
		public virtual override bool Equals (Object o);
		public virtual override int CompareTo (Object o);
		public virtual override int GetHashCode ();
		public virtual override Type GetType ();
		public virtual override string ToString();

		
		// Constructor and methods from the from the current class		
		private void PruebasBidireccionalidad_initMujer () {}
			
	
	
	}
} 
  




