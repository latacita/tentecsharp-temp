using System;
using System.Collections.Generic; 

// This is the content of the interface named "C", which is 
// in the package: "PruebasInterfaces",  from the "Data" model. 
namespace Data{	
	partial interface Interface_C{ 
		// Properties from the current interface 		 
		private Interface_B relationFromClass_C;
		public Interface_B RelationFromClass_C {
			get { return this.relationFromClass_C; }
			set { 

				if (RelationFromClass_C != null)
				{
					if (value.RelationFromClass_B != null)
					{
						if (this != value.RelationFromClass_B)
						{
							value.RelationFromClass_B.SetRelationFromClass_C_aditional(null);
							value.SetRelationFromClass_B_aditional(null);
							this.RelationFromClass_C.SetRelationFromClass_B_aditional(null);
							this.SetRelationFromClass_C_aditional(null);
						
							this.SetRelationFromClass_C_aditional(value);
							value.SetRelationFromClass_B_aditional(this);
						}
					}
					else
					{
						this.RelationFromClass_C.SetRelationFromClass_B_aditional(null);
						this.SetRelationFromClass_C_aditional(null);
						this.SetRelationFromClass_C_aditional(value);
						value.SetRelationFromClass_B_aditional(this);
					}
				}
				else
				{
					if (value.RelationFromClass_B != null)
					{
						value.RelationFromClass_B.SetRelationFromClass_C_aditional(null);
						value.SetRelationFromClass_B_aditional(null);
						this.SetRelationFromClass_C_aditional(value);
						value.SetRelationFromClass_B_aditional(this);
					}
					else
					{
						this.SetRelationFromClass_C_aditional(value);
						value.SetRelationFromClass_B_aditional(this);
					}
				}
			 }
		}
				
		
		// Aditional set method to control bidirectional relationship

		public void SetRelationFromClass_C_aditional(Interface_B m)
		{
			 this.relationFromClass_C=m;
		}
		 
		
		// Utility methods from the current class 		
		public  virtual  override bool Equals (Object o);
		public  virtual  override int CompareTo (Object o);
		public  virtual  override int GetHashCode ( );
		public  virtual  override Type GetType ( );
		public  virtual  override string ToString( );
 		
		// Constructor and methods from the from the current class			
		private void PruebasInterfaces_initC ( ) {}
		 
	}
} 
  