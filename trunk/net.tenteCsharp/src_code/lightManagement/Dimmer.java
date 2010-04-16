

cclass lightManagement.LightManagement; 

public cclass Dimmer extends TypeComponent{ 

	public RequestPort request;
		public String lightId;
		public String floorId;
		public String roomId;
	
	
	public Dimmer (String id){
		super(id);
	}
	
	public RequestPort getRequest(){
		return request;
	}
	
	public void setRequest(Dimmer.RequestPort value){
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
	

	
	
	public cclass RequestPort extends TypePort implements IDimmer{

		public ArrayList portsIDimmerNotify;

		public RequestPort (){
			super();
			portsIDimmerNotify=new ArrayList();

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


		public int getValue(){
			return 0;		
		}

		public void setValue(int value){
		
		}

		public String getLightId(){
			return null;		
		}

			
		public void connectPort(IDimmerNotify port){
			portsIDimmerNotify.add(port);
		}
	}

}