using System;
using System.Collections.Generic;
// This is the content of the class named "Floor", which is 
// in the package: "BaseSystem", from the "Data" model. 
namespace Data{	
	 	public partial class Floor{
 
		// Properties from the current class 		 
		
		private ISet <Room> rooms;
		 
		 
		
		// Utility methods from the current class 
		
		public  virtual  override bool Equals (Object o);
		public  virtual  override int CompareTo (Object o);
		public  virtual  override int GetHashCode ( );
		public  virtual  override Type GetType ( );
		public  virtual  override string ToString( );

		
		// Constructor and methods from the from the current class		
		private void BaseSystem_initFloor ( ) {}
			
	
	
	}
} 
  




