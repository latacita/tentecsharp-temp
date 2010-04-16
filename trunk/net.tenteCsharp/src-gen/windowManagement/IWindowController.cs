using System;
using System.Collections;
using System.Text;

namespace SmartHome
{
	public interface IWindowController :  initialModel.IDevice
	{
		int getAperture();
		void setAperture(int value);
		String getWindowId();

	}
}
