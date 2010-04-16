

cclass heaterManagement.HeaterManagement; 

public cclass FloorGUI extends TypeComponent{ 

	public HeaterNotifyPort heaterNotifyPort;
	
	
	public FloorGUI (String id){
		super(id);
	}
	
	public HeaterNotifyPort getHeaterNotifyPort(){
		return heaterNotifyPort;
	}
	
	public void setHeaterNotifyPort(FloorGUI.HeaterNotifyPort value){
		this.heaterNotifyPort=value;
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