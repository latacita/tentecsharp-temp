package heaterManagement;
import heaterManagement.HeaterManagement.*;

public interface IHeaterGUI{
	
	public void setTemperature(String heaterId,float value);	
	public void programSwitchOn(String heaterId,float value,String time);	
	public void programSwitchOff(String heaterId,String time);

}
