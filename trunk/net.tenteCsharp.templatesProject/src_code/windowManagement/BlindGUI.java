

cclass windowManagement.WindowManagement; 

public cclass BlindGUI extends TypeComponent{ 

	public RequestPort request;
		public ActuatorPort services;
		public String floorId;
		public String roomId;
		public String blindId;
	
	
	public BlindGUI (String id){
		super(id);
	}
	
	public RequestPort getRequest(){
		return request;
	}
	
	public void setRequest(BlindGUI.RequestPort value){
		this.request=value;
	}
	
	public ActuatorPort getServices(){
		return services;
	}
	
	public void setServices(BlindGUI.ActuatorPort value){
		this.services=value;
	}
	
	public String getFloorId(){
		return floorId;
	}
	
	public void setFloorId(String value){
		this.floorId=value;
	}
	
	public String getRoomId(){
		return roomId;
	}
	
	public void setRoomId(String value){
		this.roomId=value;
	}
	
	public String getBlindId(){
		return blindId;
	}
	
	public void setBlindId(String value){
		this.blindId=value;
	}
	

	
	
	public cclass ActuatorPort extends TypePort{

		public ArrayList portsIBlindGUINotify;

		public ActuatorPort (){
			super();
			portsIBlindGUINotify=new ArrayList();

		}


			
		public void connectPort(IBlindGUINotify port){
			portsIBlindGUINotify.add(port);
		}
	}	
	
	public cclass RequestPort extends TypePort implements IBlindNotifiy{


		public RequestPort (){
			super();

		}


		public void changeBlindAperture(String blindId,int value){
		
		}

	}

}