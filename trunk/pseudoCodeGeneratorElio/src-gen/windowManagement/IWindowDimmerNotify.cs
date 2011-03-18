using System;
using System.Collections;
using System.Text;

namespace SmartHome
{
	public interface IWindowDimmerNotify
	{
		void windowDimmerValueChanged(int value, String windowId);

	}
}
