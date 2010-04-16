using System;
using System.Collections;
using System.Text;

namespace SmartHome
{
	public interface ILightGUINotify
	{
		void changeLightIntensity(String lightId, int value);
		void changeLightState(String lightId, Boolean state);

	}
}
