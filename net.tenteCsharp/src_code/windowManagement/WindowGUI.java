

cclass windowManagement.WindowManagement; 

public cclass WindowGUI extends TypeComponent{ 

	public RequestPort request;
		public ActuatorPort services;
		public String roomId;
		public String floorId;
		public String windowId;
	
	
	public WindowGUI (String id){
		super(id);
	}
	
	public RequestPort getRequest(){
		return request;
	}
	
	public void setRequest(WindowGUI.RequestPort value){
		this.request=value;
	}
	
	public ActuatorPort getServices(){
		return services;
	}
	
	public void setServices(WindowGUI.ActuatorPort value){
		this.services=value;
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
	
	public String getWindowId(){
		return windowId;
	}
	
	public void setWindowId(String value){
		this.windowId=value;
	}
	

	
	
	public cclass ActuatorPort extends TypePort{

		public ArrayList portsIWindowGUINotify;

		public ActuatorPort (){
			super();
			portsIWindowGUINotify=new ArrayList();

		}


			
		public void connectPort(IWindowGUINotify port){
			portsIWindowGUINotify.add(port);
		}
	}	
	
	public cclass RequestPort extends TypePort implements IWindowNotifiy{


		public RequestPort (){
			super();

		}


		public void changeWindowAperture(String windowId,int value){
		
		}

	}

}