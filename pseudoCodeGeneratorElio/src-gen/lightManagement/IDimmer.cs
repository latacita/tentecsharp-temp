using System;
using System.Collections;
using System.Text;

namespace SmartHome
{
	public interface IDimmer :  initialModel.IDevice
	{
		int getValue();
		void setValue(int value);
		String getLightId();

	}
}
