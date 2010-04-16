using System;
using System.Collections;
using System.Text;

namespace SmartHome
{
	public class WindowGUI : TypeComponent
	{
		public RequestPort request;
			public ActuatorPort services;
			public String roomId;
			public String floorId;
			public String windowId;
	
		public WindowGUI (String id) 
			: base(id)
		{
		}
		public RequestPort getRequest()
		{
			return request;
		}
	
		public void setRequest(WindowGUI.RequestPort value)
		{
			this.request=value;
		}
	
		public ActuatorPort getServices()
		{
			return services;
		}
	
		public void setServices(WindowGUI.ActuatorPort value)
		{
			this.services=value;
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
	
		public String getWindowId()
		{
			return windowId;
		}
	
		public void setWindowId(String value)
		{
			this.windowId=value;
		}
	

	
		
		public class ActuatorPort_windowManagement : TypePort
		{
 		public ArrayList portsIWindowGUINotify = new ArrayList();

			public ActuatorPort_windowManagement()
				: base()
			{
				portsIWindowGUINotify=new ArrayList();

			}


			public ArrayList getPortsIWindowGUINotify()
			{
	        	return portsIWindowGUINotify;
	        }
				
			public void connectPort(IWindowGUINotify port)
			{
				portsIWindowGUINotify.Add(port);
			}
	
		}	
		
		public class RequestPort : TypePort , IWindowNotifiy
		{
 
			public RequestPort()
				: base()
			{

			}


		public void changeWindowAperture(String windowId,int value)
			{
		
			}
	
		}
	}
}