using System;
using System.Collections;
using System.Text;

namespace SmartHome
{
	public partial class RoomGUI : TypeComponent
	{
		public BlindNotifyPort blindNotifyPort;
			public WindowNotifyPort windowNotifyPort;
			public  ArrayList listWindowGUI= new ArrayList();
			public  ArrayList listBlindGUI= new ArrayList();
	
		public RoomGUI (String id) 
			: base(id)
		{
		}
		public BlindNotifyPort getBlindNotifyPort()
		{
			return blindNotifyPort;
		}
	
		public void setBlindNotifyPort(RoomGUI.BlindNotifyPort value)
		{
			this.blindNotifyPort=value;
		}
	
		public WindowNotifyPort getWindowNotifyPort()
		{
			return windowNotifyPort;
		}
	
		public void setWindowNotifyPort(RoomGUI.WindowNotifyPort value)
		{
			this.windowNotifyPort=value;
		}
	
		public  ArrayList getListWindowGUI()
		{
			return listWindowGUI;
		}
	
		public void setListWindowGUI(ArrayList value)
		{
			this.listWindowGUI=value;
		}
		
		public void addListWindowGUIElement(WindowGUI value)
		{
			this.listWindowGUI.Add(value);
		}
	
		public  ArrayList getListBlindGUI()
		{
			return listBlindGUI;
		}
	
		public void setListBlindGUI(ArrayList value)
		{
			this.listBlindGUI=value;
		}
		
		public void addListBlindGUIElement(BlindGUI value)
		{
			this.listBlindGUI.Add(value);
		}
	

	
		
		public class WindowNotifyPort : TypePort
		{
 		public ArrayList portsIGeneralWindowNotify = new ArrayList();

			public WindowNotifyPort()
				: base()
			{
				portsIGeneralWindowNotify=new ArrayList();

			}


			public ArrayList getPortsIGeneralWindowNotify()
			{
	        	return portsIGeneralWindowNotify;
	        }
				
			public void connectPort(IGeneralWindowNotify port)
			{
				portsIGeneralWindowNotify.Add(port);
			}
	
		}	
		
		public class BlindNotifyPort : TypePort
		{
 		public ArrayList portsIGeneralBlindNotify = new ArrayList();

			public BlindNotifyPort()
				: base()
			{
				portsIGeneralBlindNotify=new ArrayList();

			}


			public ArrayList getPortsIGeneralBlindNotify()
			{
	        	return portsIGeneralBlindNotify;
	        }
				
			public void connectPort(IGeneralBlindNotify port)
			{
				portsIGeneralBlindNotify.Add(port);
			}
	
		}
	}
}