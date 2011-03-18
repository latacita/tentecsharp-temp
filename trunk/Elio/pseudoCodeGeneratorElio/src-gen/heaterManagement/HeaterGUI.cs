using System;
using System.Collections;
using System.Text;

namespace SmartHome
{
	public class HeaterGUI : TypeComponent
	{
		public RequestPort request;
			public ServicesPort services;
			public String heaterId;
			public String floorId;
			public String roomId;
	
		public HeaterGUI (String id) 
			: base(id)
		{
		}
		public RequestPort getRequest()
		{
			return request;
		}
	
		public void setRequest(HeaterGUI.RequestPort value)
		{
			this.request=value;
		}
	
		public ServicesPort getServices()
		{
			return services;
		}
	
		public void setServices(HeaterGUI.ServicesPort value)
		{
			this.services=value;
		}
	
		public String getHeaterId()
		{
			return heaterId;
		}
	
		public void setHeaterId(String value)
		{
			this.heaterId=value;
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
	

	
		
		public class RequestPort : TypePort , IHeating
		{
 
			public RequestPort()
				: base()
			{

			}


		public void setPower(String heaterId,int amount)
			{
		
			}

		public void setMode(String heaterId,HeatingModes mode)
			{
		
			}

		public void heatingSwitch(String heaterId,boolean on)
			{
		
			}

		public void setTemperature(String heaterId,float temp)
			{
		
			}
	
		}	
		
		public class ServicesPort_heaterManagement : TypePort
		{
 		public ArrayList portsIHeaterGUINotify = new ArrayList();

			public ServicesPort_heaterManagement()
				: base()
			{
				portsIHeaterGUINotify=new ArrayList();

			}


			public ArrayList getPortsIHeaterGUINotify()
			{
	        	return portsIHeaterGUINotify;
	        }
				
			public void connectPort(IHeaterGUINotify port)
			{
				portsIHeaterGUINotify.Add(port);
			}
	
		}
	}
}