using System;
using System.Collections.Generic;
// This is the content of the class named "Gateway", which is 
// in the package: "WindowMng", from the "Data" model. 
namespace Data{	
	 	public partial class Gateway{
 
		// Properties from the current class 		 
		
		private ISet <WindowCtrl> windowCtrl;
		private ISet <WindowSensor> windowSensor;
		 
		 
		
		// Utility methods from the current class 
		
		public  virtual  override bool Equals (Object o);
		public  virtual  override int CompareTo (Object o);
		public  virtual  override int GetHashCode ( );
		public  virtual  override Type GetType ( );
		public  virtual  override string ToString( );

		
		// Constructor and methods from the from the current class		
		private void WindowMng_initGateway ( ) {}
		private  virtual void WindowMng_openWindow ( Int id, Int degree ) {}
			
	
	
	}
} 
  




