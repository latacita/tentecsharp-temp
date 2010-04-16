

cclass windowManagement.WindowManagement; 

public cclass FloorGUI extends TypeComponent{ 

	public BlindNotifyPort blindNotifyPort;
		public WindowNotifyPort windowNotifyPort;
	
	
	public FloorGUI (String id){
		super(id);
	}
	
	public BlindNotifyPort getBlindNotifyPort(){
		return blindNotifyPort;
	}
	
	public void setBlindNotifyPort(FloorGUI.BlindNotifyPort value){
		this.blindNotifyPort=value;
	}
	
	public WindowNotifyPort getWindowNotifyPort(){
		return windowNotifyPort;
	}
	
	public void setWindowNotifyPort(FloorGUI.WindowNotifyPort value){
		this.windowNotifyPort=value;
	}
	

	
	
	public cclass WindowNotifyPort extends TypePort{

		public ArrayList portsIGeneralWindowNotify;

		public WindowNotifyPort (){
			super();
			portsIGeneralWindowNotify=new ArrayList();

		}


			
		public void connectPort(IGeneralWindowNotify port){
			portsIGeneralWindowNotify.add(port);
		}
	}	
	
	public cclass BlindNotifyPort extends TypePort{

		public ArrayList portsIGeneralBlindNotify;

		public BlindNotifyPort (){
			super();
			portsIGeneralBlindNotify=new ArrayList();

		}


			
		public void connectPort(IGeneralBlindNotify port){
			portsIGeneralBlindNotify.add(port);
		}
	}

}