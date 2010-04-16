

cclass windowManagement.WindowManagement; 

public cclass BlindController extends TypeComponent{ 

	public BlindControllerPort request;
		public String floorId;
		public String blindId;
		public String roomId;
	
	
	public BlindController (String id){
		super(id);
	}
	
	public BlindControllerPort getRequest(){
		return request;
	}
	
	public void setRequest(BlindController.BlindControllerPort value){
		this.request=value;
	}
	
	public String getFloorId(){
		return floorId;
	}
	
	public void setFloorId(String value){
		this.floorId=value;
	}
	
	public String getBlindId(){
		return blindId;
	}
	
	public void setBlindId(String value){
		this.blindId=value;
	}
	
	public String getRoomId(){
		return roomId;
	}
	
	public void setRoomId(String value){
		this.roomId=value;
	}
	

	
	
	public cclass BlindControllerPort extends TypePort implements IBlindController{


		public BlindControllerPort (){
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


		public int getAperture(){
			return 0;		
		}

		public void setAperture(int value){
		
		}

		public String getBlindId(){
			return null;		
		}

	}

}