using System;
using System.Collections;
using System.Text;

namespace SmartHome
{
	public class HouseGateway : TypeComponent
	{
		public ServicesPort services;
		public House houseData;
		public ActuatorPort actuators;
		public SensorPort sensors;

		public HouseGateway (String id) 
			: base(id)
		{
		}
		public ServicesPort getServices()
		{
			return services;
		}
	
		public void setServices(HouseGateway.ServicesPort value)
		{
			this.services=value;
		}
	
		public House getHouseData()
		{
			return houseData;
		}
	
		public void setHouseData(HouseGateway.House value)
		{
			this.houseData=value;
		}
	
		public ActuatorPort getActuators()
		{
			return actuators;
		}
	
		public void setActuators(HouseGateway.ActuatorPort value)
		{
			this.actuators=value;
		}
	
		public SensorPort getSensors()
		{
			return sensors;
		}
	
		public void setSensors(HouseGateway.SensorPort value)
		{
			this.sensors=value;
		}
	

	
		
		public class ServicesPort : TypePort
		{
 		public ArrayList portsIGUI = new ArrayList();
		public ArrayList portsINotify = new ArrayList();

			public ServicesPort()
				: base()
			{
				portsIGUI=new ArrayList();
				portsINotify=new ArrayList();

			}


			public ArrayList getPortsIGUI()
			{
	        	return portsIGUI;
	        }
				
			public void connectPort(IGUI port)
			{
				portsIGUI.Add(port);
			}

			public ArrayList getPortsINotify()
			{
	        	return portsINotify;
	        }
				
			public void connectPort(INotify port)
			{
				portsINotify.Add(port);
			}
	
		}	
		
		public class ActuatorPort : TypePort
		{
 
			public ActuatorPort()
				: base()
			{

			}

	
		}

		public class House 
		{		
			public ArrayList  floors = new ArrayList(); 
			public String name; 
			public String id; 

			public House()
			{
			}
			public ArrayList getFloors()
			{
				return floors;
			}
			public void setFloors(ArrayList value)
			{
				this.floors=value;
			}
		
			public void addFloorsElement(Floor value)
			{
				this.floors.Add(value);
			}
	
			public String   getName()
			{
				return name;
			}
			public void setName(String value)
			{
				this.name=value;
			}
	
			public String   getId()
			{
				return id;
			}
			public void setId(String value)
			{
				this.id=value;
			}
	
		public Floor getFloorById(String  id)
		{
			return null;		
		}
		public Room getRoomById(String  id)
		{
			return null;		
		}

		}
			
			public House getHouseInstance()
			{
				House house=new House();
				return house;
			}

		public class Room 
		{		
			public String id; 
			public String name; 

			public Room()
			{
			}
			public String   getId()
			{
				return id;
			}
			public void setId(String value)
			{
				this.id=value;
			}
	
			public String   getName()
			{
				return name;
			}
			public void setName(String value)
			{
				this.name=value;
			}
	

		}
			
			public Room getRoomInstance()
			{
				Room room=new Room();
				return room;
			}

		public class Floor 
		{		
			public ArrayList  rooms = new ArrayList(); 
			public String id; 
			public String name; 

			public Floor()
			{
			}
			public ArrayList getRooms()
			{
				return rooms;
			}
			public void setRooms(ArrayList value)
			{
				this.rooms=value;
			}
		
			public void addRoomsElement(Room value)
			{
				this.rooms.Add(value);
			}
	
			public String   getId()
			{
				return id;
			}
			public void setId(String value)
			{
				this.id=value;
			}
	
			public String   getName()
			{
				return name;
			}
			public void setName(String value)
			{
				this.name=value;
			}
	
		public void addRoom(Room  room)
		{
		
		}
		public Room searchRoomById(String  id)
		{
			return null;		
		}

		}
			
			public Floor getFloorInstance()
			{
				Floor floor=new Floor();
				return floor;
			}	
		
		public class SensorPort : TypePort
		{
 
			public SensorPort()
				: base()
			{

			}

	
		}
	}
}