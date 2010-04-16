

cclass initialModel.InitialModel; 

public cclass FloorGUI extends TypeComponent{ 

	public NotifyPort request;
	public GUIPort gui;
	public String floorId;
	public ArrayList roomGUIs;

	
	public FloorGUI (String id){
		super(id);
	}
	
	public NotifyPort getRequest(){
		return request;
	}
	
	public void setRequest(FloorGUI.NotifyPort value){
		this.request=value;
	}
	
	public GUIPort getGui(){
		return gui;
	}
	
	public void setGui(FloorGUI.GUIPort value){
		this.gui=value;
	}
	
	public String getFloorId(){
		return floorId;
	}
	
	public void setFloorId(String value){
		this.floorId=value;
	}
	
	public ArrayList getRoomGUIs(){
		return roomGUIs;
	}
	
	public void setRoomGUIs(ArrayList value){
		this.roomGUIs=value;
	}
	
	public void addRoomGUIsElement(RoomGUI value){
		this.roomGUIs.add(value);
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