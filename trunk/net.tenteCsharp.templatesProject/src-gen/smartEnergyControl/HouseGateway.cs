using System;
using System.Collections;
using System.Text;

namespace SmartHome
{
	public partial class HouseGateway : TypeComponent
	{
		public SmartPort smartEnergyPort;
			public SmartNotifyPort smartEnergyNotifyPort;
	
		public HouseGateway (String id) 
			: base(id)
		{
		}
		public SmartPort getSmartEnergyPort()
		{
			return smartEnergyPort;
		}
	
		public void setSmartEnergyPort(HouseGateway.SmartPort value)
		{
			this.smartEnergyPort=value;
		}
	
		public SmartNotifyPort getSmartEnergyNotifyPort()
		{
			return smartEnergyNotifyPort;
		}
	
		public void setSmartEnergyNotifyPort(HouseGateway.SmartNotifyPort value)
		{
			this.smartEnergyNotifyPort=value;
		}
	



		public class Room_smartEnergyControl 
		{		
			public Boolean smartControlActive; 

			public Room_smartEnergyControl()
			{
			}
			public Boolean   getSmartControlActive()
			{
				return smartControlActive;
			}
			public void setSmartControlActive(Boolean value)
			{
				this.smartControlActive=value;
			}
	

		}
			
			public Room getRoomInstance()
			{
				Room room=new Room();
				return room;
			}

		public class Floor_smartEnergyControl 
		{		
			public Boolean smartControlActive; 

			public Floor_smartEnergyControl()
			{
			}
			public Boolean   getSmartControlActive()
			{
				return smartControlActive;
			}
			public void setSmartControlActive(Boolean value)
			{
				this.smartControlActive=value;
			}
	

		}
			
			public Floor getFloorInstance()
			{
				Floor floor=new Floor();
				return floor;
			}

		public class House_smartEnergyControl 
		{		
			public Boolean smartControlActive; 

			public House_smartEnergyControl()
			{
			}
			public Boolean   getSmartControlActive()
			{
				return smartControlActive;
			}
			public void setSmartControlActive(Boolean value)
			{
				this.smartControlActive=value;
			}
	

		}
			
			public House getHouseInstance()
			{
				House house=new House();
				return house;
			}	
		
		public class SmartPort : TypePort , ISmartEnergy
		{
 
			public SmartPort()
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
		
		public class SmartNotifyPort : TypePort
		{
 		public ArrayList portsISmartEnergyNotify = new ArrayList();

			public SmartNotifyPort()
				: base()
			{
				portsISmartEnergyNotify=new ArrayList();

			}


			public ArrayList getPortsISmartEnergyNotify()
			{
	        	return portsISmartEnergyNotify;
	        }
				
			public void connectPort(ISmartEnergyNotify port)
			{
				portsISmartEnergyNotify.Add(port);
			}
	
		}
	}
}