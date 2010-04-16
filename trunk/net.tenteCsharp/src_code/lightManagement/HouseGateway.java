

cclass lightManagement.LightManagement; 

public cclass HouseGateway extends TypeComponent{ 

			
	
	public HouseGateway (String id){
		super(id);
	}
	

	
	
	public cclass SensorPort extends TypePort implements IDimmerNotify,ISwitchNotify{


		public SensorPort (){
			super();

		}


		public void dimmerValueChanged(String lightId,int value){
		
		}

		public void switchValueChanged(String lightId,SwitchStatus value){
		
		}

	}	
	
	public cclass ActuatorPort extends TypePort implements ILightGUINotify,IGeneralLightNotify{

		public ArrayList portsISwitch;
		public ArrayList portsIDimmer;
		public ArrayList portsILightController;

		public ActuatorPort (){
			super();
			portsISwitch=new ArrayList();
			portsIDimmer=new ArrayList();
			portsILightController=new ArrayList();

		}


		public void changeLightIntensity(String lightId,int value){
		
		}

		public void changeLightState(String lightId,boolean state){
		
		}

		public void switchOffAllLights(String floorId,String roomId){
		
		}

		public void switchOnAllLights(String floorId,String roomId){
		
		}

		public void changeAllLightsIntensity(int intensity,String floorId,String roomId){
		
		}

			
		public void connectPort(ISwitch port){
			portsISwitch.add(port);
		}
			
		public void connectPort(IDimmer port){
			portsIDimmer.add(port);
		}
			
		public void connectPort(ILightController port){
			portsILightController.add(port);
		}
	}	
	
	public cclass House {

		public House (){
				
		}

		public Light getLightById(String id){
			return null;		
		}


	}
	
	public House getHouseInstance(){
		House house=new House();
		return house;
	}	
	
	public cclass Floor {

		public Floor (){
				
		}

		public Light getLightById(String id){
			return null;		
		}


	}
	
	public Floor getFloorInstance(){
		Floor floor=new Floor();
		return floor;
	}	
	
	public cclass Room {
		public ArrayList lights;

		public Room (){
				
		}
		public ArrayList getLights(){
			return lights;
		}
	
		public void setLights(ArrayList value){
			this.lights=value;
		}
	
		public void addLightsElement(Light value){
			this.lights.add(value);
		}
	

		public void addLight(Light light){
		
		}
		public Light getLightById(String id){
			return null;		
		}


	}
	
	public Room getRoomInstance(){
		Room room=new Room();
		return room;
	}	
	
	public cclass Light {
		public String id;
		public int intensity;
		public String name;
		public boolean lightOn;

		public Light (){
				
		}
		public String getId(){
			return id;
		}
	
		public void setId(String value){
			this.id=value;
		}
	
		public int getIntensity(){
			return intensity;
		}
	
		public void setIntensity(int value){
			this.intensity=value;
		}
	
		public String getName(){
			return name;
		}
	
		public void setName(String value){
			this.name=value;
		}
	
		public boolean getLightOn(){
			return lightOn;
		}
	
		public void setLightOn(boolean value){
			this.lightOn=value;
		}
	



	}
	
	public Light getLightInstance(){
		Light light=new Light();
		return light;
	}	
	
	public cclass ServicesPort extends TypePort{

		public ArrayList portsILightNotifiy;

		public ServicesPort (){
			super();
			portsILightNotifiy=new ArrayList();

		}


			
		public void connectPort(ILightNotifiy port){
			portsILightNotifiy.add(port);
		}
	}

}