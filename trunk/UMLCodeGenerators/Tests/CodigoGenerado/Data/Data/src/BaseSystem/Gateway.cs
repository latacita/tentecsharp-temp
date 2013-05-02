using System;
using System.Collections.Generic;
// This is the content of the class named "Gateway", which is 
// in the package: "BaseSystem", from the "Data" model. 
namespace Data{	
	 	public partial class Gateway{
 
		// Properties from the current class 		 
		
		private ISet <Sensor> sensors;
		private ISet <Actuator> actuators;
		private ISet <Floor> floors;
		private Time time;
		public Time Time {
			get { return this.time; }
			set { this.time= value; }
		}
		 
		 
		
		// Utility methods from the current class 
		
		public  virtual  override bool Equals (Object o);
		public  virtual  override int CompareTo (Object o);
		public  virtual  override int GetHashCode ( );
		public  virtual  override Type GetType ( );
		public  virtual  override string ToString( );

		
		// Constructor and methods from the from the current class		
		private void BaseSystem_initGateway ( ) {}
		private  virtual void BaseSystem_initializeAll ( ) {}
		private  virtual void BaseSystem_checkAll ( ) {}
		private  virtual void BaseSystem_switchDown ( ) {}
			
	
	
	}
} 
  




