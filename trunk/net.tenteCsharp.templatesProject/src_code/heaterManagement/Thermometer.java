

cclass heaterManagement.HeaterManagement; 

public cclass Thermometer extends TypeComponent{ 

	public RequestPort request;
		public String floorId;
		public String thermometerId;
		public String roomId;
	
	
	public Thermometer (String id){
		super(id);
	}
	
	public RequestPort getRequest(){
		return request;
	}
	
	public void setRequest(Thermometer.RequestPort value){
		this.request=value;
	}
	
	public String getFloorId(){
		return floorId;
	}
	
	public void setFloorId(String value){
		this.floorId=value;
	}
	
	public String getThermometerId(){
		return thermometerId;
	}
	
	public void setThermometerId(String value){
		this.thermometerId=value;
	}
	
	public String getRoomId(){
		return roomId;
	}
	
	public void setRoomId(String value){
		this.roomId=value;
	}
	

	
	
	public cclass RequestPort extends TypePort implements IThermometer{

		public ArrayList portsIThermometerNotify;

		public RequestPort (){
			super();
			portsIThermometerNotify=new ArrayList();

		}


		public float getTemparature(String thermometerId){
			return 0;		
		}

		public float getOutdoorTemparature(String thermometerId){
			return 0;		
		}

			
		public void connectPort(IThermometerNotify port){
			portsIThermometerNotify.add(port);
		}
	}

}