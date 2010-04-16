using System;
using System.Collections;
using System.Text;

namespace SmartHome
{
	public interface IGeneralWindowNotify
	{
		void changeAllWindowsAperture(int aperture, String floorId, String roomId);

	}
}
