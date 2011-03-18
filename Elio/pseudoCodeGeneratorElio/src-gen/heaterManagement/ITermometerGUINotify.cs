using System;
using System.Collections;
using System.Text;

namespace SmartHome
{
	public interface ITermometerGUINotify
	{
		void newTemparature(String thermometerId, float value);
		void newOutsideTemperature(String termometerId, float value);
		String getTermometerId();

	}
}
