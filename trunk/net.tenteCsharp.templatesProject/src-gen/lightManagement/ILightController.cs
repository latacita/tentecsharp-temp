using System;
using System.Collections;
using System.Text;

namespace SmartHome
{
	public interface ILightController :  initialModel.IDevice
	{
		void setValue(int value);
		int getValue();
		void switchOn();
		void switchOff();
		String getLightId();

	}
}
