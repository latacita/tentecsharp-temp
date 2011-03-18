using System;
using System.Collections;
using System.Text;

namespace SmartHome
{
	public partial class CentralGUI : TypeComponent
	{
		public HeaterNotifyPort heaterNotifyPort;
	
		public CentralGUI (String id) 
			: base(id)
		{
		}
		public HeaterNotifyPort getHeaterNotifyPort()
		{
			return heaterNotifyPort;
		}
	
		public void setHeaterNotifyPort(CentralGUI.HeaterNotifyPort value)
		{
			this.heaterNotifyPort=value;
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