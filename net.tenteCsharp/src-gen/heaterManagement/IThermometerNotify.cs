using System;
using System.Collections;
using System.Text;

namespace SmartHome
{
	public interface IThermometerNotify
	{
		void newTemperature(String thermometerId, float value);
		void newOutsideTemp(String thermometerId, float value);

	}
}
