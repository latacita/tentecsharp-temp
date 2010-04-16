using System;
using System.Collections;
using System.Text;

namespace SmartHome
{
	public interface IGeneralHeaterNotify
	{
		void switchOnAllHeaters(String floorId, String roomId);
		void switchOffAllHeaters(String floorId, String roomId);
		void changeAllHeatersTemp(float temperature, String floorId, String roomId);

	}
}
