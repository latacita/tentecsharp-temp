using System;
using System.Collections;
using System.Text;

namespace SmartHome
{
	/// <summary>
    /// Enumeration
    /// </summary>
	public class Deployment : TypeEnum 
	{
		public Deployment () 
			: base()
		{		
		values.Add("Lightweight");		
		values.Add("Heavyweight");
		}
	
	}
}