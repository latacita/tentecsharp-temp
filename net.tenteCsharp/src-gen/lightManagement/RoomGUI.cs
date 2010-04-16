using System;
using System.Collections;
using System.Text;

namespace SmartHome
{
	public partial class RoomGUI : TypeComponent
	{
		public LightNotifyPort lightNotifyPort;
			public  ArrayList listLightGUI= new ArrayList();
	
		public RoomGUI (String id) 
			: base(id)
		{
		}
		public LightNotifyPort getLightNotifyPort()
		{
			return lightNotifyPort;
		}
	
		public void setLightNotifyPort(RoomGUI.LightNotifyPort value)
		{
			this.lightNotifyPort=value;
		}
	
		public  ArrayList getListLightGUI()
		{
			return listLightGUI;
		}
	
		public void setListLightGUI(ArrayList value)
		{
			this.listLightGUI=value;
		}
		
		public void addListLightGUIElement(LightGUI value)
		{
			this.listLightGUI.Add(value);
		}
	

	
		
		public class LightNotifyPort : TypePort
		{
 		public ArrayList portsIGeneralLightNotify = new ArrayList();

			public LightNotifyPort()
				: base()
			{
				portsIGeneralLightNotify=new ArrayList();

			}


			public ArrayList getPortsIGeneralLightNotify()
			{
	        	return portsIGeneralLightNotify;
	        }
				
			public void connectPort(IGeneralLightNotify port)
			{
				portsIGeneralLightNotify.Add(port);
			}
	
		}
	}
}