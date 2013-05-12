using System;
using System.Collections.Generic;
// This is the content of the class named "HeaterCtrl", which is 
// in the package: "HeaterMng", from the "Data" model. 
namespace Data{	
	 	public partial class HeaterCtrl : Actuator{
 
		// Properties from the current class 		 
		
		private Thermometer property_0_From_HeaterCtrl;
		public Thermometer Property_0_From_HeaterCtrl {
			get { return this.property_0_From_HeaterCtrl; }
			set { this.property_0_From_HeaterCtrl= value; }
		}
		 
		 
		
		// Utility methods from the current class 
		
		public  virtual  override bool Equals (Object o);
		public  virtual  override int CompareTo (Object o);
		public  virtual  override int GetHashCode ( );
		public  virtual  override Type GetType ( );
		public  virtual  override string ToString( );

		
		// Constructor and methods from the from the current class		
		private void HeaterMng_initHeaterCtrl ( ) {}
		private  virtual void HeaterMng_setValue ( double temp ) {}
			
	
	
	}
} 
  




