using System;
using System.Collections;
using System.Text;

namespace SmartHome
{
	public partial class HouseGateway : TypeComponent
	{
			
		public HouseGateway (String id) 
			: base(id)
		{
		}

	
		
		public class SensorPort_lightManagement : TypePort , IDimmerNotify,ISwitchNotify
		{
 
			public SensorPort_lightManagement()
				: base()
			{

			}


		public void dimmerValueChanged(String lightId,int value)
			{
		
			}

		public void switchValueChanged(String lightId,SwitchStatus value)
			{
		
			}
	
		}	
		
		public class ActuatorPort_lightManagement : TypePort , ILightGUINotify,IGeneralLightNotify
		{
 		public ArrayList portsISwitch = new ArrayList();
		public ArrayList portsIDimmer = new ArrayList();
		public ArrayList portsILightController = new ArrayList();

			public ActuatorPort_lightManagement()
				: base()
			{
				portsISwitch=new ArrayList();
				portsIDimmer=new ArrayList();
				portsILightController=new ArrayList();

			}


		public void changeLightIntensity(String lightId,int value)
			{
		
			}

		public void changeLightState(String lightId,boolean state)
			{
		
			}

		public void switchOffAllLights(String floorId,String roomId)
			{
		
			}

		public void switchOnAllLights(String floorId,String roomId)
			{
		
			}

		public void changeAllLightsIntensity(int intensity,String floorId,String roomId)
			{
		
			}

			public ArrayList getPortsISwitch()
			{
	        	return portsISwitch;
	        }
				
			public void connectPort(ISwitch port)
			{
				portsISwitch.Add(port);
			}

			public ArrayList getPortsIDimmer()
			{
	        	return portsIDimmer;
	        }
				
			public void connectPort(IDimmer port)
			{
				portsIDimmer.Add(port);
			}

			public ArrayList getPortsILightController()
			{
	        	return portsILightController;
	        }
				
			public void connectPort(ILightController port)
			{
				portsILightController.Add(port);
			}
	
		}

		public class House_lightManagement 
		{		

			public House_lightManagement()
			{
			}
		public Light getLightById(String  id)
		{
			return null;		
		}

		}
			
			public House getHouseInstance()
			{
				House house=new House();
				return house;
			}

		public class Floor_lightManagement 
		{		

			public Floor_lightManagement()
			{
			}
		public Light getLightById(String  id)
		{
			return null;		
		}

		}
			
			public Floor getFloorInstance()
			{
				Floor floor=new Floor();
				return floor;
			}

		public class Room_lightManagement 
		{		
			public ArrayList  lights = new ArrayList(); 

			public Room_lightManagement()
			{
			}
			public ArrayList getLights()
			{
				return lights;
			}
			public void setLights(ArrayList value)
			{
				this.lights=value;
			}
		
			public void addLightsElement(Light value)
			{
				this.lights.Add(value);
			}
	
		public void addLight(Light  light)
		{
		
		}
		public Light getLightById(String  id)
		{
			return null;		
		}

		}
			
			public Room getRoomInstance()
			{
				Room room=new Room();
				return room;
			}

		public class Light 
		{		
			public String id; 
			public int intensity; 
			public String name; 
			public Boolean lightOn; 

			public Light()
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
	
			public int   getIntensity()
			{
				return intensity;
			}
			public void setIntensity(int value)
			{
				this.intensity=value;
			}
	
			public String   getName()
			{
				return name;
			}
			public void setName(String value)
			{
				this.name=value;
			}
	
			public Boolean   getLightOn()
			{
				return lightOn;
			}
			public void setLightOn(Boolean value)
			{
				this.lightOn=value;
			}
	

		}
			
			public Light getLightInstance()
			{
				Light light=new Light();
				return light;
			}	
		
		public class ServicesPort_lightManagement : TypePort
		{
 		public ArrayList portsILightNotifiy = new ArrayList();

			public ServicesPort_lightManagement()
				: base()
			{
				portsILightNotifiy=new ArrayList();

			}


			public ArrayList getPortsILightNotifiy()
			{
	        	return portsILightNotifiy;
	        }
				
			public void connectPort(ILightNotifiy port)
			{
				portsILightNotifiy.Add(port);
			}
	
		}
	}
}