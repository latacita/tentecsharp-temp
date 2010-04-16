

cclass heaterManagement.HeaterManagement; 

public cclass RoomGUI extends TypeComponent{ 

	public HeaterNotifyPort heaterNotifyPort;
		public ArrayList listThermometerGUI;
		public ArrayList listHeaterGUI;
	
	
	public RoomGUI (String id){
		super(id);
	}
	
	public HeaterNotifyPort getHeaterNotifyPort(){
		return heaterNotifyPort;
	}
	
	public void setHeaterNotifyPort(RoomGUI.HeaterNotifyPort value){
		this.heaterNotifyPort=value;
	}
	
	public ArrayList getListThermometerGUI(){
		return listThermometerGUI;
	}
	
	public void setListThermometerGUI(ArrayList value){
		this.listThermometerGUI=value;
	}
	
	public void addListThermometerGUIElement(ThermometerGUI value){
		this.listThermometerGUI.add(value);
	}
	
	public ArrayList getListHeaterGUI(){
		return listHeaterGUI;
	}
	
	public void setListHeaterGUI(ArrayList value){
		this.listHeaterGUI=value;
	}
	
	public void addListHeaterGUIElement(HeaterGUI value){
		this.listHeaterGUI.add(value);
	}
	

	
	
	public cclass HeaterNotifyPort extends TypePort{

		public ArrayList portsIGeneralHeaterNotify;

		public HeaterNotifyPort (){
			super();
			portsIGeneralHeaterNotify=new ArrayList();

		}


			
		public void connectPort(IGeneralHeaterNotify port){
			portsIGeneralHeaterNotify.add(port);
		}
	}

}