using System;
using System.Collections;
using System.Text;

namespace SmartHome
{
	public interface ISwitchNotify
	{
		void switchValueChanged(String lightId, SwitchStatus value);

	}
}
