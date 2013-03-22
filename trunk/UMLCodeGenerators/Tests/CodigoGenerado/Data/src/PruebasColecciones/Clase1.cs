using System;
using System.Collections.Generic;
// This is the content of the class named "Clase1", which is 
// in the package: "PruebasColecciones", from the "Data" model. 
namespace Data{	
	 	public partial class Clase1{

		// Properties from the current class 
 
		private IList <int> list;
		public IList <int> List {
			get { return this.List; }
			set { this.List= value; }
		}
		private ISet <int> set;
		public ISet <int> Set {
			get { return this.Set; }
			set { this.Set= value; }
		}
		private ICollection <int> collection;
		public ICollection <int> Collection {
			get { return this.Collection; }
			set { this.Collection= value; }
		}
		private IList <int> weirdCase;
		public IList <int> WeirdCase {
			get { return this.WeirdCase; }
			set { this.WeirdCase= value; }
		}
		
		// Utility methods from the current class 
		
		public virtual override bool Equals (Object o);
		public virtual override int CompareTo (Object o);
		public virtual override int GetHashCode ();
		public virtual override Type GetType ();
		public virtual override string ToString();

		// Constructor and methods from the from the current class		
	        	
		private void PruebasColecciones_initClase1 () {}
		public virtual void PruebasColecciones_OperacionConParametroCollection (	 IList <Node> CollectionList, int numero 
		) {}
		public virtual 	ICollection <Node> 
		 PruebasColecciones_OperacionConReturnCollection (	 
		) {}
			
	

	
	
	}
} 
  




