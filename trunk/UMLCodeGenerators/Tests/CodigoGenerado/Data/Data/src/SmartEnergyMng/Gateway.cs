using System;
using System.Collections.Generic;
// This is the content of the class named "Gateway", which is 
// in the package: "SmartEnergyMng", from the "Data" model. 
namespace Data{	
	 	public partial class Gateway{
 
		// Properties from the current class 		 
		
		 
		 
		
		// Utility methods from the current class 
		
		public  virtual  override bool Equals (Object o);
		public  virtual  override int CompareTo (Object o);
		public  virtual  override int GetHashCode ( );
		public  virtual  override Type GetType ( );
		public  virtual  override string ToString( );

		
		// Constructor and methods from the from the current class		
		private void SmartEnergyMng_initGateway ( ) {}
		private  virtual void SmartEnergyMng_adjustTemperature ( Int id_heater, double temperature ) {}
		protected  virtual void SmartEnergyMng_findEmptyTime ( ) {}
		protected  virtual void SmartEnergyMng_checkTime ( ) {}
			
	
	
	}
} 
  




