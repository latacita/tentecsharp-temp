package smartEnergyControl;
import smartEnergyControl.SmartEnergyControl.*;

public interface ISmartEnergyNotify{
	
	public void activateSmartControl(String floorId,String roomId);	
	public void deactivateSmartControl(String floorId,String roomId);

}
