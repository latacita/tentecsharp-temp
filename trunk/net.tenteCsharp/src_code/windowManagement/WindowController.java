

cclass windowManagement.WindowManagement; 

public cclass WindowController extends TypeComponent{ 

	public WindowControllerPort request;
		public String floorId;
		public String windowId;
		public String roomId;
	
	
	public WindowController (String id){
		super(id);
	}
	
	public WindowControllerPort getRequest(){
		return request;
	}
	
	public void setRequest(WindowController.WindowControllerPort value){
		this.request=value;
	}
	
	public String getFloorId(){
		return floorId;
	}
	
	public void setFloorId(String value){
		this.floorId=value;
	}
	
	public String getWindowId(){
		return windowId;
	}
	
	public void setWindowId(String value){
		this.windowId=value;
	}
	
	public String getRoomId(){
		return roomId;
	}
	
	public void setRoomId(String value){
		this.roomId=value;
	}
	

	
	
	public cclass WindowControllerPort extends TypePort implements IWindowController{


		public WindowControllerPort (){
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

		public String getWindowId(){
			return null;		
		}

	}

}