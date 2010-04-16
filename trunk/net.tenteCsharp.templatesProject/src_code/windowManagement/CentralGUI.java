

cclass windowManagement.WindowManagement; 

public cclass CentralGUI extends TypeComponent{ 

	public WindowNotifyPort windowNotifyPort;
		public BlindNotifyPort blindNotifyPort;
	
	
	public CentralGUI (String id){
		super(id);
	}
	
	public WindowNotifyPort getWindowNotifyPort(){
		return windowNotifyPort;
	}
	
	public void setWindowNotifyPort(CentralGUI.WindowNotifyPort value){
		this.windowNotifyPort=value;
	}
	
	public BlindNotifyPort getBlindNotifyPort(){
		return blindNotifyPort;
	}
	
	public void setBlindNotifyPort(CentralGUI.BlindNotifyPort value){
		this.blindNotifyPort=value;
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