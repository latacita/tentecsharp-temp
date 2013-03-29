using System;
using System.Collections.Generic;
// This is the content of the class named "CLASEB", which is 
// in the package: "PruebasBidireccionalidad", from the "Data" model. 
namespace Data{	
	 	public partial class CLASEB{

		// Properties from the current class 
 
		private CLASEA relationFromClass_CLASEB;
		public CLASEA RelationFromClass_CLASEB {
			get { return this.relationFromClass_CLASEB; }
			set { 

				if (RelationFromClass_CLASEB != null)
				{
					if (value.RelationFromClass_CLASEA != null)
					{
						if (this != value.RelationFromClass_CLASEA)
						{
							value.RelationFromClass_CLASEA.SetRelationFromClass_CLASEB_aditional(null);
							value.SetRelationFromClass_CLASEA_aditional(null);
							this.RelationFromClass_CLASEB.SetRelationFromClass_CLASEA_adicional(null);
							this.SetRelationFromClass_CLASEB_aditional(null);
						
							this.SetRelationFromClass_CLASEB_aditional(value);
							value.SetRelationFromClass_CLASEA_aditional(this);
						}
					}
					else
					{
						this.RelationFromClass_CLASEB.SetRelationFromClass_CLASEA_aditional(null);
						this.SetRelationFromClass_CLASEB_aditional(null);
						this.SetRelationFromClass_CLASEB_aditional(value);
						value.SetRelationFromClass_CLASEA_aditional(this);
					}
				}
				else
				{
					if (value.RelationFromClass_CLASEA != null)
					{
						value.RelationFromClass_CLASEA.SetRelationFromClass_CLASEB_aditional(null);
						value.SetRelationFromClass_CLASEA_aditional(null);
						this.SetRelationFromClass_CLASEB_aditional(value);
						value.SetRelationFromClass_CLASEA_aditional(this);
					}
					else
					{
						this.SetRelationFromClass_CLASEB_aditional(value);
						value.SetRelationFromClass_CLASEA_aditional(this);
					}
				}
			 }
		}
		
		// Aditional set method to control bidirectional relationship

		public void SetRelationFromClass_CLASEB_aditional(CLASEA m)
		{
			 this.relationFromClass_CLASEB=m;
		}
		
		// Utility methods from the current class 
		
		public virtual override bool Equals (Object o);
		public virtual override int CompareTo (Object o);
		public virtual override int GetHashCode ();
		public virtual override Type GetType ();
		public virtual override string ToString();

		// Constructor and methods from the from the current class		
	        	
		private void PruebasBidireccionalidad_initCLASEB () {}
			
	

	
	
	}
} 
  




