package lightManagement;
import lightManagement.LightManagement.*;

public interface IDimmer extends initialModel.IDevice{
	
	public int getValue();	
	public void setValue(int value);	
	public String getLightId();

}
