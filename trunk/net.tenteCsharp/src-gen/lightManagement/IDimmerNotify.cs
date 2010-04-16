using System;
using System.Collections;
using System.Text;

namespace SmartHome
{
	public interface IDimmerNotify
	{
		void dimmerValueChanged(String lightId, int value);

	}
}
