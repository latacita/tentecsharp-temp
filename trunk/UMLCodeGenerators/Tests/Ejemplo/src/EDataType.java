public class EDataType {
	// Attributes of the class EDataType
  		public PrimitiveType base_PrimitiveType;    		
  		public EString dataTypeName;    		
  		public EString instanceClassName;    		
  		public EString xmlName;    		
  		public EString annotations;    		
    // Getters for each attribute of the class EDataType
    	public PrimitiveType getbase_PrimitiveType () {
    		return base_PrimitiveType;
  		}
    	public EString getdataTypeName () {
    		return dataTypeName;
  		}
    	public EString getinstanceClassName () {
    		return instanceClassName;
  		}
    	public EString getxmlName () {
    		return xmlName;
  		}
    	public EString getannotations () {
    		return annotations;
  		}
    // Setters for each attribute of the class EDataType
    	public void setbase_PrimitiveType (PrimitiveType base_PrimitiveType) {
   	 		this.base_PrimitiveType = base_PrimitiveType;
  		}  
    	public void setdataTypeName (EString dataTypeName) {
   	 		this.dataTypeName = dataTypeName;
  		}  
    	public void setinstanceClassName (EString instanceClassName) {
   	 		this.instanceClassName = instanceClassName;
  		}  
    	public void setxmlName (EString xmlName) {
   	 		this.xmlName = xmlName;
  		}  
    	public void setannotations (EString annotations) {
   	 		this.annotations = annotations;
  		}  
}