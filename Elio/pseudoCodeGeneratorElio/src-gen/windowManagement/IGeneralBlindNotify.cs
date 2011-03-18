using System;
using System.Collections;
using System.Text;

namespace SmartHome
{
	public interface IGeneralBlindNotify
	{
		void changeAllBlindsAperture(int aperture, String floorId, String roomId);

	}
}
