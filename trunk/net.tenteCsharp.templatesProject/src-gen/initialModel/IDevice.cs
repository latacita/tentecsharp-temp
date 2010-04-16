using System;
using System.Collections;
using System.Text;

namespace SmartHome
{
	public interface IDevice
	{
		String getId();
		void setRoomId(String roomId);
		String getRoomId();
		void setFloorId(String floorId);
		String getFloorId();

	}
}
