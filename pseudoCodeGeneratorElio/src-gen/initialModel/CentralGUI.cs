using System;
using System.Collections;
using System.Text;

namespace SmartHome
{
	public class CentralGUI : TypeComponent
	{
		public NotifyPort request;
		public GUIPort gui;
		public String houseId;
		public  ArrayList floorGUIs= new ArrayList();

		public CentralGUI (String id) 
			: base(id)
		{
		}
		public NotifyPort getRequest()
		{
			return request;
		}
	
		public void setRequest(CentralGUI.NotifyPort value)
		{
			this.request=value;
		}
	
		public GUIPort getGui()
		{
			return gui;
		}
	
		public void setGui(CentralGUI.GUIPort value)
		{
			this.gui=value;
		}
	
		public String getHouseId()
		{
			return houseId;
		}
	
		public void setHouseId(String value)
		{
			this.houseId=value;
		}
	
		public  ArrayList getFloorGUIs()
		{
			return floorGUIs;
		}
	
		public void setFloorGUIs(ArrayList value)
		{
			this.floorGUIs=value;
		}
		
		public void addFloorGUIsElement(FloorGUI value)
		{
			this.floorGUIs.Add(value);
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