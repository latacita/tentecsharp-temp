using System;
using System.Collections;
using System.Text;

namespace SmartHome
{
	public interface IHeaterGUINotify
	{
		void heaterTemperatureChanged(String heaterId, float newTemp);
		void heaterSwitchChanged(String heaterId, Boolean on);

	}
}
