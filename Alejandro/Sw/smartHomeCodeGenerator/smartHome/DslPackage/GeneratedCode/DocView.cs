﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DslModeling = global::Microsoft.VisualStudio.Modeling;
using DslDiagrams = global::Microsoft.VisualStudio.Modeling.Diagrams;
using DslShell = global::Microsoft.VisualStudio.Modeling.Shell;

namespace Unican.smartHome
{
	/// <summary>
	/// Double-derived class to allow easier code customization.
	/// </summary>
	internal partial class smartHomeDocView : smartHomeDocViewBase
	{
		/// <summary>
		/// Constructs a new smartHomeDocView.
		/// </summary>
		public smartHomeDocView(DslShell::ModelingDocData docData, global::System.IServiceProvider serviceProvider)
			: base(docData, serviceProvider)
		{
		}
	}

	/// <summary>
	/// Class that hosts the diagram surface in the Visual Studio document area.
	/// </summary>
	internal abstract class smartHomeDocViewBase : DslShell::SingleDiagramDocView
	{
		/// <summary>
		/// Constructs a new smartHomeDocView.
		/// </summary>
		protected smartHomeDocViewBase(DslShell::ModelingDocData docData, global::System.IServiceProvider serviceProvider) : base(docData, serviceProvider)
		{
		}

		/// <summary>
		/// Called to initialize the view after the corresponding document has been loaded.
		/// </summary>
		protected override bool LoadView()
		{
			base.LoadView();

			global::System.Diagnostics.Debug.Assert(this.DocData.RootElement!=null);
			if (this.DocData.RootElement == null)
			{
				return false;
			}

			// The diagram should exist in the diagram partition by now, just need to find it and connect it to this view.
			smartHomeDocDataBase docData = this.DocData as smartHomeDocDataBase;
			global::System.Diagnostics.Debug.Assert(docData != null, "DocData for smartHomeDocViewBase should be an smartHomeDocDataBase!");
			DslModeling::Partition diagramPartition = docData.GetDiagramPartition();
			if (diagramPartition != null)
			{
				global::System.Collections.ObjectModel.ReadOnlyCollection<global::Unican.smartHome.smartHomeDiagram> diagrams = docData.GetDiagramPartition().ElementDirectory.FindElements<global::Unican.smartHome.smartHomeDiagram>();
				if (diagrams.Count > 0)
				{
					global::System.Diagnostics.Debug.Assert(diagrams.Count == 1, "Found more than one diagram, using the first one found.");
					this.Diagram = (DslDiagrams::Diagram)diagrams[0];
				}
				else
				{
					return false;
				}
			}
			else
			{
				return false;
			}

			return true;
		}

		/// <summary>
		/// Name of the toolbox tab that should be displayed when the diagram is opened.
		/// </summary>
		protected override string DefaultToolboxTabName
		{
			get
			{
				return global::Unican.smartHome.smartHomeToolboxHelper.DefaultToolboxTabName;
			}
		}
		
		/// <summary>
		/// Returns the toolbox items count in the default tool box tab.
		/// </summary>
		protected override int DefaultToolboxTabToolboxItemsCount
		{
			get
			{
				return global::Unican.smartHome.smartHomeToolboxHelper.DefaultToolboxTabToolboxItemsCount;			
			}
		}
		
		
		/// <summary>
		/// Context menu displayed when the user right-clicks on the design surface.
		/// </summary>
		protected override global::System.ComponentModel.Design.CommandID ContextMenuId
		{
			get
			{
				return Constants.smartHomeDiagramMenu;
			}
		}
			
		/// <summary>
		/// Called when selection changes in this window.
		/// </summary>
		/// <remarks>
		/// Overriden to update the F1 help keyword for the selection.
		/// </remarks>
		/// <param name="e"></param>
		protected override void OnSelectionChanged(global::System.EventArgs e)
		{
			base.OnSelectionChanged(e);

			if(global::Unican.smartHome.smartHomeHelpKeywordHelper.Instance != null)
			{
				DslModeling::ModelElement selectedElement = this.PrimarySelection as DslModeling::ModelElement;
				if(selectedElement != null)
				{
					string f1Keyword = global::Unican.smartHome.smartHomeHelpKeywordHelper.Instance.GetHelpKeyword(selectedElement);

					// If this is a presentation element, check the underlying model element for a help keyword
					DslDiagrams::PresentationElement presentationElement = this.PrimarySelection as DslDiagrams::PresentationElement;
					if(presentationElement != null)
					{
						selectedElement = presentationElement.ModelElement;
						if(selectedElement != null)
						{
							string modelElementKeyword = global::Unican.smartHome.smartHomeHelpKeywordHelper.Instance.GetHelpKeyword(selectedElement);
							if(string.IsNullOrEmpty(f1Keyword))
							{
								// Presentation element does not have an F1 keyword, so push the keyword from the model element as an F1 keyword.
								f1Keyword = modelElementKeyword;
							}
							else if (!string.IsNullOrEmpty(modelElementKeyword) && this.SelectionHelpService != null)
							{
								// Presentation element has an F1 keyword, so push model element keyword as a general dynamic help keyword (non-F1).
								this.SelectionHelpService.AddContextAttribute(string.Empty, modelElementKeyword, global::System.ComponentModel.Design.HelpKeywordType.GeneralKeyword);
							}
						}
					}
					
					if(!string.IsNullOrEmpty(f1Keyword) && this.SelectionHelpService != null)
					{
						this.SelectionHelpService.AddContextAttribute(string.Empty, f1Keyword, global::System.ComponentModel.Design.HelpKeywordType.F1Keyword);
					}
				}
			}
		}
	}
}

