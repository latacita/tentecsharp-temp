using System;
using System.Collections;
using System.Text;

namespace SmartHome
{
	public class Switch : TypeComponent
	{
		public SwitchStatus status;
			public SwitchPort request;
			public String lightId;
			public String floorId;
			public String roomId;
	
		public Switch (String id) 
			: base(id)
		{
		}
		public SwitchStatus getStatus()
		{
			return status;
		}
	
		public void setStatus(LightManagement.SwitchStatus value)
		{
			this.status=value;
		}
	
		public SwitchPort getRequest()
		{
			return request;
		}
	
		public void setRequest(Switch.SwitchPort value)
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
	

	
		
		public class SwitchPort : TypePort , ISwitch
		{
 		public ArrayList portsISwitchNotify = new ArrayList();

			public SwitchPort()
				: base()
			{
				portsISwitchNotify=new ArrayList();

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


		public SwitchStatus getStatus()
			{
			return null;		
			}

		public void setStatus(SwitchStatus value)
			{
		
			}

		public String getLightId()
			{
			return null;		
			}

			public ArrayList getPortsISwitchNotify()
			{
	        	return portsISwitchNotify;
	        }
				
			public void connectPort(ISwitchNotify port)
			{
				portsISwitchNotify.Add(port);
			}
	
		}
	}
}