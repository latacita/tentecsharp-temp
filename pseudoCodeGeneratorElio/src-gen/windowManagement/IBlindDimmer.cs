using System;
using System.Collections;
using System.Text;

namespace SmartHome
{
	public interface IBlindDimmer :  initialModel.IDevice
	{
		int getAperture();
		void setAperture(int value);
		String getBlindId();

	}
}
