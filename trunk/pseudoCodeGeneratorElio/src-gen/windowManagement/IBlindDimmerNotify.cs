using System;
using System.Collections;
using System.Text;

namespace SmartHome
{
	public interface IBlindDimmerNotify
	{
		void blindDimmerValueChanged(int value, String blindId);

	}
}
