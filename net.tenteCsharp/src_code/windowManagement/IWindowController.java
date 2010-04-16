package windowManagement;
import windowManagement.WindowManagement.*;

public interface IWindowController extends initialModel.IDevice{
	
	public int getAperture();	
	public void setAperture(int value);	
	public String getWindowId();

}
