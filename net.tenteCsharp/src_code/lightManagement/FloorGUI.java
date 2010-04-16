

cclass lightManagement.LightManagement; 

public cclass FloorGUI extends TypeComponent{ 

	public LightNotifyPort lightNotifyPort;
	
	
	public FloorGUI (String id){
		super(id);
	}
	
	public LightNotifyPort getLightNotifyPort(){
		return lightNotifyPort;
	}
	
	public void setLightNotifyPort(FloorGUI.LightNotifyPort value){
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