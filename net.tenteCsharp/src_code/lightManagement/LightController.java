

cclass lightManagement.LightManagement; 

public cclass LightController extends TypeComponent{ 

	public LightControllerPort request;
		public String lightId;
		public String roomId;
		public String floorId;
	
	
	public LightController (String id){
		super(id);
	}
	
	public LightControllerPort getRequest(){
		return request;
	}
	
	public void setRequest(LightController.LightControllerPort value){
		this.request=value;
	}
	
	public String getLightId(){
		return lightId;
	}
	
	public void setLightId(String value){
		this.lightId=value;
	}
	
	public String getRoomId(){
		return roomId;
	}
	
	public void setRoomId(String value){
		this.roomId=value;
	}
	
	public String getFloorId(){
		return floorId;
	}
	
	public void setFloorId(String value){
		this.floorId=value;
	}
	

	
	
	public cclass LightControllerPort extends TypePort implements ILightController{


		public LightControllerPort (){
			super();

		}
		public String getId(){
			return null;		
		}
		public void setRoomId(String roomId){
		
		}
		public String getRoomId(){
			return null;		
		}
		public void setFloorId(String floorId){
		
		}
		public String getFloorId(){
			return null;		
		}


		public void setValue(int value){
		
		}

		public int getValue(){
			return 0;		
		}

		public void switchOn(){
		
		}

		public void switchOff(){
		
		}

		public String getLightId(){
			return null;		
		}

	}

}