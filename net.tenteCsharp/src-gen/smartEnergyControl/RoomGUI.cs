using System;
using System.Collections;
using System.Text;

namespace SmartHome
{
	public partial class RoomGUI : TypeComponent
	{
		public SmartPort smartEnergyPort;
			public SmartNotifyPort smartEnergyNotifyPort;
	
		public RoomGUI (String id) 
			: base(id)
		{
		}
		public SmartPort getSmartEnergyPort()
		{
			return smartEnergyPort;
		}
	
		public void setSmartEnergyPort(RoomGUI.SmartPort value)
		{
			this.smartEnergyPort=value;
		}
	
		public SmartNotifyPort getSmartEnergyNotifyPort()
		{
			return smartEnergyNotifyPort;
		}
	
		public void setSmartEnergyNotifyPort(RoomGUI.SmartNotifyPort value)
		{
			this.smartEnergyNotifyPort=value;
		}
	

	
		
		public class SmartPort : TypePort
		{
 		public ArrayList portsISmartEnergy = new ArrayList();

			public SmartPort()
				: base()
			{
				portsISmartEnergy=new ArrayList();

			}


			public ArrayList getPortsISmartEnergy()
			{
	        	return portsISmartEnergy;
	        }
				
			public void connectPort(ISmartEnergy port)
			{
				portsISmartEnergy.Add(port);
			}
	
		}	
		
		public class SmartNotifyPort : TypePort , ISmartEnergyNotify
		{
 
			public SmartNotifyPort()
				: base()
			{

			}


		public void activateSmartControl(String floorId,String roomId)
			{
		
			}

		public void deactivateSmartControl(String floorId,String roomId)
			{
		
			}
	
		}
	}
}