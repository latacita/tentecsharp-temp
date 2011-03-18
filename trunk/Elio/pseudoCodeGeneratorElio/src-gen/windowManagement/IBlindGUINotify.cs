using System;
using System.Collections;
using System.Text;

namespace SmartHome
{
	public interface IBlindGUINotify
	{
		void changeBlindAperture(String blindId, int value);

	}
}
