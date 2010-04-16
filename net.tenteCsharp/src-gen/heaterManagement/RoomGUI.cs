using System;
using System.Collections;
using System.Text;

namespace SmartHome
{
	public partial class RoomGUI : TypeComponent
	{
		public HeaterNotifyPort heaterNotifyPort;
			public  ArrayList listThermometerGUI= new ArrayList();
			public  ArrayList listHeaterGUI= new ArrayList();
	
		public RoomGUI (String id) 
			: base(id)
		{
		}
		public HeaterNotifyPort getHeaterNotifyPort()
		{
			return heaterNotifyPort;
		}
	
		public void setHeaterNotifyPort(RoomGUI.HeaterNotifyPort value)
		{
			this.heaterNotifyPort=value;
		}
	
		public  ArrayList getListThermometerGUI()
		{
			return listThermometerGUI;
		}
	
		public void setListThermometerGUI(ArrayList value)
		{
			this.listThermometerGUI=value;
		}
		
		public void addListThermometerGUIElement(ThermometerGUI value)
		{
			this.listThermometerGUI.Add(value);
		}
	
		public  ArrayList getListHeaterGUI()
		{
			return listHeaterGUI;
		}
	
		public void setListHeaterGUI(ArrayList value)
		{
			this.listHeaterGUI=value;
		}
		
		public void addListHeaterGUIElement(HeaterGUI value)
		{
			this.listHeaterGUI.Add(value);
		}
	

	
		
		public class HeaterNotifyPort : TypePort
		{
 		public ArrayList portsIGeneralHeaterNotify = new ArrayList();

			public HeaterNotifyPort()
				: base()
			{
				portsIGeneralHeaterNotify=new ArrayList();

			}


			public ArrayList getPortsIGeneralHeaterNotify()
			{
	        	return portsIGeneralHeaterNotify;
	        }
				
			public void connectPort(IGeneralHeaterNotify port)
			{
				portsIGeneralHeaterNotify.Add(port);
			}
	
		}
	}
}