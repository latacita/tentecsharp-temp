package heaterManagement;
import heaterManagement.HeaterManagement.*;

public interface ITermometerGUINotify{
	
	public void newTemparature(String thermometerId,float value);	
	public void newOutsideTemperature(String termometerId,float value);	
	public String getTermometerId();

}
