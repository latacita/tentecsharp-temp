using System;
using System.Collections.Generic;
// This is the content of the class named "Dentro", which is 
// in the package: "PaqueteDentroDePaquete", from the "Data" model. 
namespace Data{	
	 	partial class Dentro{
 
		// Properties from the current class 		 
		
		private Otra deq;
		public Otra Deq {
			get { return this.deq; }
			set { 
				if (deq == null)
				{
					if (!value.getOtra().Contains(this))
					{
						deq = value;
						value.addDentro(this);
					}
					else
					{
						value.removeDentro(this);
					}
				}
				else
				{
					if (!value.getOtra().Contains(this))
					{
						deq = value;
						value.addDentro(this);
					}
				}
			 }
		}
		 
		
		// Aditional methods

		public void removeDeq()
		{
			Deq.removeDentro(this);
			this.SetOtra(null);
		}
		
		public void SetOtra(Otra m)
		{
			this.deq = m;
		}
		 
		
		// Utility methods from the current class 
		
		public  virtual  override bool Equals (Object o);
		public  virtual  override int CompareTo (Object o);
		public  virtual  override int GetHashCode ( );
		public  virtual  override Type GetType ( );
		public  virtual  override string ToString( );

		
		// Constructor and methods from the from the current class		
		private void PaqueteDentroDePaquete_initDentro ( ) {}
			
	
	
	}
} 
  




