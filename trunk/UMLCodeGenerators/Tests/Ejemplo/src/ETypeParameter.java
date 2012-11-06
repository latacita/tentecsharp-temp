public class ETypeParameter {
	// Attributes of the class ETypeParameter
  		public TemplateParameter base_TemplateParameter;    		
  		public Classifier bounds;    		
  		public EString xmlName;    		
  		public EString annotations;    		
    // Getters for each attribute of the class ETypeParameter
    	public TemplateParameter getbase_TemplateParameter () {
    		return base_TemplateParameter;
  		}
    	public Classifier getbounds () {
    		return bounds;
  		}
    	public EString getxmlName () {
    		return xmlName;
  		}
    	public EString getannotations () {
    		return annotations;
  		}
    // Setters for each attribute of the class ETypeParameter
    	public void setbase_TemplateParameter (TemplateParameter base_TemplateParameter) {
   	 		this.base_TemplateParameter = base_TemplateParameter;
  		}  
    	public void setbounds (Classifier bounds) {
   	 		this.bounds = bounds;
  		}  
    	public void setxmlName (EString xmlName) {
   	 		this.xmlName = xmlName;
  		}  
    	public void setannotations (EString annotations) {
   	 		this.annotations = annotations;
  		}  
}