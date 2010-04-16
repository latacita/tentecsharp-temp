using System;
using System.Collections;
using System.Text;

namespace SmartHome
{
	public interface IHeaterGUI
	{
		void setTemperature(String heaterId, float value);
		void programSwitchOn(String heaterId, float value, String time);
		void programSwitchOff(String heaterId, String time);

	}
}
