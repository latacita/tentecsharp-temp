using System;
using System.Collections.Generic;
// This is the content of the class named "BlindCtrl", which is 
// in the package: "BlindMng", from the "Data" model. 
namespace Data{	
	 	public partial class BlindCtrl : Actuator{
 
		// Properties from the current class 		 
		
		private  Int  id_window;
		public  Int  Id_window {
			get { return this.id_window; }
			set { this.id_window= value; }
		}
		 
		 
		
		// Utility methods from the current class 
		
		public  virtual  override bool Equals (Object o);
		public  virtual  override int CompareTo (Object o);
		public  virtual  override int GetHashCode ( );
		public  virtual  override Type GetType ( );
		public  virtual  override string ToString( );

		
		// Constructor and methods from the from the current class		
		private void BlindMng_initBlindCtrl ( ) {}
		private  virtual void BlindMng_open ( Int degree ) {}
			
	
	
	}
} 
  




