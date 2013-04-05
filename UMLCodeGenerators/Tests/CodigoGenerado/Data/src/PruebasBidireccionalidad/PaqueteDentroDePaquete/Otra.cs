using System;
using System.Collections.Generic;
// This is the content of the class named "Otra", which is 
// in the package: "PaqueteDentroDePaquete", from the "Data" model. 
namespace Data{	
	 	partial class Otra{
 
		// Properties from the current class 		 
		
		ISet <Dentro> aaa = new HashSet<Dentro>(); 
		
		public void addDentro(Dentro a)
		{
			if (a.Deq != this || a.Deq == null)
			{
				this.aaa.Remove(a);
			}
			else
			{
				if (! this.aaa.Contains(a))
				{
					this.aaa.Add(a);
				}
			}
		}
		public void removeDentro(Dentro a)
		{
			if (a.Deq == this)
			{
				this.aaa.Remove(a);
				a.SetOtra(null);
			}
		}
		public ISet <Dentro> getOtra()
		{
			return this.aaa;
		}
		 
		
		// Utility methods from the current class 
		
		public virtual override bool Equals (Object o);
		public virtual override int CompareTo (Object o);
		public virtual override int GetHashCode ();
		public virtual override Type GetType ();
		public virtual override string ToString();

		
		// Constructor and methods from the from the current class		
		private void PaqueteDentroDePaquete_initOtra () {}
			
	
	
	}
} 
  




