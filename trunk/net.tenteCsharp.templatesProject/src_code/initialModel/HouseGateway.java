

cclass initialModel.InitialModel; 

public cclass HouseGateway extends TypeComponent{ 

	public ServicesPort services;
	public House houseData;
	public ActuatorPort actuators;
	public SensorPort sensors;

	
	public HouseGateway (String id){
		super(id);
	}
	
	public ServicesPort getServices(){
		return services;
	}
	
	public void setServices(HouseGateway.ServicesPort value){
		this.services=value;
	}
	
	public House getHouseData(){
		return houseData;
	}
	
	public void setHouseData(HouseGateway.House value){
		this.houseData=value;
	}
	
	public ActuatorPort getActuators(){
		return actuators;
	}
	
	public void setActuators(HouseGateway.ActuatorPort value){
		this.actuators=value;
	}
	
	public SensorPort getSensors(){
		return sensors;
	}
	
	public void setSensors(HouseGateway.SensorPort value){
		this.sensors=value;
	}
	

	
	
	public cclass ServicesPort extends TypePort{

		public ArrayList portsIGUI;
		public ArrayList portsINotify;

		public ServicesPort (){
			super();
			portsIGUI=new ArrayList();
			portsINotify=new ArrayList();

		}


			
		public void connectPort(IGUI port){
			portsIGUI.add(port);
		}
			
		public void connectPort(INotify port){
			portsINotify.add(port);
		}
	}	
	
	public cclass ActuatorPort extends TypePort{


		public ActuatorPort (){
			super();

		}


	}	
	
	public cclass House {
		public ArrayList floors;
		public String name;
		public String id;

		public House (){
				
		}
		public ArrayList getFloors(){
			return floors;
		}
	
		public void setFloors(ArrayList value){
			this.floors=value;
		}
	
		public void addFloorsElement(Floor value){
			this.floors.add(value);
		}
	
		public String getName(){
			return name;
		}
	
		public void setName(String value){
			this.name=value;
		}
	
		public String getId(){
			return id;
		}
	
		public void setId(String value){
			this.id=value;
		}
	

		public Floor getFloorById(String id){
			return null;		
		}
		public Room getRoomById(String id){
			return null;		
		}


	}
	
	public House getHouseInstance(){
		House house=new House();
		return house;
	}	
	
	public cclass Room {
		public String id;
		public String name;

		public Room (){
				
		}
		public String getId(){
			return id;
		}
	
		public void setId(String value){
			this.id=value;
		}
	
		public String getName(){
			return name;
		}
	
		public void setName(String value){
			this.name=value;
		}
	



	}
	
	public Room getRoomInstance(){
		Room room=new Room();
		return room;
	}	
	
	public cclass Floor {
		public ArrayList rooms;
		public String id;
		public String name;

		public Floor (){
				
		}
		public ArrayList getRooms(){
			return rooms;
		}
	
		public void setRooms(ArrayList value){
			this.rooms=value;
		}
	
		public void addRoomsElement(Room value){
			this.rooms.add(value);
		}
	
		public String getId(){
			return id;
		}
	
		public void setId(String value){
			this.id=value;
		}
	
		public String getName(){
			return name;
		}
	
		public void setName(String value){
			this.name=value;
		}
	

		public void addRoom(Room room){
		
		}
		public Room searchRoomById(String id){
			return null;		
		}


	}
	
	public Floor getFloorInstance(){
		Floor floor=new Floor();
		return floor;
	}	
	
	public cclass SensorPort extends TypePort{


		public SensorPort (){
			super();

		}


	}

}