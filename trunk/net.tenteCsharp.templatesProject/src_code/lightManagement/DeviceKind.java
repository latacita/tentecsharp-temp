cclass lightManagement.LightManagement;

public cclass DeviceKind extends TypeEnum {
	
	public DeviceKind (){
		super();		
		values.add("LightSwitch");		
		values.add("LightDimmer");		
		values.add("LightController");
	}
	
}