package heaterManagement;
import heaterManagement.HeaterManagement.*;

public interface IThermometerNotify{
	
	public void newTemperature(String thermometerId,float value);	
	public void newOutsideTemp(String thermometerId,float value);

}
