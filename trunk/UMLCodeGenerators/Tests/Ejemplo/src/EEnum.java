public class EEnum {
	// Attributes of the class EEnum
  		public Enumeration base_Enumeration;    		
  		public EString enumName;    		
  		public EString xmlName;    		
  		public EString annotations;    		
    // Getters for each attribute of the class EEnum
    	public Enumeration getbase_Enumeration () {
    		return base_Enumeration;
  		}
    	public EString getenumName () {
    		return enumName;
  		}
    	public EString getxmlName () {
    		return xmlName;
  		}
    	public EString getannotations () {
    		return annotations;
  		}
    // Setters for each attribute of the class EEnum
    	public void setbase_Enumeration (Enumeration base_Enumeration) {
   	 		this.base_Enumeration = base_Enumeration;
  		}  
    	public void setenumName (EString enumName) {
   	 		this.enumName = enumName;
  		}  
    	public void setxmlName (EString xmlName) {
   	 		this.xmlName = xmlName;
  		}  
    	public void setannotations (EString annotations) {
   	 		this.annotations = annotations;
  		}  
}