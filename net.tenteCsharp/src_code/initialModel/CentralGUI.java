

cclass initialModel.InitialModel; 

public cclass CentralGUI extends TypeComponent{ 

	public NotifyPort request;
	public GUIPort gui;
	public String houseId;
	public ArrayList floorGUIs;

	
	public CentralGUI (String id){
		super(id);
	}
	
	public NotifyPort getRequest(){
		return request;
	}
	
	public void setRequest(CentralGUI.NotifyPort value){
		this.request=value;
	}
	
	public GUIPort getGui(){
		return gui;
	}
	
	public void setGui(CentralGUI.GUIPort value){
		this.gui=value;
	}
	
	public String getHouseId(){
		return houseId;
	}
	
	public void setHouseId(String value){
		this.houseId=value;
	}
	
	public ArrayList getFloorGUIs(){
		return floorGUIs;
	}
	
	public void setFloorGUIs(ArrayList value){
		this.floorGUIs=value;
	}
	
	public void addFloorGUIsElement(FloorGUI value){
		this.floorGUIs.add(value);
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