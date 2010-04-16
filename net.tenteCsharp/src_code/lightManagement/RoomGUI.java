

cclass lightManagement.LightManagement; 

public cclass RoomGUI extends TypeComponent{ 

	public LightNotifyPort lightNotifyPort;
		public ArrayList listLightGUI;
	
	
	public RoomGUI (String id){
		super(id);
	}
	
	public LightNotifyPort getLightNotifyPort(){
		return lightNotifyPort;
	}
	
	public void setLightNotifyPort(RoomGUI.LightNotifyPort value){
		this.lightNotifyPort=value;
	}
	
	public ArrayList getListLightGUI(){
		return listLightGUI;
	}
	
	public void setListLightGUI(ArrayList value){
		this.listLightGUI=value;
	}
	
	public void addListLightGUIElement(LightGUI value){
		this.listLightGUI.add(value);
	}
	

	
	
	public cclass LightNotifyPort extends TypePort{

		public ArrayList portsIGeneralLightNotify;

		public LightNotifyPort (){
			super();
			portsIGeneralLightNotify=new ArrayList();

		}


			
		public void connectPort(IGeneralLightNotify port){
			portsIGeneralLightNotify.add(port);
		}
	}

}