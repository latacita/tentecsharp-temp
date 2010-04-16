package windowManagement;
import windowManagement.WindowManagement.*;

public interface IBlindDimmer extends initialModel.IDevice{
	
	public int getAperture();	
	public void setAperture(int value);	
	public String getBlindId();

}
