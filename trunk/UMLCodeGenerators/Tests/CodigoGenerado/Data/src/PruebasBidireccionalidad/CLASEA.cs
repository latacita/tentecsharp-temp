using System;
using System.Collections.Generic;
// This is the content of the class named "CLASEA", which is 
// in the package: "PruebasBidireccionalidad", from the "Data" model. 
namespace Data{	
	 	public partial class CLASEA{

		// Properties from the current class 
 
		private CLASEB relationFromClass_CLASEA;
		public CLASEB RelationFromClass_CLASEA {
			get { return this.relationFromClass_CLASEA; }
			set { 

				if (RelationFromClass_CLASEA != null)
				{
					if (value.RelationFromClass_CLASEB != null)
					{
						if (this != value.RelationFromClass_CLASEB)
						{
							value.RelationFromClass_CLASEB.SetRelationFromClass_CLASEA_aditional(null);
							value.SetRelationFromClass_CLASEB_aditional(null);
							this.RelationFromClass_CLASEA.SetRelationFromClass_CLASEB_adicional(null);
							this.SetRelationFromClass_CLASEA_aditional(null);
						
							this.SetRelationFromClass_CLASEA_aditional(value);
							value.SetRelationFromClass_CLASEB_aditional(this);
						}
					}
					else
					{
						this.RelationFromClass_CLASEA.SetRelationFromClass_CLASEB_aditional(null);
						this.SetRelationFromClass_CLASEA_aditional(null);
						this.SetRelationFromClass_CLASEA_aditional(value);
						value.SetRelationFromClass_CLASEB_aditional(this);
					}
				}
				else
				{
					if (value.RelationFromClass_CLASEB != null)
					{
						value.RelationFromClass_CLASEB.SetRelationFromClass_CLASEA_aditional(null);
						value.SetRelationFromClass_CLASEB_aditional(null);
						this.SetRelationFromClass_CLASEA_aditional(value);
						value.SetRelationFromClass_CLASEB_aditional(this);
					}
					else
					{
						this.SetRelationFromClass_CLASEA_aditional(value);
						value.SetRelationFromClass_CLASEB_aditional(this);
					}
				}
			 }
		}
		
		// Aditional set method to control bidirectional relationship

		public void SetRelationFromClass_CLASEA_aditional(CLASEB m)
		{
			 this.relationFromClass_CLASEA=m;
		}
		
		// Utility methods from the current class 
		
		public virtual override bool Equals (Object o);
		public virtual override int CompareTo (Object o);
		public virtual override int GetHashCode ();
		public virtual override Type GetType ();
		public virtual override string ToString();

		// Constructor and methods from the from the current class		
	        	
		private void PruebasBidireccionalidad_initCLASEA () {}
			
	

	
	
	}
} 
  




