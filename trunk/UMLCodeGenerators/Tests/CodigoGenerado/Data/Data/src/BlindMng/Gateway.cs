using System;
using System.Collections.Generic;
// This is the content of the class named "Gateway", which is 
// in the package: "BlindMng", from the "Data" model. 
namespace Data{	
	 	public partial class Gateway{
 
		// Properties from the current class 		 
		
		private ISet <BlindCtrl> windowCtrl;
		private ISet <BlindSensor> windowSensor;
		 
		 
		
		// Utility methods from the current class 
		
		public  virtual  override bool Equals (Object o);
		public  virtual  override int CompareTo (Object o);
		public  virtual  override int GetHashCode ( );
		public  virtual  override Type GetType ( );
		public  virtual  override string ToString( );

		
		// Constructor and methods from the from the current class		
		private void BlindMng_initGateway ( ) {}
		private  virtual void BlindMng_adjustBlind ( Int id, Int degree ) {}
			
	
	
	}
} 
  




