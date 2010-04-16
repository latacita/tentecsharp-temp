using System;
using System.Collections;
using System.Text;

namespace SmartHome
{
	public class RoomGUI : TypeComponent
	{
		public NotifyPort request;
		public GUIPort gui;
		public String roomId;
		public String floorId;

		public RoomGUI (String id) 
			: base(id)
		{
		}
		public NotifyPort getRequest()
		{
			return request;
		}
	
		public void setRequest(RoomGUI.NotifyPort value)
		{
			this.request=value;
		}
	
		public GUIPort getGui()
		{
			return gui;
		}
	
		public void setGui(RoomGUI.GUIPort value)
		{
			this.gui=value;
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
	

	
		
		public class NotifyPort : TypePort , INotify
		{
 
			public NotifyPort()
				: base()
			{

			}


		public String getId()
			{
			return null;		
			}
	
		}	
		
		public class GUIPort : TypePort , IGUI
		{
 
			public GUIPort()
				: base()
			{

			}


		public void showGUI()
			{
		
			}

		public void initGUI()
			{
		
			}
	
		}
	}
}