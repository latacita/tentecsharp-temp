package heaterManagement;
import heaterManagement.HeaterManagement.*;

public interface IGeneralHeaterNotify{
	
	public void switchOnAllHeaters(String floorId,String roomId);	
	public void switchOffAllHeaters(String floorId,String roomId);	
	public void changeAllHeatersTemp(float temperature,String floorId,String roomId);

}
