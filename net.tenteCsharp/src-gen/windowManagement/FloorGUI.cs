using System;
using System.Collections;
using System.Text;

namespace SmartHome
{
	public partial class FloorGUI : TypeComponent
	{
		public BlindNotifyPort blindNotifyPort;
			public WindowNotifyPort windowNotifyPort;
	
		public FloorGUI (String id) 
			: base(id)
		{
		}
		public BlindNotifyPort getBlindNotifyPort()
		{
			return blindNotifyPort;
		}
	
		public void setBlindNotifyPort(FloorGUI.BlindNotifyPort value)
		{
			this.blindNotifyPort=value;
		}
	
		public WindowNotifyPort getWindowNotifyPort()
		{
			return windowNotifyPort;
		}
	
		public void setWindowNotifyPort(FloorGUI.WindowNotifyPort value)
		{
			this.windowNotifyPort=value;
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