public class EStructuralFeature {
	// Attributes of the class EStructuralFeature
  		public EBoolean isTransient;    		
  		public EBoolean isVolatile;    		
  		public EBoolean isUnsettable;    		
  		public EString xmlNamespace;    		
  		public FeatureKind xmlFeatureKind;    		
  		public VisibilityKind visibility;    		
  		public EString xmlName;    		
  		public EString annotations;    		
    // Getters for each attribute of the class EStructuralFeature
    	public EBoolean getisTransient () {
    		return isTransient;
  		}
    	public EBoolean getisVolatile () {
    		return isVolatile;
  		}
    	public EBoolean getisUnsettable () {
    		return isUnsettable;
  		}
    	public EString getxmlNamespace () {
    		return xmlNamespace;
  		}
    	public FeatureKind getxmlFeatureKind () {
    		return xmlFeatureKind;
  		}
    	public VisibilityKind getvisibility () {
    		return visibility;
  		}
    	public EString getxmlName () {
    		return xmlName;
  		}
    	public EString getannotations () {
    		return annotations;
  		}
    // Setters for each attribute of the class EStructuralFeature
    	public void setisTransient (EBoolean isTransient) {
   	 		this.isTransient = isTransient;
  		}  
    	public void setisVolatile (EBoolean isVolatile) {
   	 		this.isVolatile = isVolatile;
  		}  
    	public void setisUnsettable (EBoolean isUnsettable) {
   	 		this.isUnsettable = isUnsettable;
  		}  
    	public void setxmlNamespace (EString xmlNamespace) {
   	 		this.xmlNamespace = xmlNamespace;
  		}  
    	public void setxmlFeatureKind (FeatureKind xmlFeatureKind) {
   	 		this.xmlFeatureKind = xmlFeatureKind;
  		}  
    	public void setvisibility (VisibilityKind visibility) {
   	 		this.visibility = visibility;
  		}  
    	public void setxmlName (EString xmlName) {
   	 		this.xmlName = xmlName;
  		}  
    	public void setannotations (EString annotations) {
   	 		this.annotations = annotations;
  		}  
}