using System;
using System.Collections;
using System.Text;

namespace SmartHome
{
	/// <summary>
    /// Enumeration
    /// </summary>
	public class DeviceKind : TypeEnum 
	{
		public DeviceKind () 
			: base()
		{		
		values.Add("LightSwitch");		
		values.Add("LightDimmer");		
		values.Add("LightController");
		}
	
	}
}