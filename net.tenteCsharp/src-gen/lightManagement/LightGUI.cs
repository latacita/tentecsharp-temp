using System;
using System.Collections;
using System.Text;

namespace SmartHome
{
	public class LightGUI : TypeComponent
	{
		public String roomId;
			public String floorId;
			public RequestPort request;
			public ActuatorPort services;
			public String lightId;
	
		public LightGUI (String id) 
			: base(id)
		{
		}
		public String getRoomId()
		{
			return roomId;
		}
	
		public void setRoomId(String value)
		{
			this.roomId=value;
		}
	
		public String getFloorId()
		{
			return floorId;
		}
	
		public void setFloorId(String value)
		{
			this.floorId=value;
		}
	
		public RequestPort getRequest()
		{
			return request;
		}
	
		public void setRequest(LightGUI.RequestPort value)
		{
			this.request=value;
		}
	
		public ActuatorPort getServices()
		{
			return services;
		}
	
		public void setServices(LightGUI.ActuatorPort value)
		{
			this.services=value;
		}
	
		public String getLightId()
		{
			return lightId;
		}
	
		public void setLightId(String value)
		{
			this.lightId=value;
		}
	

	
		
		public class RequestPort : TypePort , ILightNotifiy
		{
 
			public RequestPort()
				: base()
			{

			}


		public void changeLightIntensity(String lightId,int value)
			{
		
			}

		public void changeLightState(String lightId,boolean state)
			{
		
			}
	
		}	
		
		public class ActuatorPort_lightManagement : TypePort
		{
 		public ArrayList portsILightNotifiy = new ArrayList();
		public ArrayList portsILightGUINotify = new ArrayList();

			public ActuatorPort_lightManagement()
				: base()
			{
				portsILightNotifiy=new ArrayList();
				portsILightGUINotify=new ArrayList();

			}


			public ArrayList getPortsILightNotifiy()
			{
	        	return portsILightNotifiy;
	        }
				
			public void connectPort(ILightNotifiy port)
			{
				portsILightNotifiy.Add(port);
			}

			public ArrayList getPortsILightGUINotify()
			{
	        	return portsILightGUINotify;
	        }
				
			public void connectPort(ILightGUINotify port)
			{
				portsILightGUINotify.Add(port);
			}
	
		}
	}
}