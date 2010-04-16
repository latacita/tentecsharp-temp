

cclass heaterManagement.HeaterManagement; 

public cclass CentralGUI extends TypeComponent{ 

	public HeaterNotifyPort heaterNotifyPort;
	
	
	public CentralGUI (String id){
		super(id);
	}
	
	public HeaterNotifyPort getHeaterNotifyPort(){
		return heaterNotifyPort;
	}
	
	public void setHeaterNotifyPort(CentralGUI.HeaterNotifyPort value){
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