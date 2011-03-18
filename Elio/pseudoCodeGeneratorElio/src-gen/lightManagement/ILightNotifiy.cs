using System;
using System.Collections;
using System.Text;

namespace SmartHome
{
	public interface ILightNotifiy
	{
		void changeLightIntensity(String lightId, int value);
		void changeLightState(String lightId, Boolean state);

	}
}
