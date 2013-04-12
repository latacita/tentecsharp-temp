using System;
using System.Collections.Generic;
// This is the content of the class named "RecursivePerson", which is 
// in the package: "PruebasBidireccionalidad", from the "Data" model. 
namespace Data{	
	 	partial class RecursivePerson{
 
		// Properties from the current class 		 
		
		private RecursivePerson isParentOf;
		public RecursivePerson IsParentOf {
			get { return this.isParentOf; }
			set { 

				if (IsParentOf != null)
				{
					if (value.RelationFromClass_RecursivePerson != null)
					{
						if (this != value.RelationFromClass_RecursivePerson)
						{
							value.RelationFromClass_RecursivePerson.SetIsParentOf_aditional(null);
							value.SetRelationFromClass_RecursivePerson_aditional(null);
							this.IsParentOf.SetRelationFromClass_RecursivePerson_aditional(null);
							this.SetIsParentOf_aditional(null);
						
							this.SetIsParentOf_aditional(value);
							value.SetRelationFromClass_RecursivePerson_aditional(this);
						}
					}
					else
					{
						this.IsParentOf.SetRelationFromClass_RecursivePerson_aditional(null);
						this.SetIsParentOf_aditional(null);
						this.SetIsParentOf_aditional(value);
						value.SetRelationFromClass_RecursivePerson_aditional(this);
					}
				}
				else
				{
					if (value.RelationFromClass_RecursivePerson != null)
					{
						value.RelationFromClass_RecursivePerson.SetIsParentOf_aditional(null);
						value.SetRelationFromClass_RecursivePerson_aditional(null);
						this.SetIsParentOf_aditional(value);
						value.SetRelationFromClass_RecursivePerson_aditional(this);
					}
					else
					{
						this.SetIsParentOf_aditional(value);
						value.SetRelationFromClass_RecursivePerson_aditional(this);
					}
				}
			 }
		}
		private RecursivePerson isParentOf;
		public RecursivePerson IsParentOf {
			get { return this.isParentOf; }
			set { 

				if (IsParentOf != null)
				{
					if (value.RelationFromClass_RecursivePerson != null)
					{
						if (this != value.RelationFromClass_RecursivePerson)
						{
							value.RelationFromClass_RecursivePerson.SetIsParentOf_aditional(null);
							value.SetRelationFromClass_RecursivePerson_aditional(null);
							this.IsParentOf.SetRelationFromClass_RecursivePerson_aditional(null);
							this.SetIsParentOf_aditional(null);
						
							this.SetIsParentOf_aditional(value);
							value.SetRelationFromClass_RecursivePerson_aditional(this);
						}
					}
					else
					{
						this.IsParentOf.SetRelationFromClass_RecursivePerson_aditional(null);
						this.SetIsParentOf_aditional(null);
						this.SetIsParentOf_aditional(value);
						value.SetRelationFromClass_RecursivePerson_aditional(this);
					}
				}
				else
				{
					if (value.RelationFromClass_RecursivePerson != null)
					{
						value.RelationFromClass_RecursivePerson.SetIsParentOf_aditional(null);
						value.SetRelationFromClass_RecursivePerson_aditional(null);
						this.SetIsParentOf_aditional(value);
						value.SetRelationFromClass_RecursivePerson_aditional(this);
					}
					else
					{
						this.SetIsParentOf_aditional(value);
						value.SetRelationFromClass_RecursivePerson_aditional(this);
					}
				}
			 }
		}
		private RecursivePerson relationFromClass_RecursivePerson;
		public RecursivePerson RelationFromClass_RecursivePerson {
			get { return this.relationFromClass_RecursivePerson; }
			set { 

				if (RelationFromClass_RecursivePerson != null)
				{
					if (value.IsParentOf != null)
					{
						if (this != value.IsParentOf)
						{
							value.IsParentOf.SetRelationFromClass_RecursivePerson_aditional(null);
							value.SetIsParentOf_aditional(null);
							this.RelationFromClass_RecursivePerson.SetIsParentOf_aditional(null);
							this.SetRelationFromClass_RecursivePerson_aditional(null);
						
							this.SetRelationFromClass_RecursivePerson_aditional(value);
							value.SetIsParentOf_aditional(this);
						}
					}
					else
					{
						this.RelationFromClass_RecursivePerson.SetIsParentOf_aditional(null);
						this.SetRelationFromClass_RecursivePerson_aditional(null);
						this.SetRelationFromClass_RecursivePerson_aditional(value);
						value.SetIsParentOf_aditional(this);
					}
				}
				else
				{
					if (value.IsParentOf != null)
					{
						value.IsParentOf.SetRelationFromClass_RecursivePerson_aditional(null);
						value.SetIsParentOf_aditional(null);
						this.SetRelationFromClass_RecursivePerson_aditional(value);
						value.SetIsParentOf_aditional(this);
					}
					else
					{
						this.SetRelationFromClass_RecursivePerson_aditional(value);
						value.SetIsParentOf_aditional(this);
					}
				}
			 }
		}
		 
		
		// Aditional set method to control bidirectional relationship

		public void SetIsParentOf_aditional(RecursivePerson m)
		{
			 this.isParentOf=m;
		}
		
		// Aditional set method to control bidirectional relationship

		public void SetIsParentOf_aditional(RecursivePerson m)
		{
			 this.isParentOf=m;
		}
		
		// Aditional set method to control bidirectional relationship

		public void SetRelationFromClass_RecursivePerson_aditional(RecursivePerson m)
		{
			 this.relationFromClass_RecursivePerson=m;
		}
		 
		
		// Utility methods from the current class 
		
		public  virtual  override bool Equals (Object o);
		public  virtual  override int CompareTo (Object o);
		public  virtual  override int GetHashCode ( );
		public  virtual  override Type GetType ( );
		public  virtual  override string ToString( );

		
		// Constructor and methods from the from the current class		
		private void PruebasBidireccionalidad_initRecursivePerson ( ) {}
			
	
	
	}
} 
  




