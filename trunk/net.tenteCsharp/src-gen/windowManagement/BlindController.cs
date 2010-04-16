using System;
using System.Collections;
using System.Text;

namespace SmartHome
{
	public class BlindController : TypeComponent
	{
		public BlindControllerPort request;
			public String floorId;
			public String blindId;
			public String roomId;
	
		public BlindController (String id) 
			: base(id)
		{
		}
		public BlindControllerPort getRequest()
		{
			return request;
		}
	
		public void setRequest(BlindController.BlindControllerPort value)
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
	

	
		
		public class BlindControllerPort : TypePort , IBlindController
		{
 
			public BlindControllerPort()
				: base()
			{

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
	
		}
	}
}