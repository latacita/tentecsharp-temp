

cclass lightManagement.LightManagement; 

public cclass CentralGUI extends TypeComponent{ 

	public LightNotifyPort lightNotifyPort;
	
	
	public CentralGUI (String id){
		super(id);
	}
	
	public LightNotifyPort getLightNotifyPort(){
		return lightNotifyPort;
	}
	
	public void setLightNotifyPort(CentralGUI.LightNotifyPort value){
		this.lightNotifyPort=value;
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