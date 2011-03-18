using System;
using System.Collections;
using System.Text;

namespace SmartHome
{
	public interface ISwitch :  initialModel.IDevice
	{
		SwitchStatus getStatus();
		void setStatus(SwitchStatus value);
		String getLightId();

	}
}
