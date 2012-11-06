public class EGenericType {
	// Attributes of the class EGenericType
  		public Class base_Class;    		
  		public Interface base_Interface;    		
  		public DataType base_DataType;    		
  		public Classifier upperBound;    		
  		public Classifier lowerBound;    		
    // Getters for each attribute of the class EGenericType
    	public Class getbase_Class () {
    		return base_Class;
  		}
    	public Interface getbase_Interface () {
    		return base_Interface;
  		}
    	public DataType getbase_DataType () {
    		return base_DataType;
  		}
    	public Classifier getupperBound () {
    		return upperBound;
  		}
    	public Classifier getlowerBound () {
    		return lowerBound;
  		}
    // Setters for each attribute of the class EGenericType
    	public void setbase_Class (Class base_Class) {
   	 		this.base_Class = base_Class;
  		}  
    	public void setbase_Interface (Interface base_Interface) {
   	 		this.base_Interface = base_Interface;
  		}  
    	public void setbase_DataType (DataType base_DataType) {
   	 		this.base_DataType = base_DataType;
  		}  
    	public void setupperBound (Classifier upperBound) {
   	 		this.upperBound = upperBound;
  		}  
    	public void setlowerBound (Classifier lowerBound) {
   	 		this.lowerBound = lowerBound;
  		}  
}