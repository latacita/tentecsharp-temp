package lightManagement;
import lightManagement.LightManagement.*;

public interface ILightGUINotify{
	
	public void changeLightIntensity(String lightId,int value);	
	public void changeLightState(String lightId,boolean state);

}
