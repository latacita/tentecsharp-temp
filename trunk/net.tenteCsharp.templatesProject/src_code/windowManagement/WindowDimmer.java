

cclass windowManagement.WindowManagement; 

public cclass WindowDimmer extends TypeComponent{ 

	public WindowDimmerPort request;
		public String floorId;
		public String windowId;
		public String roomId;
	
	
	public WindowDimmer (String id){
		super(id);
	}
	
	public WindowDimmerPort getRequest(){
		return request;
	}
	
	public void setRequest(WindowDimmer.WindowDimmerPort value){
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
	

	
	
	public cclass WindowDimmerPort extends TypePort implements IWindowDimmer{

		public ArrayList portsIWindowDimmerNotify;

		public WindowDimmerPort (){
			super();
			portsIWindowDimmerNotify=new ArrayList();

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

			
		public void connectPort(IWindowDimmerNotify port){
			portsIWindowDimmerNotify.add(port);
		}
	}

}