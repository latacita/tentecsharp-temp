using System;
using System.Collections.Generic;
// This is the content of the class named "Hombre", which is 
// in the package: "PruebasBidireccionalidad", from the "Data" model. 
namespace Data{	
	 	partial class Hombre{
 
		// Properties from the current class 		 
		
		private Mujer esposa;
		public Mujer Esposa {
			get { return this.esposa; }
			set { 

				if (Esposa != null)
				{
					if (value.Marido != null)
					{
						if (this != value.Marido)
						{
							value.Marido.SetEsposa_aditional(null);
							value.SetMarido_aditional(null);
							this.Esposa.SetMarido_aditional(null);
							this.SetEsposa_aditional(null);
						
							this.SetEsposa_aditional(value);
							value.SetMarido_aditional(this);
						}
					}
					else
					{
						this.Esposa.SetMarido_aditional(null);
						this.SetEsposa_aditional(null);
						this.SetEsposa_aditional(value);
						value.SetMarido_aditional(this);
					}
				}
				else
				{
					if (value.Marido != null)
					{
						value.Marido.SetEsposa_aditional(null);
						value.SetMarido_aditional(null);
						this.SetEsposa_aditional(value);
						value.SetMarido_aditional(this);
					}
					else
					{
						this.SetEsposa_aditional(value);
						value.SetMarido_aditional(this);
					}
				}
			 }
		}
		 
		
		// Aditional set method to control bidirectional relationship

		public void SetEsposa_aditional(Mujer m)
		{
			 this.esposa=m;
		}
		 
		
		// Utility methods from the current class 
		
		public  virtual  override bool Equals (Object o);
		public  virtual  override int CompareTo (Object o);
		public  virtual  override int GetHashCode ( );
		public  virtual  override Type GetType ( );
		public  virtual  override string ToString( );

		
		// Constructor and methods from the from the current class		
		private void PruebasBidireccionalidad_initHombre ( ) {}
			
	
	
	}
} 
  




