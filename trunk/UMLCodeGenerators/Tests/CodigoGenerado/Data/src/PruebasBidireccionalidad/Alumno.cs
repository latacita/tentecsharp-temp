using System;
using System.Collections.Generic;
// This is the content of the class named "Alumno", which is 
// in the package: "PruebasBidireccionalidad", from the "Data" model. 
namespace Data{	
	 	 partial class Alumno{
 
		// Properties from the current class 		 
		
		private Curso matriculado;
		public Curso Matriculado {
			get { return this.matriculado; }
			set { 
				if (matriculado == null)
				{
					if (!value.getCurso().Contains(this))
					{
						matriculado = value;
						value.addAlumno(this);
					}
					else
					{
						value.removeAlumno(this);
					}
				}
				else
				{
					if (!value.getCurso().Contains(this))
					{
						matriculado = value;
						value.addAlumno(this);
					}
				}
			 }
		}
		 
		
		// Aditional methods

		public void removeMatriculado()
		{
			Matriculado.removeAlumno(this);
			this.SetCurso(null);
		}
		
		public void SetCurso(Curso m)
		{
			this.matriculado = m;
		}
		 
		
		// Utility methods from the current class 
		
		public virtual override bool Equals (Object o);
		public virtual override int CompareTo (Object o);
		public virtual override int GetHashCode ();
		public virtual override Type GetType ();
		public virtual override string ToString();

		
		// Constructor and methods from the from the current class		
		private void PruebasBidireccionalidad_initAlumno () {}
			
	
	
	}
} 
  




