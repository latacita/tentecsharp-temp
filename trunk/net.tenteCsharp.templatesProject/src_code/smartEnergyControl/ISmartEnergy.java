package smartEnergyControl;
import smartEnergyControl.SmartEnergyControl.*;

public interface ISmartEnergy{
	
	public void activateSmartControl(String floorId,String roomId);	
	public void deactivateSmartControl(String floorId,String roomId);

}
