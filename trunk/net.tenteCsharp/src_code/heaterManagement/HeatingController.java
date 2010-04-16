

cclass heaterManagement.HeaterManagement; 

public cclass HeatingController extends TypeComponent{ 

	public RequestPort request;
		public String floorId;
		public String heaterId;
		public String roomId;
	
	
	public HeatingController (String id){
		super(id);
	}
	
	public RequestPort getRequest(){
		return request;
	}
	
	public void setRequest(HeatingController.RequestPort value){
		this.request=value;
	}
	
	public String getFloorId(){
		return floorId;
	}
	
	public void setFloorId(String value){
		this.floorId=value;
	}
	
	public String getHeaterId(){
		return heaterId;
	}
	
	public void setHeaterId(String value){
		this.heaterId=value;
	}
	
	public String getRoomId(){
		return roomId;
	}
	
	public void setRoomId(String value){
		this.roomId=value;
	}
	

	
	
	public cclass RequestPort extends TypePort implements IHeating{


		public RequestPort (){
			super();

		}


		public void setPower(String heaterId,int amount){
		
		}

		public void setMode(String heaterId,HeatingModes mode){
		
		}

		public void heatingSwitch(String heaterId,boolean on){
		
		}

		public void setTemperature(String heaterId,float temp){
		
		}

	}

}