using System;
using System.Collections.Generic; 

// This is the content of the interface named "B", which is 
// in the package: "PruebasInterfaces",  from the "Data" model. 
namespace Data{	
	partial interface Interface_B{ 
		// Properties from the current class 		 
		private Interface_C relationFromClass_B;
		public Interface_C RelationFromClass_B {
			get { return this.relationFromClass_B; }
			set { 

				if (RelationFromClass_B != null)
				{
					if (value.RelationFromClass_C != null)
					{
						if (this != value.RelationFromClass_C)
						{
							value.RelationFromClass_C.SetRelationFromClass_B_aditional(null);
							value.SetRelationFromClass_C_aditional(null);
							this.RelationFromClass_B.SetRelationFromClass_C_aditional(null);
							this.SetRelationFromClass_B_aditional(null);
						
							this.SetRelationFromClass_B_aditional(value);
							value.SetRelationFromClass_C_aditional(this);
						}
					}
					else
					{
						this.RelationFromClass_B.SetRelationFromClass_C_aditional(null);
						this.SetRelationFromClass_B_aditional(null);
						this.SetRelationFromClass_B_aditional(value);
						value.SetRelationFromClass_C_aditional(this);
					}
				}
				else
				{
					if (value.RelationFromClass_C != null)
					{
						value.RelationFromClass_C.SetRelationFromClass_B_aditional(null);
						value.SetRelationFromClass_C_aditional(null);
						this.SetRelationFromClass_B_aditional(value);
						value.SetRelationFromClass_C_aditional(this);
					}
					else
					{
						this.SetRelationFromClass_B_aditional(value);
						value.SetRelationFromClass_C_aditional(this);
					}
				}
			 }
		}
				
		
		// Aditional set method to control bidirectional relationship

		public void SetRelationFromClass_B_aditional(Interface_C m)
		{
			 this.relationFromClass_B=m;
		}
		 
	}
} 
  