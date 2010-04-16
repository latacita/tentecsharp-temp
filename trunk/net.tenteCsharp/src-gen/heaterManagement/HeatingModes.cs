using System;
using System.Collections;
using System.Text;

namespace SmartHome
{
	/// <summary>
    /// Enumeration
    /// </summary>
	public class HeatingModes : TypeEnum 
	{
		public HeatingModes () 
			: base()
		{		
		values.Add("Heating");		
		values.Add("Cooling");
		}
	
	}
}