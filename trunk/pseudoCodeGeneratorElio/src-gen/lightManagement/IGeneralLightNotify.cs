using System;
using System.Collections;
using System.Text;

namespace SmartHome
{
	public interface IGeneralLightNotify
	{
		void switchOffAllLights(String floorId, String roomId);
		void switchOnAllLights(String floorId, String roomId);
		void changeAllLightsIntensity(int intensity, String floorId, String roomId);

	}
}
