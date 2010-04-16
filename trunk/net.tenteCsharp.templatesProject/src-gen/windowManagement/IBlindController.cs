using System;
using System.Collections;
using System.Text;

namespace SmartHome
{
	public interface IBlindController :  initialModel.IDevice
	{
		int getAperture();
		void setAperture(int value);
		String getBlindId();

	}
}
