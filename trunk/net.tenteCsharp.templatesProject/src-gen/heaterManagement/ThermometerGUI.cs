using System;
using System.Collections;
using System.Text;

namespace SmartHome
{
	public class ThermometerGUI : TypeComponent
	{
		public RequestPort request;
			public String floorId;
			public String roomId;
			public String thermometerId;
	
		public ThermometerGUI (String id) 
			: base(id)
		{
		}
		public RequestPort getRequest()
		{
			return request;
		}
	
		public void setRequest(ThermometerGUI.RequestPort value)
		{
			this.request=value;
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
	
		public String getThermometerId()
		{
			return thermometerId;
		}
	
		public void setThermometerId(String value)
		{
			this.thermometerId=value;
		}
	

	
		
		public class RequestPort : TypePort , ITermometerGUINotify
		{
 		public ArrayList portsIHeaterGUI = new ArrayList();

			public RequestPort()
				: base()
			{
				portsIHeaterGUI=new ArrayList();

			}


		public void newTemparature(String thermometerId,float value)
			{
		
			}

		public void newOutsideTemperature(String termometerId,float value)
			{
		
			}

		public String getTermometerId()
			{
			return null;		
			}

			public ArrayList getPortsIHeaterGUI()
			{
	        	return portsIHeaterGUI;
	        }
				
			public void connectPort(IHeaterGUI port)
			{
				portsIHeaterGUI.Add(port);
			}
	
		}
	}
}