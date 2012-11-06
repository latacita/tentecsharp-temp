public class EOperation {
	// Attributes of the class EOperation
  		public Operation base_Operation;    		
  		public EString operationName;    		
  		public EString annotations;    		
  		public VisibilityKind visibility;    		
    // Getters for each attribute of the class EOperation
    	public Operation getbase_Operation () {
    		return base_Operation;
  		}
    	public EString getoperationName () {
    		return operationName;
  		}
    	public EString getannotations () {
    		return annotations;
  		}
    	public VisibilityKind getvisibility () {
    		return visibility;
  		}
    // Setters for each attribute of the class EOperation
    	public void setbase_Operation (Operation base_Operation) {
   	 		this.base_Operation = base_Operation;
  		}  
    	public void setoperationName (EString operationName) {
   	 		this.operationName = operationName;
  		}  
    	public void setannotations (EString annotations) {
   	 		this.annotations = annotations;
  		}  
    	public void setvisibility (VisibilityKind visibility) {
   	 		this.visibility = visibility;
  		}  
}