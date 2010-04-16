using System;
using System.Collections;
using System.Text;

namespace SmartHome
{
	public interface ISmartEnergyNotify
	{
		void activateSmartControl(String floorId, String roomId);
		void deactivateSmartControl(String floorId, String roomId);

	}
}
