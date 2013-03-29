using System;
using System.Collections.Generic;
// This is the content of the class named "Trabajador", which is 
// in the package: "PruebasBidireccionalidad", from the "Data" model. 
namespace Data{	
	 	 partial class Trabajador{
 
		// Properties from the current class 		 
		
		ISet <Proyecto> proyectos = new HashSet<Proyecto>(); 
		
		public void addProyecto(Proyecto a)
		{
			if (! this.proyectos.Contains(a))
			{
				this.proyectos.Add(a);
				a.addTrabajador(this);
			}
		}
		public void removeProyecto(Proyecto a)
		{
			if (this.proyectos.Contains(a))
			{
				this.proyectos.Remove(a);
				a.removeTrabajador(this);
			}
		}
		public ISet <Proyecto> getProyecto()
		{
			return this.proyectos;
		}
		 
		
		// Utility methods from the current class 
		
		public virtual override bool Equals (Object o);
		public virtual override int CompareTo (Object o);
		public virtual override int GetHashCode ();
		public virtual override Type GetType ();
		public virtual override string ToString();

		
		// Constructor and methods from the from the current class		
		private void PruebasBidireccionalidad_initTrabajador () {}
			
	
	
	}
} 
  




