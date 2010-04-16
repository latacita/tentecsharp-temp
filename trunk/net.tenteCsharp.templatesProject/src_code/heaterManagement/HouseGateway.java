

cclass heaterManagement.HeaterManagement; 

public cclass HouseGateway extends TypeComponent{ 

			
	
	public HouseGateway (String id){
		super(id);
	}
	

	
	
	public cclass ServicesPort extends TypePort implements IHeaterGUI,IHeaterGUINotify{

		public ArrayList portsITermometerGUINotify;

		public ServicesPort (){
			super();
			portsITermometerGUINotify=new ArrayList();

		}


		public void setTemperature(String heaterId,float value){
		
		}

		public void programSwitchOn(String heaterId,float value,String time){
		
		}

		public void programSwitchOff(String heaterId,String time){
		
		}

		public void heaterTemperatureChanged(String heaterId,float newTemp){
		
		}

		public void heaterSwitchChanged(String heaterId,boolean on){
		
		}

			
		public void connectPort(ITermometerGUINotify port){
			portsITermometerGUINotify.add(port);
		}
	}	
	
	public cclass ActuatorPort extends TypePort implements IGeneralHeaterNotify{

		public ArrayList portsIThermometer;
		public ArrayList portsITermometerGUINotify;
		public ArrayList portsIHeating;

		public ActuatorPort (){
			super();
			portsIThermometer=new ArrayList();
			portsITermometerGUINotify=new ArrayList();
			portsIHeating=new ArrayList();

		}


		public void switchOnAllHeaters(String floorId,String roomId){
		
		}

		public void switchOffAllHeaters(String floorId,String roomId){
		
		}

		public void changeAllHeatersTemp(float temperature,String floorId,String roomId){
		
		}

			
		public void connectPort(IThermometer port){
			portsIThermometer.add(port);
		}
			
		public void connectPort(ITermometerGUINotify port){
			portsITermometerGUINotify.add(port);
		}
			
		public void connectPort(IHeating port){
			portsIHeating.add(port);
		}
	}	
	
	public cclass Heater {
		public String heaterId;
		public String name;
		public boolean state;
		public String thermometerId;
		public int power;
		public HeatingModes mode;
		public float temperature;

		public Heater (){
				
		}
		public String getHeaterId(){
			return heaterId;
		}
	
		public void setHeaterId(String value){
			this.heaterId=value;
		}
	
		public String getName(){
			return name;
		}
	
		public void setName(String value){
			this.name=value;
		}
	
		public boolean getState(){
			return state;
		}
	
		public void setState(boolean value){
			this.state=value;
		}
	
		public String getThermometerId(){
			return thermometerId;
		}
	
		public void setThermometerId(String value){
			this.thermometerId=value;
		}
	
		public int getPower(){
			return power;
		}
	
		public void setPower(int value){
			this.power=value;
		}
	
		public HeatingModes getMode(){
			return mode;
		}
	
		public void setMode(HeaterManagement.HeatingModes value){
			this.mode=value;
		}
	
		public float getTemperature(){
			return temperature;
		}
	
		public void setTemperature(float value){
			this.temperature=value;
		}
	
		public void setTemperature(String value){
			this.temperature=Float.parseFloat(value);
		}
	



	}
	
	public Heater getHeaterInstance(){
		Heater heater=new Heater();
		return heater;
	}	
	
	public cclass Room {
		public ArrayList heaters;
		public ArrayList thermometers;

		public Room (){
				
		}
		public ArrayList getHeaters(){
			return heaters;
		}
	
		public void setHeaters(ArrayList value){
			this.heaters=value;
		}
	
		public void addHeatersElement(Heater value){
			this.heaters.add(value);
		}
	
		public ArrayList getThermometers(){
			return thermometers;
		}
	
		public void setThermometers(ArrayList value){
			this.thermometers=value;
		}
	
		public void addThermometersElement(Thermometer value){
			this.thermometers.add(value);
		}
	

		public void addThermometer(Thermometer thermometer){
		
		}
		public Heater getHeaterById(String id){
			return null;		
		}
		public Thermometer getThermometerById(String id){
			return null;		
		}
		public void addHeater(Heater heater){
		
		}


	}
	
	public Room getRoomInstance(){
		Room room=new Room();
		return room;
	}	
	
	public cclass Floor {

		public Floor (){
				
		}

		public Thermometer getThermometerById(String id){
			return null;		
		}
		public Heater getHeaterById(String id){
			return null;		
		}


	}
	
	public Floor getFloorInstance(){
		Floor floor=new Floor();
		return floor;
	}	
	
	public cclass House {

		public House (){
				
		}

		public Heater getHeaterById(String id){
			return null;		
		}
		public Thermometer getThermometerById(String id){
			return null;		
		}


	}
	
	public House getHouseInstance(){
		House house=new House();
		return house;
	}	
	
	public cclass Thermometer {
		public String name;
		public float temp;
		public float outTemp;
		public String thermometerId;

		public Thermometer (){
				
		}
		public String getName(){
			return name;
		}
	
		public void setName(String value){
			this.name=value;
		}
	
		public float getTemp(){
			return temp;
		}
	
		public void setTemp(float value){
			this.temp=value;
		}
	
		public void setTemp(String value){
			this.temp=Float.parseFloat(value);
		}
	
		public float getOutTemp(){
			return outTemp;
		}
	
		public void setOutTemp(float value){
			this.outTemp=value;
		}
	
		public void setOutTemp(String value){
			this.outTemp=Float.parseFloat(value);
		}
	
		public String getThermometerId(){
			return thermometerId;
		}
	
		public void setThermometerId(String value){
			this.thermometerId=value;
		}
	



	}
	
	public Thermometer getThermometerInstance(){
		Thermometer thermometer=new Thermometer();
		return thermometer;
	}	
	
	public cclass SensorPort extends TypePort implements IThermometerNotify{


		public SensorPort (){
			super();

		}


		public void newTemperature(String thermometerId,float value){
		
		}

		public void newOutsideTemp(String thermometerId,float value){
		
		}

	}

}