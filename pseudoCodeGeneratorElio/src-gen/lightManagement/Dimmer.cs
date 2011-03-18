using System;
using System.Collections;
using System.Text;

namespace SmartHome
{
	public class Dimmer : TypeComponent
	{
		public RequestPort request;
			public String lightId;
			public String floorId;
			public String roomId;
	
		public Dimmer (String id) 
			: base(id)
		{
		}
		public RequestPort getRequest()
		{
			return request;
		}
	
		public void setRequest(Dimmer.RequestPort value)
		{
			this.request=value;
		}
	
		public String getLightId()
		{
			return lightId;
		}
	
		public void setLightId(String value)
		{
			this.lightId=value;
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
	

	
		
		public class RequestPort : TypePort , IDimmer
		{
 		public ArrayList portsIDimmerNotify = new ArrayList();

			public RequestPort()
				: base()
			{
				portsIDimmerNotify=new ArrayList();

			}
		public String getId()
			{
			return null;		
			}
		public void setRoomId(String roomId)
			{
		
			}
		public String getRoomId()
			{
			return null;		
			}
		public void setFloorId(String floorId)
			{
		
			}
		public String getFloorId()
			{
			return null;		
			}


		public int getValue()
			{
			return 0;		
			}

		public void setValue(int value)
			{
		
			}

		public String getLightId()
			{
			return null;		
			}

			public ArrayList getPortsIDimmerNotify()
			{
	        	return portsIDimmerNotify;
	        }
				
			public void connectPort(IDimmerNotify port)
			{
				portsIDimmerNotify.Add(port);
			}
	
		}
	}
}