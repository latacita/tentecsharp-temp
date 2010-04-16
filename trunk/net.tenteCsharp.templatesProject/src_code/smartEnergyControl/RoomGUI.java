

cclass smartEnergyControl.SmartEnergyControl; 

public cclass RoomGUI extends TypeComponent{ 

	public SmartPort smartEnergyPort;
		public SmartNotifyPort smartEnergyNotifyPort;
	
	
	public RoomGUI (String id){
		super(id);
	}
	
	public SmartPort getSmartEnergyPort(){
		return smartEnergyPort;
	}
	
	public void setSmartEnergyPort(RoomGUI.SmartPort value){
		this.smartEnergyPort=value;
	}
	
	public SmartNotifyPort getSmartEnergyNotifyPort(){
		return smartEnergyNotifyPort;
	}
	
	public void setSmartEnergyNotifyPort(RoomGUI.SmartNotifyPort value){
		this.smartEnergyNotifyPort=value;
	}
	

	
	
	public cclass SmartPort extends TypePort{

		public ArrayList portsISmartEnergy;

		public SmartPort (){
			super();
			portsISmartEnergy=new ArrayList();

		}


			
		public void connectPort(ISmartEnergy port){
			portsISmartEnergy.add(port);
		}
	}	
	
	public cclass SmartNotifyPort extends TypePort implements ISmartEnergyNotify{


		public SmartNotifyPort (){
			super();

		}


		public void activateSmartControl(String floorId,String roomId){
		
		}

		public void deactivateSmartControl(String floorId,String roomId){
		
		}

	}

}