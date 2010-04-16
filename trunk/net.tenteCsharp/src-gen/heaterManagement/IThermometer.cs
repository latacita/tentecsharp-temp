using System;
using System.Collections;
using System.Text;

namespace SmartHome
{
	public interface IThermometer
	{
		float getTemparature(String thermometerId);
		float getOutdoorTemparature(String thermometerId);

	}
}
