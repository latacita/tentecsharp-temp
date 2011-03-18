using System;
using System.Collections;
using System.Text;

namespace SmartHome
{
	public class BlindGUI : TypeComponent
	{
		public RequestPort request;
			public ActuatorPort services;
			public String floorId;
			public String roomId;
			public String blindId;
	
		public BlindGUI (String id) 
			: base(id)
		{
		}
		public RequestPort getRequest()
		{
			return request;
		}
	
		public void setRequest(BlindGUI.RequestPort value)
		{
			this.request=value;
		}
	
		public ActuatorPort getServices()
		{
			return services;
		}
	
		public void setServices(BlindGUI.ActuatorPort value)
		{
			this.services=value;
		}
	
		public String getFloorId()
		{
			return floorId;
		}
	
		public void setFloorId(String value)
		{
			this.floorId=value;
		}
	
		public String getRoomId()
		{
			return roomId;
		}
	
		public void setRoomId(String value)
		{
			this.roomId=value;
		}
	
		public String getBlindId()
		{
			return blindId;
		}
	
		public void setBlindId(String value)
		{
			this.blindId=value;
		}
	

	
		
		public class ActuatorPort_windowManagement : TypePort
		{
 		public ArrayList portsIBlindGUINotify = new ArrayList();

			public ActuatorPort_windowManagement()
				: base()
			{
				portsIBlindGUINotify=new ArrayList();

			}


			public ArrayList getPortsIBlindGUINotify()
			{
	        	return portsIBlindGUINotify;
	        }
				
			public void connectPort(IBlindGUINotify port)
			{
				portsIBlindGUINotify.Add(port);
			}
	
		}	
		
		public class RequestPort : TypePort , IBlindNotifiy
		{
 
			public RequestPort()
				: base()
			{

			}


		public void changeBlindAperture(String blindId,int value)
			{
		
			}
	
		}
	}
}