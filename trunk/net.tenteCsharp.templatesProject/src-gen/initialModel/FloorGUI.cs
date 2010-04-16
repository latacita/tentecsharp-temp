using System;
using System.Collections;
using System.Text;

namespace SmartHome
{
	public class FloorGUI : TypeComponent
	{
		public NotifyPort request;
		public GUIPort gui;
		public String floorId;
		public  ArrayList roomGUIs= new ArrayList();

		public FloorGUI (String id) 
			: base(id)
		{
		}
		public NotifyPort getRequest()
		{
			return request;
		}
	
		public void setRequest(FloorGUI.NotifyPort value)
		{
			this.request=value;
		}
	
		public GUIPort getGui()
		{
			return gui;
		}
	
		public void setGui(FloorGUI.GUIPort value)
		{
			this.gui=value;
		}
	
		public String getFloorId()
		{
			return floorId;
		}
	
		public void setFloorId(String value)
		{
			this.floorId=value;
		}
	
		public  ArrayList getRoomGUIs()
		{
			return roomGUIs;
		}
	
		public void setRoomGUIs(ArrayList value)
		{
			this.roomGUIs=value;
		}
		
		public void addRoomGUIsElement(RoomGUI value)
		{
			this.roomGUIs.Add(value);
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