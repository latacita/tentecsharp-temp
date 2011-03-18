using System;
using System.Collections;
using System.Text;

namespace SmartHome
{
	public interface IHeating
	{
		void setPower(String heaterId, int amount);
		void setMode(String heaterId, HeatingModes mode);
		void heatingSwitch(String heaterId, Boolean on);
		void setTemperature(String heaterId, float temp);

	}
}
