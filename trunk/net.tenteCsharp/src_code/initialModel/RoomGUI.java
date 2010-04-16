

cclass initialModel.InitialModel; 

public cclass RoomGUI extends TypeComponent{ 

	public NotifyPort request;
	public GUIPort gui;
	public String roomId;
	public String floorId;

	
	public RoomGUI (String id){
		super(id);
	}
	
	public NotifyPort getRequest(){
		return request;
	}
	
	public void setRequest(RoomGUI.NotifyPort value){
		this.request=value;
	}
	
	public GUIPort getGui(){
		return gui;
	}
	
	public void setGui(RoomGUI.GUIPort value){
		this.gui=value;
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
	

	
	
	public cclass NotifyPort extends TypePort implements INotify{


		public NotifyPort (){
			super();

		}


		public String getId(){
			return null;		
		}

	}	
	
	public cclass GUIPort extends TypePort implements IGUI{


		public GUIPort (){
			super();

		}


		public void showGUI(){
		
		}

		public void initGUI(){
		
		}

	}

}