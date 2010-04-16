

cclass windowManagement.WindowManagement; 

public cclass BlindDimmer extends TypeComponent{ 

	public BlindDimmerPort request;
		public String floorId;
		public String blindId;
		public String roomId;
	
	
	public BlindDimmer (String id){
		super(id);
	}
	
	public BlindDimmerPort getRequest(){
		return request;
	}
	
	public void setRequest(BlindDimmer.BlindDimmerPort value){
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
	

	
	
	public cclass BlindDimmerPort extends TypePort implements IBlindDimmer{

		public ArrayList portsIBlindDimmerNotify;

		public BlindDimmerPort (){
			super();
			portsIBlindDimmerNotify=new ArrayList();

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

			
		public void connectPort(IBlindDimmerNotify port){
			portsIBlindDimmerNotify.add(port);
		}
	}

}