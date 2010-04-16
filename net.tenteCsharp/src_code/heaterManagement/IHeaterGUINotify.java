package heaterManagement;
import heaterManagement.HeaterManagement.*;

public interface IHeaterGUINotify{
	
	public void heaterTemperatureChanged(String heaterId,float newTemp);	
	public void heaterSwitchChanged(String heaterId,boolean on);

}
