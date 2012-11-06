public class EParameter {
	// Attributes of the class EParameter
  		public Parameter base_Parameter;    		
  		public EString parameterName;    		
  		public EString annotations;    		
    // Getters for each attribute of the class EParameter
    	public Parameter getbase_Parameter () {
    		return base_Parameter;
  		}
    	public EString getparameterName () {
    		return parameterName;
  		}
    	public EString getannotations () {
    		return annotations;
  		}
    // Setters for each attribute of the class EParameter
    	public void setbase_Parameter (Parameter base_Parameter) {
   	 		this.base_Parameter = base_Parameter;
  		}  
    	public void setparameterName (EString parameterName) {
   	 		this.parameterName = parameterName;
  		}  
    	public void setannotations (EString annotations) {
   	 		this.annotations = annotations;
  		}  
}