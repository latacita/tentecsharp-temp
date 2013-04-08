using System;
using System.Collections.Generic;
// This is the content of the class named "Clase1", which is 
// in the package: "PruebasColecciones", from the "Data" model. 
namespace Data{	
	 	partial class Clase1{
 
		// Properties from the current class 		 
		
		private IList <int> list;
		public IList <int> List {
			get { return this.list; }
			set { this.list= value; }
		}
		private ISet <int> set;
		public ISet <int> Set {
			get { return this.set; }
			set { this.set= value; }
		}
		private ICollection <int> collection;
		public ICollection <int> Collection {
			get { return this.collection; }
			set { this.collection= value; }
		}
		private IList <int> weirdCase;
		public IList <int> WeirdCase {
			get { return this.weirdCase; }
			set { this.weirdCase= value; }
		}
		 
		 
		
		// Utility methods from the current class 
		
		public  virtual  override bool Equals (Object o);
		public  virtual  override int CompareTo (Object o);
		public  virtual  override int GetHashCode ( );
		public  virtual  override Type GetType ( );
		public  virtual  override string ToString( );

		
		// Constructor and methods from the from the current class		
		private void PruebasColecciones_initClase1 ( ) {}
		public virtual void PruebasColecciones_OperacionConReturnCollection ( IList <Node> CollectionList, int numero ) {}
		public virtual 	ICollection <Node> 
		 PruebasColecciones_OperacionConReturnCollection ( ) {}
			
	
	
	}
} 
  




