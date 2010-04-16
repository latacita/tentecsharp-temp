

cclass windowManagement.WindowManagement; 

public cclass HouseGateway extends TypeComponent{ 

			
	
	public HouseGateway (String id){
		super(id);
	}
	

	
	
	public cclass House {

		public House (){
				
		}

		public Window getWindowById(String id){
			return null;		
		}
		public Blind getBlindById(String id){
			return null;		
		}


	}
	
	public House getHouseInstance(){
		House house=new House();
		return house;
	}	
	
	public cclass Room {
		public ArrayList windows;
		public ArrayList blinds;

		public Room (){
				
		}
		public ArrayList getWindows(){
			return windows;
		}
	
		public void setWindows(ArrayList value){
			this.windows=value;
		}
	
		public void addWindowsElement(Window value){
			this.windows.add(value);
		}
	
		public ArrayList getBlinds(){
			return blinds;
		}
	
		public void setBlinds(ArrayList value){
			this.blinds=value;
		}
	
		public void addBlindsElement(Blind value){
			this.blinds.add(value);
		}
	

		public void addWindow(Window window){
		
		}
		public Window getWindowById(String id){
			return null;		
		}
		public void addBlind(Blind value){
		
		}
		public Blind getBlindById(){
			return null;		
		}


	}
	
	public Room getRoomInstance(){
		Room room=new Room();
		return room;
	}	
	
	public cclass Window {
		public String id;
		public String name;

		public Window (){
				
		}
		public String getId(){
			return id;
		}
	
		public void setId(String value){
			this.id=value;
		}
	
		public String getName(){
			return name;
		}
	
		public void setName(String value){
			this.name=value;
		}
	



	}
	
	public Window getWindowInstance(){
		Window window=new Window();
		return window;
	}	
	
	public cclass Floor {

		public Floor (){
				
		}

		public Window getWindowById(String id){
			return null;		
		}
		public Blind getBlindById(String id){
			return null;		
		}


	}
	
	public Floor getFloorInstance(){
		Floor floor=new Floor();
		return floor;
	}	
	
	public cclass Blind {
		public String name;
		public String id;

		public Blind (){
				
		}
		public String getName(){
			return name;
		}
	
		public void setName(String value){
			this.name=value;
		}
	
		public String getId(){
			return id;
		}
	
		public void setId(String value){
			this.id=value;
		}
	



	}
	
	public Blind getBlindInstance(){
		Blind blind=new Blind();
		return blind;
	}	
	
	public cclass ActuatorPort extends TypePort implements IBlindGUINotify,IWindowGUINotify,IGeneralWindowNotify,IGeneralBlindNotify{

		public ArrayList portsIBlindDimmer;
		public ArrayList portsIBlindController;
		public ArrayList portsIWindowDimmer;
		public ArrayList portsIWindowController;

		public ActuatorPort (){
			super();
			portsIBlindDimmer=new ArrayList();
			portsIBlindController=new ArrayList();
			portsIWindowDimmer=new ArrayList();
			portsIWindowController=new ArrayList();

		}


		public void changeBlindAperture(String blindId,int value){
		
		}

		public void changeWindowAperture(String windowId,int value){
		
		}

		public void changeAllWindowsAperture(int aperture,String floorId,String roomId){
		
		}

		public void changeAllBlindsAperture(int aperture,String floorId,String roomId){
		
		}

			
		public void connectPort(IBlindDimmer port){
			portsIBlindDimmer.add(port);
		}
			
		public void connectPort(IBlindController port){
			portsIBlindController.add(port);
		}
			
		public void connectPort(IWindowDimmer port){
			portsIWindowDimmer.add(port);
		}
			
		public void connectPort(IWindowController port){
			portsIWindowController.add(port);
		}
	}	
	
	public cclass ServicesPort extends TypePort{

		public ArrayList portsIWindowNotifiy;
		public ArrayList portsIBlindNotifiy;

		public ServicesPort (){
			super();
			portsIWindowNotifiy=new ArrayList();
			portsIBlindNotifiy=new ArrayList();

		}


			
		public void connectPort(IWindowNotifiy port){
			portsIWindowNotifiy.add(port);
		}
			
		public void connectPort(IBlindNotifiy port){
			portsIBlindNotifiy.add(port);
		}
	}	
	
	public cclass SensorPort extends TypePort implements IBlindDimmerNotify,IWindowDimmerNotify{


		public SensorPort (){
			super();

		}


		public void blindDimmerValueChanged(int value,String blindId){
		
		}

		public void windowDimmerValueChanged(int value,String windowId){
		
		}

	}

}