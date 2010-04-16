package lightManagement;
import lightManagement.LightManagement.*;

public interface ISwitch extends initialModel.IDevice{
	
	public SwitchStatus getStatus();	
	public void setStatus(SwitchStatus value);	
	public String getLightId();

}
