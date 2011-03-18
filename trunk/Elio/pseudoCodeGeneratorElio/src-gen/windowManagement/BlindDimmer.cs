using System;
using System.Collections;
using System.Text;

namespace SmartHome
{
	public class BlindDimmer : TypeComponent
	{
		public BlindDimmerPort request;
			public String floorId;
			public String blindId;
			public String roomId;
	
		public BlindDimmer (String id) 
			: base(id)
		{
		}
		public BlindDimmerPort getRequest()
		{
			return request;
		}
	
		public void setRequest(BlindDimmer.BlindDimmerPort value)
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
	
		public String getBlindId()
		{
			return blindId;
		}
	
		public void setBlindId(String value)
		{
			this.blindId=value;
		}
	
		public String getRoomId()
		{
			return roomId;
		}
	
		public void setRoomId(String value)
		{
			this.roomId=value;
		}
	

	
		
		public class BlindDimmerPort : TypePort , IBlindDimmer
		{
 		public ArrayList portsIBlindDimmerNotify = new ArrayList();

			public BlindDimmerPort()
				: base()
			{
				portsIBlindDimmerNotify=new ArrayList();

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


		public int getAperture()
			{
			return 0;		
			}

		public void setAperture(int value)
			{
		
			}

		public String getBlindId()
			{
			return null;		
			}

			public ArrayList getPortsIBlindDimmerNotify()
			{
	        	return portsIBlindDimmerNotify;
	        }
				
			public void connectPort(IBlindDimmerNotify port)
			{
				portsIBlindDimmerNotify.Add(port);
			}
	
		}
	}
}