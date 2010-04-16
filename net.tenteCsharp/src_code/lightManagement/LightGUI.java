

cclass lightManagement.LightManagement; 

public cclass LightGUI extends TypeComponent{ 

	public String roomId;
		public String floorId;
		public RequestPort request;
		public ActuatorPort services;
		public String lightId;
	
	
	public LightGUI (String id){
		super(id);
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
	
	public RequestPort getRequest(){
		return request;
	}
	
	public void setRequest(LightGUI.RequestPort value){
		this.request=value;
	}
	
	public ActuatorPort getServices(){
		return services;
	}
	
	public void setServices(LightGUI.ActuatorPort value){
		this.services=value;
	}
	
	public String getLightId(){
		return lightId;
	}
	
	public void setLightId(String value){
		this.lightId=value;
	}
	

	
	
	public cclass RequestPort extends TypePort implements ILightNotifiy{


		public RequestPort (){
			super();

		}


		public void changeLightIntensity(String lightId,int value){
		
		}

		public void changeLightState(String lightId,boolean state){
		
		}

	}	
	
	public cclass ActuatorPort extends TypePort{

		public ArrayList portsILightNotifiy;
		public ArrayList portsILightGUINotify;

		public ActuatorPort (){
			super();
			portsILightNotifiy=new ArrayList();
			portsILightGUINotify=new ArrayList();

		}


			
		public void connectPort(ILightNotifiy port){
			portsILightNotifiy.add(port);
		}
			
		public void connectPort(ILightGUINotify port){
			portsILightGUINotify.add(port);
		}
	}

}