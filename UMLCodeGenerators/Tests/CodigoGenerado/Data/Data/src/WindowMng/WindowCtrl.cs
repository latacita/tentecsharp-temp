using System;
using System.Collections.Generic;
// This is the content of the class named "WindowCtrl", which is 
// in the package: "WindowMng", from the "Data" model. 
namespace Data{	
	 	public partial class WindowCtrl : Actuator{
 
		// Properties from the current class 		 
		
		private WindowSensor property_0_From_WindowCtrl;
		public WindowSensor Property_0_From_WindowCtrl {
			get { return this.property_0_From_WindowCtrl; }
			set { this.property_0_From_WindowCtrl= value; }
		}
		 
		 
		
		// Utility methods from the current class 
		
		public  virtual  override bool Equals (Object o);
		public  virtual  override int CompareTo (Object o);
		public  virtual  override int GetHashCode ( );
		public  virtual  override Type GetType ( );
		public  virtual  override string ToString( );

		
		// Constructor and methods from the from the current class		
		private void WindowMng_initWindowCtrl ( ) {}
		private  virtual void WindowMng_open ( Int degree ) {}
			
	
	
	}
} 
  




