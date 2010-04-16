package lightManagement;
import lightManagement.LightManagement.*;

public interface IGeneralLightNotify{
	
	public void switchOffAllLights(String floorId,String roomId);	
	public void switchOnAllLights(String floorId,String roomId);	
	public void changeAllLightsIntensity(int intensity,String floorId,String roomId);

}
