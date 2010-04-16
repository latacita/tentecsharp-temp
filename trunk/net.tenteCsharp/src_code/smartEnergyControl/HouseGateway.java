

cclass smartEnergyControl.SmartEnergyControl; 

public cclass HouseGateway extends TypeComponent{ 

	public SmartPort smartEnergyPort;
		public SmartNotifyPort smartEnergyNotifyPort;
	
	
	public HouseGateway (String id){
		super(id);
	}
	
	public SmartPort getSmartEnergyPort(){
		return smartEnergyPort;
	}
	
	public void setSmartEnergyPort(HouseGateway.SmartPort value){
		this.smartEnergyPort=value;
	}
	
	public SmartNotifyPort getSmartEnergyNotifyPort(){
		return smartEnergyNotifyPort;
	}
	
	public void setSmartEnergyNotifyPort(HouseGateway.SmartNotifyPort value){
		this.smartEnergyNotifyPort=value;
	}
	

	
	
	public cclass Room {
		public boolean smartControlActive;

		public Room (){
				
		}
		public boolean getSmartControlActive(){
			return smartControlActive;
		}
	
		public void setSmartControlActive(boolean value){
			this.smartControlActive=value;
		}
	



	}
	
	public Room getRoomInstance(){
		Room room=new Room();
		return room;
	}	
	
	public cclass Floor {
		public boolean smartControlActive;

		public Floor (){
				
		}
		public boolean getSmartControlActive(){
			return smartControlActive;
		}
	
		public void setSmartControlActive(boolean value){
			this.smartControlActive=value;
		}
	



	}
	
	public Floor getFloorInstance(){
		Floor floor=new Floor();
		return floor;
	}	
	
	public cclass House {
		public boolean smartControlActive;

		public House (){
				
		}
		public boolean getSmartControlActive(){
			return smartControlActive;
		}
	
		public void setSmartControlActive(boolean value){
			this.smartControlActive=value;
		}
	



	}
	
	public House getHouseInstance(){
		House house=new House();
		return house;
	}	
	
	public cclass SmartPort extends TypePort implements ISmartEnergy{


		public SmartPort (){
			super();

		}


		public void activateSmartControl(String floorId,String roomId){
		
		}

		public void deactivateSmartControl(String floorId,String roomId){
		
		}

	}	
	
	public cclass SmartNotifyPort extends TypePort{

		public ArrayList portsISmartEnergyNotify;

		public SmartNotifyPort (){
			super();
			portsISmartEnergyNotify=new ArrayList();

		}


			
		public void connectPort(ISmartEnergyNotify port){
			portsISmartEnergyNotify.add(port);
		}
	}

}