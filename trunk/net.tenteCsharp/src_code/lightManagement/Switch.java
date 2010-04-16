

cclass lightManagement.LightManagement; 

public cclass Switch extends TypeComponent{ 

	public SwitchStatus status;
		public SwitchPort request;
		public String lightId;
		public String floorId;
		public String roomId;
	
	
	public Switch (String id){
		super(id);
	}
	
	public SwitchStatus getStatus(){
		return status;
	}
	
	public void setStatus(LightManagement.SwitchStatus value){
		this.status=value;
	}
	
	public SwitchPort getRequest(){
		return request;
	}
	
	public void setRequest(Switch.SwitchPort value){
		this.request=value;
	}
	
	public String getLightId(){
		return lightId;
	}
	
	public void setLightId(String value){
		this.lightId=value;
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
	

	
	
	public cclass SwitchPort extends TypePort implements ISwitch{

		public ArrayList portsISwitchNotify;

		public SwitchPort (){
			super();
			portsISwitchNotify=new ArrayList();

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


		public SwitchStatus getStatus(){
			return null;		
		}

		public void setStatus(SwitchStatus value){
		
		}

		public String getLightId(){
			return null;		
		}

			
		public void connectPort(ISwitchNotify port){
			portsISwitchNotify.add(port);
		}
	}

}