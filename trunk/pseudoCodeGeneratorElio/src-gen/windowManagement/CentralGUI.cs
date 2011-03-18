using System;
using System.Collections;
using System.Text;

namespace SmartHome
{
	public partial class CentralGUI : TypeComponent
	{
		public WindowNotifyPort windowNotifyPort;
			public BlindNotifyPort blindNotifyPort;
	
		public CentralGUI (String id) 
			: base(id)
		{
		}
		public WindowNotifyPort getWindowNotifyPort()
		{
			return windowNotifyPort;
		}
	
		public void setWindowNotifyPort(CentralGUI.WindowNotifyPort value)
		{
			this.windowNotifyPort=value;
		}
	
		public BlindNotifyPort getBlindNotifyPort()
		{
			return blindNotifyPort;
		}
	
		public void setBlindNotifyPort(CentralGUI.BlindNotifyPort value)
		{
			this.blindNotifyPort=value;
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