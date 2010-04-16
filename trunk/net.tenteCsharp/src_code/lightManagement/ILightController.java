package lightManagement;
import lightManagement.LightManagement.*;

public interface ILightController extends initialModel.IDevice{
	
	public void setValue(int value);	
	public int getValue();	
	public void switchOn();	
	public void switchOff();	
	public String getLightId();

}
