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
		values.Add("Heating");		
		values.Add("Thermometer");
		}
	
	}
}