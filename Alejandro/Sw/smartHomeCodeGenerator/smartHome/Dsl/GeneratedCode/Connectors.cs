﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DslModeling = global::Microsoft.VisualStudio.Modeling;
using DslDesign = global::Microsoft.VisualStudio.Modeling.Design;
using DslDiagrams = global::Microsoft.VisualStudio.Modeling.Diagrams;

namespace Unican.smartHome
{
	/// <summary>
	/// DomainClass Connector
	/// Description for Unican.smartHome.Connector
	/// </summary>
	[DslDesign::DisplayNameResource("Unican.smartHome.Connector.DisplayName", typeof(global::Unican.smartHome.smartHomeDomainModel), "Unican.smartHome.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("Unican.smartHome.Connector.Description", typeof(global::Unican.smartHome.smartHomeDomainModel), "Unican.smartHome.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::Unican.smartHome.smartHomeDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainObjectId("cbc312de-6a27-4482-9074-5955db8171c4")]
	public partial class Connector : DslDiagrams::BinaryLinkShape
	{
		#region DiagramElement boilerplate
		private static DslDiagrams::StyleSet classStyleSet;
		private static global::System.Collections.Generic.IList<DslDiagrams::ShapeField> shapeFields;
		private static global::System.Collections.Generic.IList<DslDiagrams::Decorator> decorators;
		
		/// <summary>
		/// Per-class style set for this shape.
		/// </summary>
		protected override DslDiagrams::StyleSet ClassStyleSet
		{
			get
			{
				if (classStyleSet == null)
				{
					classStyleSet = CreateClassStyleSet();
				}
				return classStyleSet;
			}
		}
		
		/// <summary>
		/// Per-class ShapeFields for this shape.
		/// </summary>
		public override global::System.Collections.Generic.IList<DslDiagrams::ShapeField> ShapeFields
		{
			get
			{
				if (shapeFields == null)
				{
					shapeFields = CreateShapeFields();
				}
				return shapeFields;
			}
		}
		
		/// <summary>
		/// Event fired when decorator initialization is complete for this shape type.
		/// </summary>
		public static event global::System.EventHandler DecoratorsInitialized;
		
		/// <summary>
		/// List containing decorators used by this type.
		/// </summary>
		public override global::System.Collections.Generic.IList<DslDiagrams::Decorator> Decorators
		{
			get 
			{
				if(decorators == null)
				{
					decorators = CreateDecorators();
					
					// fire this event to allow the diagram to initialize decorator mappings for this shape type.
					if(DecoratorsInitialized != null)
					{
						DecoratorsInitialized(this, global::System.EventArgs.Empty);
					}
				}
				
				return decorators; 
			}
		}
		
		/// <summary>
		/// Finds a decorator associated with Connector.
		/// </summary>
		public static DslDiagrams::Decorator FindConnectorDecorator(string decoratorName)
		{	
			if(decorators == null) return null;
			return DslDiagrams::ShapeElement.FindDecorator(decorators, decoratorName);
		}
		
		#endregion
		
		#region Connector styles
		/// <summary>
		/// Initializes style set resources for this shape type
		/// </summary>
		/// <param name="classStyleSet">The style set for this shape class</param>
		protected override void InitializeResources(DslDiagrams::StyleSet classStyleSet)
		{
			base.InitializeResources(classStyleSet);
			
			// Line pen settings for this connector.
			DslDiagrams::PenSettings linePen = new DslDiagrams::PenSettings();
			linePen.Width = 0.015f;
			classStyleSet.OverridePen(DslDiagrams::DiagramPens.ConnectionLine, linePen);
		}
		
		/// <summary>
		/// Initializes resources associated with this connector instance.
		/// </summary>
		protected override void InitializeInstanceResources()
		{
			base.InitializeInstanceResources();
			this.SetDecorators(DslDiagrams::LinkDecorator.DecoratorFilledDiamond, new DslDiagrams::SizeD(0.1,0.1), null, new DslDiagrams::SizeD(0.1,0.1), false);
		}
		
		/// <summary>
		/// Gets the default line routing style for this connector.
		/// </summary>
		[global::System.CLSCompliant(false)]
		protected override DslDiagrams::GraphObject.VGRoutingStyle DefaultRoutingStyle
		{
			get
			{
				return DslDiagrams::GraphObject.VGRoutingStyle.VGRouteStraight;
			}
		}
		#endregion
		
		#region Constructors, domain class Id
	
		/// <summary>
		/// Connector domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0xcbc312de, 0x6a27, 0x4482, 0x90, 0x74, 0x59, 0x55, 0xdb, 0x81, 0x71, 0xc4);
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public Connector(DslModeling::Store store, params DslModeling::PropertyAssignment[] propertyAssignments)
			: this(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public Connector(DslModeling::Partition partition, params DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
	}
}