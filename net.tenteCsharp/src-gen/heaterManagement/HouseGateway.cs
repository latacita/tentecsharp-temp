using System;
using System.Collections;
using System.Text;

namespace SmartHome
{
	public partial class HouseGateway : TypeComponent
	{
			
		public HouseGateway (String id) 
			: base(id)
		{
		}

	
		
		public class ServicesPort_heaterManagement : TypePort , IHeaterGUI,IHeaterGUINotify
		{
 		public ArrayList portsITermometerGUINotify = new ArrayList();

			public ServicesPort_heaterManagement()
				: base()
			{
				portsITermometerGUINotify=new ArrayList();

			}


		public void setTemperature(String heaterId,float value)
			{
		
			}

		public void programSwitchOn(String heaterId,float value,String time)
			{
		
			}

		public void programSwitchOff(String heaterId,String time)
			{
		
			}

		public void heaterTemperatureChanged(String heaterId,float newTemp)
			{
		
			}

		public void heaterSwitchChanged(String heaterId,boolean on)
			{
		
			}

			public ArrayList getPortsITermometerGUINotify()
			{
	        	return portsITermometerGUINotify;
	        }
				
			public void connectPort(ITermometerGUINotify port)
			{
				portsITermometerGUINotify.Add(port);
			}
	
		}	
		
		public class ActuatorPort_heaterManagement : TypePort , IGeneralHeaterNotify
		{
 		public ArrayList portsIThermometer = new ArrayList();
		public ArrayList portsITermometerGUINotify = new ArrayList();
		public ArrayList portsIHeating = new ArrayList();

			public ActuatorPort_heaterManagement()
				: base()
			{
				portsIThermometer=new ArrayList();
				portsITermometerGUINotify=new ArrayList();
				portsIHeating=new ArrayList();

			}


		public void switchOnAllHeaters(String floorId,String roomId)
			{
		
			}

		public void switchOffAllHeaters(String floorId,String roomId)
			{
		
			}

		public void changeAllHeatersTemp(float temperature,String floorId,String roomId)
			{
		
			}

			public ArrayList getPortsIThermometer()
			{
	        	return portsIThermometer;
	        }
				
			public void connectPort(IThermometer port)
			{
				portsIThermometer.Add(port);
			}

			public ArrayList getPortsITermometerGUINotify()
			{
	        	return portsITermometerGUINotify;
	        }
				
			public void connectPort(ITermometerGUINotify port)
			{
				portsITermometerGUINotify.Add(port);
			}

			public ArrayList getPortsIHeating()
			{
	        	return portsIHeating;
	        }
				
			public void connectPort(IHeating port)
			{
				portsIHeating.Add(port);
			}
	
		}

		public class Heater 
		{		
			public String heaterId; 
			public String name; 
			public Boolean state; 
			public String thermometerId; 
			public int power; 
			public HeatingModes mode; 
			public float temperature; 

			public Heater()
			{
			}
			public String   getHeaterId()
			{
				return heaterId;
			}
			public void setHeaterId(String value)
			{
				this.heaterId=value;
			}
	
			public String   getName()
			{
				return name;
			}
			public void setName(String value)
			{
				this.name=value;
			}
	
			public Boolean   getState()
			{
				return state;
			}
			public void setState(Boolean value)
			{
				this.state=value;
			}
	
			public String   getThermometerId()
			{
				return thermometerId;
			}
			public void setThermometerId(String value)
			{
				this.thermometerId=value;
			}
	
			public int   getPower()
			{
				return power;
			}
			public void setPower(int value)
			{
				this.power=value;
			}
	
			public HeatingModes   getMode()
			{
				return mode;
			}
			public void setMode(HeaterManagement.HeatingModes value)
			{
				this.mode=value;
			}
	
			public float   getTemperature()
			{
				return temperature;
			}
			public void setTemperature(float value)
			{
				this.temperature=value;
			}
		
			public void setTemperature(String value){
				this.temperature=float.parse(value);
			}
	

		}
			
			public Heater getHeaterInstance()
			{
				Heater heater=new Heater();
				return heater;
			}

		public class Room_heaterManagement 
		{		
			public ArrayList  heaters = new ArrayList(); 
			public ArrayList  thermometers = new ArrayList(); 

			public Room_heaterManagement()
			{
			}
			public ArrayList getHeaters()
			{
				return heaters;
			}
			public void setHeaters(ArrayList value)
			{
				this.heaters=value;
			}
		
			public void addHeatersElement(Heater value)
			{
				this.heaters.Add(value);
			}
	
			public ArrayList getThermometers()
			{
				return thermometers;
			}
			public void setThermometers(ArrayList value)
			{
				this.thermometers=value;
			}
		
			public void addThermometersElement(Thermometer value)
			{
				this.thermometers.Add(value);
			}
	
		public void addThermometer(Thermometer  thermometer)
		{
		
		}
		public Heater getHeaterById(String  id)
		{
			return null;		
		}
		public Thermometer getThermometerById(String  id)
		{
			return null;		
		}
		public void addHeater(Heater  heater)
		{
		
		}

		}
			
			public Room getRoomInstance()
			{
				Room room=new Room();
				return room;
			}

		public class Floor_heaterManagement 
		{		

			public Floor_heaterManagement()
			{
			}
		public Thermometer getThermometerById(String  id)
		{
			return null;		
		}
		public Heater getHeaterById(String  id)
		{
			return null;		
		}

		}
			
			public Floor getFloorInstance()
			{
				Floor floor=new Floor();
				return floor;
			}

		public class House_heaterManagement 
		{		

			public House_heaterManagement()
			{
			}
		public Heater getHeaterById(String  id)
		{
			return null;		
		}
		public Thermometer getThermometerById(String  id)
		{
			return null;		
		}

		}
			
			public House getHouseInstance()
			{
				House house=new House();
				return house;
			}

		public class Thermometer 
		{		
			public String name; 
			public float temp; 
			public float outTemp; 
			public String thermometerId; 

			public Thermometer()
			{
			}
			public String   getName()
			{
				return name;
			}
			public void setName(String value)
			{
				this.name=value;
			}
	
			public float   getTemp()
			{
				return temp;
			}
			public void setTemp(float value)
			{
				this.temp=value;
			}
		
			public void setTemp(String value){
				this.temp=float.parse(value);
			}
	
			public float   getOutTemp()
			{
				return outTemp;
			}
			public void setOutTemp(float value)
			{
				this.outTemp=value;
			}
		
			public void setOutTemp(String value){
				this.outTemp=float.parse(value);
			}
	
			public String   getThermometerId()
			{
				return thermometerId;
			}
			public void setThermometerId(String value)
			{
				this.thermometerId=value;
			}
	

		}
			
			public Thermometer getThermometerInstance()
			{
				Thermometer thermometer=new Thermometer();
				return thermometer;
			}	
		
		public class SensorPort_heaterManagement : TypePort , IThermometerNotify
		{
 
			public SensorPort_heaterManagement()
				: base()
			{

			}


		public void newTemperature(String thermometerId,float value)
			{
		
			}

		public void newOutsideTemp(String thermometerId,float value)
			{
		
			}
	
		}
	}
}