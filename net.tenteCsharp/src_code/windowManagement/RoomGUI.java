

cclass windowManagement.WindowManagement; 

public cclass RoomGUI extends TypeComponent{ 

	public BlindNotifyPort blindNotifyPort;
		public WindowNotifyPort windowNotifyPort;
		public ArrayList listWindowGUI;
		public ArrayList listBlindGUI;
	
	
	public RoomGUI (String id){
		super(id);
	}
	
	public BlindNotifyPort getBlindNotifyPort(){
		return blindNotifyPort;
	}
	
	public void setBlindNotifyPort(RoomGUI.BlindNotifyPort value){
		this.blindNotifyPort=value;
	}
	
	public WindowNotifyPort getWindowNotifyPort(){
		return windowNotifyPort;
	}
	
	public void setWindowNotifyPort(RoomGUI.WindowNotifyPort value){
		this.windowNotifyPort=value;
	}
	
	public ArrayList getListWindowGUI(){
		return listWindowGUI;
	}
	
	public void setListWindowGUI(ArrayList value){
		this.listWindowGUI=value;
	}
	
	public void addListWindowGUIElement(WindowGUI value){
		this.listWindowGUI.add(value);
	}
	
	public ArrayList getListBlindGUI(){
		return listBlindGUI;
	}
	
	public void setListBlindGUI(ArrayList value){
		this.listBlindGUI=value;
	}
	
	public void addListBlindGUIElement(BlindGUI value){
		this.listBlindGUI.add(value);
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