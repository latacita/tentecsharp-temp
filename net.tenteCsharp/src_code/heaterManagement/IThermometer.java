package heaterManagement;
import heaterManagement.HeaterManagement.*;

public interface IThermometer{
	
	public float getTemparature(String thermometerId);	
	public float getOutdoorTemparature(String thermometerId);

}
