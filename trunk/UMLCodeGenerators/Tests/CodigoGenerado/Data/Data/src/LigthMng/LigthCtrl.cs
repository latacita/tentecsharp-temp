using System;
using System.Collections.Generic;
// This is the content of the class named "LigthCtrl", which is 
// in the package: "LigthMng", from the "Data" model. 
namespace Data{	
	 	public partial class LigthCtrl : Actuator{
 
		// Properties from the current class 		 
		
		 
		 
		
		// Utility methods from the current class 
		
		public  virtual  override bool Equals (Object o);
		public  virtual  override int CompareTo (Object o);
		public  virtual  override int GetHashCode ( );
		public  virtual  override Type GetType ( );
		public  virtual  override string ToString( );

		
		// Constructor and methods from the from the current class		
		private void LigthMng_initLigthCtrl ( ) {}
		private  virtual void LigthMng_switchOn ( Int ligthing ) {}
			
	
	
	}
} 
  




