package lightManagement;
import lightManagement.LightManagement.*;

public interface ILightNotifiy{
	
	public void changeLightIntensity(String lightId,int value);	
	public void changeLightState(String lightId,boolean state);

}
