using System;
using System.Collections;
using System.Text;

namespace SmartHome
{
	public interface IWindowDimmer :  initialModel.IDevice
	{
		int getAperture();
		void setAperture(int value);
		String getWindowId();

	}
}
