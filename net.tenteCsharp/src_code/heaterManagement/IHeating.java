package heaterManagement;
import heaterManagement.HeaterManagement.*;

public interface IHeating{
	
	public void setPower(String heaterId,int amount);	
	public void setMode(String heaterId,HeatingModes mode);	
	public void heatingSwitch(String heaterId,boolean on);	
	public void setTemperature(String heaterId,float temp);

}
