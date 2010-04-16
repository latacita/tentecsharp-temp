

cclass smartEnergyControl.SmartEnergyControl; 

public cclass CentralGUI extends TypeComponent{ 

	public SmartPort smartEnergyPort;
		public SmartNotifyPort smartEnergyNotifyPort;
	
	
	public CentralGUI (String id){
		super(id);
	}
	
	public SmartPort getSmartEnergyPort(){
		return smartEnergyPort;
	}
	
	public void setSmartEnergyPort(CentralGUI.SmartPort value){
		this.smartEnergyPort=value;
	}
	
	public SmartNotifyPort getSmartEnergyNotifyPort(){
		return smartEnergyNotifyPort;
	}
	
	public void setSmartEnergyNotifyPort(CentralGUI.SmartNotifyPort value){
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