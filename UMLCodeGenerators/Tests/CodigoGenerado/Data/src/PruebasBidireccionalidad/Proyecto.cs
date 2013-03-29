using System;
using System.Collections.Generic;
// This is the content of the class named "Proyecto", which is 
// in the package: "PruebasBidireccionalidad", from the "Data" model. 
namespace Data{	
	 	 partial class Proyecto{
 
		// Properties from the current class 		 
		
		ISet <Trabajador> trabajadores = new HashSet<Trabajador>(); 
		
		public void addTrabajador(Trabajador a)
		{
			if (! this.trabajadores.Contains(a))
			{
				this.trabajadores.Add(a);
				a.addProyecto(this);
			}
		}
		public void removeTrabajador(Trabajador a)
		{
			if (this.trabajadores.Contains(a))
			{
				this.trabajadores.Remove(a);
				a.removeProyecto(this);
			}
		}
		public ISet <Trabajador> getTrabajador()
		{
			return this.trabajadores;
		}
		 
		
		// Utility methods from the current class 
		
		public virtual override bool Equals (Object o);
		public virtual override int CompareTo (Object o);
		public virtual override int GetHashCode ();
		public virtual override Type GetType ();
		public virtual override string ToString();

		
		// Constructor and methods from the from the current class		
		private void PruebasBidireccionalidad_initProyecto () {}
			
	
	
	}
} 
  




