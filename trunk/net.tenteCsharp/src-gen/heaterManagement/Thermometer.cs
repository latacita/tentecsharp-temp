using System;
using System.Collections;
using System.Text;

namespace SmartHome
{
	public class Thermometer : TypeComponent
	{
		public RequestPort request;
			public String floorId;
			public String thermometerId;
			public String roomId;
	
		public Thermometer (String id) 
			: base(id)
		{
		}
		public RequestPort getRequest()
		{
			return request;
		}
	
		public void setRequest(Thermometer.RequestPort value)
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
	
		public String getThermometerId()
		{
			return thermometerId;
		}
	
		public void setThermometerId(String value)
		{
			this.thermometerId=value;
		}
	
		public String getRoomId()
		{
			return roomId;
		}
	
		public void setRoomId(String value)
		{
			this.roomId=value;
		}
	

	
		
		public class RequestPort : TypePort , IThermometer
		{
 		public ArrayList portsIThermometerNotify = new ArrayList();

			public RequestPort()
				: base()
			{
				portsIThermometerNotify=new ArrayList();

			}


		public float getTemparature(String thermometerId)
			{
			return 0;		
			}

		public float getOutdoorTemparature(String thermometerId)
			{
			return 0;		
			}

			public ArrayList getPortsIThermometerNotify()
			{
	        	return portsIThermometerNotify;
	        }
				
			public void connectPort(IThermometerNotify port)
			{
				portsIThermometerNotify.Add(port);
			}
	
		}
	}
}