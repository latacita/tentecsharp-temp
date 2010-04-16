package windowManagement;
import windowManagement.WindowManagement.*;

public interface IBlindController extends initialModel.IDevice{
	
	public int getAperture();	
	public void setAperture(int value);	
	public String getBlindId();

}
