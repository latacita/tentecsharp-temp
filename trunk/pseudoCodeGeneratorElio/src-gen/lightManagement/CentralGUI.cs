using System;
using System.Collections;
using System.Text;

namespace SmartHome
{
	public partial class CentralGUI : TypeComponent
	{
		public LightNotifyPort lightNotifyPort;
	
		public CentralGUI (String id) 
			: base(id)
		{
		}
		public LightNotifyPort getLightNotifyPort()
		{
			return lightNotifyPort;
		}
	
		public void setLightNotifyPort(CentralGUI.LightNotifyPort value)
		{
			this.lightNotifyPort=value;
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