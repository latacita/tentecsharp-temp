using System;
using System.Collections.Generic;
// This is the content of the class named "Gateway", which is 
// in the package: "MyHome", from the "My_Data" model. 
namespace My_Data{
	public class Gateway{ 
		// Constructor and methods from the from the current class		
		public virtual void Gateway ( ){
			BaseSystem_initGateway ( );
			HeaterMng_initGateway ( );
			WindowMng_initGateway ( );
			SmartEnergyMng_initGateway ( );
		}
		public virtual void initializeAll ( ){
			BaseSystem_initializeAll ( );
		}
		public virtual void switchDown ( ){
			BaseSystem_switchDown ( );
		}
		public virtual void checkAll ( ){
			BaseSystem_checkAll ( );
		}
		public virtual void heaterAdjustTemperature ( Int id, double temp ){
			HeaterMng_heaterAdjustTemperature ( id, temp );
		}
		protected virtual void findEmptyTime ( ){
			SmartEnergyMng_findEmptyTime ( );
		}
		public virtual void openWindow ( Int id, Int degree ){
			WindowMng_openWindow ( id, degree );
		}
		public virtual void adjustTemperature ( Int id_heater, double temperature ){
			SmartEnergyMng_adjustTemperature ( id_heater, temperature );
		}
		protected virtual void checkTime ( ){
			SmartEnergyMng_checkTime ( );
		}

	
	 
	}
} 
  