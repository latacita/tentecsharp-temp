cclass windowManagement.WindowManagement;

public cclass DeviceKind extends TypeEnum {
	
	public DeviceKind (){
		super();		
		values.add("WindowController");		
		values.add("WindowDimmer");		
		values.add("BlindDimmer");		
		values.add("BlindController");
	}
	
}