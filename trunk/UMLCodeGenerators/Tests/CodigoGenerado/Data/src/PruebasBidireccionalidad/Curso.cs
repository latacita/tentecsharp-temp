using System;
using System.Collections.Generic;
// This is the content of the class named "Curso", which is 
// in the package: "PruebasBidireccionalidad", from the "Data" model. 
namespace Data{	
	 	partial class Curso{
 
		// Properties from the current class 		 
		
		ISet <Alumno> alumnos = new HashSet<Alumno>(); 
		
		public void addAlumno(Alumno a)
		{
			if (a.Matriculado != this || a.Matriculado == null)
			{
				this.alumnos.Remove(a);
			}
			else
			{
				if (! this.alumnos.Contains(a))
				{
					this.alumnos.Add(a);
				}
			}
		}
		public void removeAlumno(Alumno a)
		{
			if (a.Matriculado == this)
			{
				this.alumnos.Remove(a);
				a.SetCurso(null);
			}
		}
		public ISet <Alumno> getCurso()
		{
			return this.alumnos;
		}
		 
		
		// Utility methods from the current class 
		
		public  virtual  override bool Equals (Object o);
		public  virtual  override int CompareTo (Object o);
		public  virtual  override int GetHashCode ( );
		public  virtual  override Type GetType ( );
		public  virtual  override string ToString( );

		
		// Constructor and methods from the from the current class		
		private void PruebasBidireccionalidad_initCurso ( ) {}
			
	
	
	}
} 
  




