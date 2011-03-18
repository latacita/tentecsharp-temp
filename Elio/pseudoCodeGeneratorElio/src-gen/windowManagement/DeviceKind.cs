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
		values.Add("WindowController");		
		values.Add("WindowDimmer");		
		values.Add("BlindDimmer");		
		values.Add("BlindController");
		}
	
	}
}