using System;
using System.Collections;
using System.Text;

namespace SmartHome
{
	/// <summary>
    /// Enumeration
    /// </summary>
	public class SwitchStatus : TypeEnum 
	{
		public SwitchStatus () 
			: base()
		{		
		values.Add("SwitchOn");		
		values.Add("SwitchOff");
		}
	
	}
}