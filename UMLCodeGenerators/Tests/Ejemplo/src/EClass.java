public class EClass {
	// Attributes of the class EClass
  		public Class base_Class;    		
  		public Interface base_Interface;    		
  		public EString className;    		
  		public ContentKind xmlContentKind;    		
  		public DataType base_DataType;    		
  		public Association base_Association;    		
  		public EString instanceClassName;    		
  		public EString xmlName;    		
  		public EString annotations;    		
    // Getters for each attribute of the class EClass
    	public Class getbase_Class () {
    		return base_Class;
  		}
    	public Interface getbase_Interface () {
    		return base_Interface;
  		}
    	public EString getclassName () {
    		return className;
  		}
    	public ContentKind getxmlContentKind () {
    		return xmlContentKind;
  		}
    	public DataType getbase_DataType () {
    		return base_DataType;
  		}
    	public Association getbase_Association () {
    		return base_Association;
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
    // Setters for each attribute of the class EClass
    	public void setbase_Class (Class base_Class) {
   	 		this.base_Class = base_Class;
  		}  
    	public void setbase_Interface (Interface base_Interface) {
   	 		this.base_Interface = base_Interface;
  		}  
    	public void setclassName (EString className) {
   	 		this.className = className;
  		}  
    	public void setxmlContentKind (ContentKind xmlContentKind) {
   	 		this.xmlContentKind = xmlContentKind;
  		}  
    	public void setbase_DataType (DataType base_DataType) {
   	 		this.base_DataType = base_DataType;
  		}  
    	public void setbase_Association (Association base_Association) {
   	 		this.base_Association = base_Association;
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