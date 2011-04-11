﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using VSShellInterop = global::Microsoft.VisualStudio.Shell.Interop;
using VSShell = global::Microsoft.VisualStudio.Shell;
using DslShell = global::Microsoft.VisualStudio.Modeling.Shell;
using DslDesign = global::Microsoft.VisualStudio.Modeling.Design;
using DslModeling = global::Microsoft.VisualStudio.Modeling;
using VSTextTemplatingHost = global::Microsoft.VisualStudio.TextTemplating.VSHost;
using System;
using System.Diagnostics;
using System.Drawing.Design;
using System.Linq;
using System.Windows.Forms;
	
namespace Unican.smartHome
{
	/// <summary>
	/// This class implements the VS package that integrates this DSL into Visual Studio.
	/// </summary>
	[VSShell::DefaultRegistryRoot("Software\\Microsoft\\VisualStudio\\10.0")]
	[VSShell::PackageRegistration(RegisterUsing = VSShell::RegistrationMethod.Assembly, UseManagedResourcesOnly = true)]
	[VSShell::ProvideToolWindow(typeof(smartHomeExplorerToolWindow), MultiInstances = false, Style = VSShell::VsDockStyle.Tabbed, Orientation = VSShell::ToolWindowOrientation.Right, Window = "{3AE79031-E1BC-11D0-8F78-00A0C9110057}")]
	[VSShell::ProvideToolWindowVisibility(typeof(smartHomeExplorerToolWindow), Constants.smartHomeEditorFactoryId)]
	[VSShell::ProvideStaticToolboxGroup("@smartHomeToolboxTab;Unican.smartHome.Dsl.dll", "Unican.smartHome.smartHomeToolboxTab")]
	[VSShell::ProvideStaticToolboxItem("Unican.smartHome.smartHomeToolboxTab",
					"@FloorToolboxItem;Unican.smartHome.Dsl.dll", 
					"Unican.smartHome.FloorToolboxItem", 
					"CF_TOOLBOXITEMCONTAINER,CF_TOOLBOXITEMCONTAINER_HASH,CF_TOOLBOXITEMCONTAINER_CONTENTS", 
					"CreateExampleClassF1Keyword", 
					"@FloorToolboxBitmap;Unican.smartHome.Dsl.dll", 
					0xff00ff)]
	[VSShell::ProvideStaticToolboxItem("Unican.smartHome.smartHomeToolboxTab",
					"@RoomToolboxItem;Unican.smartHome.Dsl.dll", 
					"Unican.smartHome.RoomToolboxItem", 
					"CF_TOOLBOXITEMCONTAINER,CF_TOOLBOXITEMCONTAINER_HASH,CF_TOOLBOXITEMCONTAINER_CONTENTS", 
					"Room", 
					"@RoomToolboxBitmap;Unican.smartHome.Dsl.dll", 
					0xff00ff)]
	[VSShell::ProvideStaticToolboxItem("Unican.smartHome.smartHomeToolboxTab",
					"@HeaterToolboxItem;Unican.smartHome.Dsl.dll", 
					"Unican.smartHome.HeaterToolboxItem", 
					"CF_TOOLBOXITEMCONTAINER,CF_TOOLBOXITEMCONTAINER_HASH,CF_TOOLBOXITEMCONTAINER_CONTENTS", 
					"Heater", 
					"@HeaterToolboxBitmap;Unican.smartHome.Dsl.dll", 
					0xff00ff)]
	[VSShell::ProvideStaticToolboxItem("Unican.smartHome.smartHomeToolboxTab",
					"@WindowToolboxItem;Unican.smartHome.Dsl.dll", 
					"Unican.smartHome.WindowToolboxItem", 
					"CF_TOOLBOXITEMCONTAINER,CF_TOOLBOXITEMCONTAINER_HASH,CF_TOOLBOXITEMCONTAINER_CONTENTS", 
					"Window", 
					"@WindowToolboxBitmap;Unican.smartHome.Dsl.dll", 
					0xff00ff)]
	[VSShell::ProvideStaticToolboxItem("Unican.smartHome.smartHomeToolboxTab",
					"@SmartEnergyToolboxItem;Unican.smartHome.Dsl.dll", 
					"Unican.smartHome.SmartEnergyToolboxItem", 
					"CF_TOOLBOXITEMCONTAINER,CF_TOOLBOXITEMCONTAINER_HASH,CF_TOOLBOXITEMCONTAINER_CONTENTS", 
					"SmartEnergy", 
					"@SmartEnergyToolboxBitmap;Unican.smartHome.Dsl.dll", 
					0xff00ff)]
	[VSShell::ProvideStaticToolboxItem("Unican.smartHome.smartHomeToolboxTab",
					"@BlindToolboxItem;Unican.smartHome.Dsl.dll", 
					"Unican.smartHome.BlindToolboxItem", 
					"CF_TOOLBOXITEMCONTAINER,CF_TOOLBOXITEMCONTAINER_HASH,CF_TOOLBOXITEMCONTAINER_CONTENTS", 
					"Blind", 
					"@BlindToolboxBitmap;Unican.smartHome.Dsl.dll", 
					0xff00ff)]
	[VSShell::ProvideStaticToolboxItem("Unican.smartHome.smartHomeToolboxTab",
					"@LightToolboxItem;Unican.smartHome.Dsl.dll", 
					"Unican.smartHome.LightToolboxItem", 
					"CF_TOOLBOXITEMCONTAINER,CF_TOOLBOXITEMCONTAINER_HASH,CF_TOOLBOXITEMCONTAINER_CONTENTS", 
					"Light", 
					"@LightToolboxBitmap;Unican.smartHome.Dsl.dll", 
					0xff00ff)]
	[VSShell::ProvideStaticToolboxItem("Unican.smartHome.smartHomeToolboxTab",
					"@LightSimulationToolboxItem;Unican.smartHome.Dsl.dll", 
					"Unican.smartHome.LightSimulationToolboxItem", 
					"CF_TOOLBOXITEMCONTAINER,CF_TOOLBOXITEMCONTAINER_HASH,CF_TOOLBOXITEMCONTAINER_CONTENTS", 
					"LightSimulation", 
					"@LightSimulationToolboxBitmap;Unican.smartHome.Dsl.dll", 
					0xff00ff)]
	[VSShell::ProvideStaticToolboxItem("Unican.smartHome.smartHomeToolboxTab",
					"@BlindSimulationToolboxItem;Unican.smartHome.Dsl.dll", 
					"Unican.smartHome.BlindSimulationToolboxItem", 
					"CF_TOOLBOXITEMCONTAINER,CF_TOOLBOXITEMCONTAINER_HASH,CF_TOOLBOXITEMCONTAINER_CONTENTS", 
					"BlindSimulation", 
					"@BlindSimulationToolboxBitmap;Unican.smartHome.Dsl.dll", 
					0xff00ff)]
	[VSShell::ProvideEditorFactory(typeof(smartHomeEditorFactory), 103, TrustLevel = VSShellInterop::__VSEDITORTRUSTLEVEL.ETL_AlwaysTrusted)]
	[VSShell::ProvideEditorExtension(typeof(smartHomeEditorFactory), "." + Constants.DesignerFileExtension, 50)]
	[DslShell::ProvideRelatedFile("." + Constants.DesignerFileExtension, Constants.DefaultDiagramExtension,
		ProjectSystem = DslShell::ProvideRelatedFileAttribute.CSharpProjectGuid,
		FileOptions = DslShell::RelatedFileType.FileName)]
	[DslShell::ProvideRelatedFile("." + Constants.DesignerFileExtension, Constants.DefaultDiagramExtension,
		ProjectSystem = DslShell::ProvideRelatedFileAttribute.VisualBasicProjectGuid,
		FileOptions = DslShell::RelatedFileType.FileName)]
	[DslShell::RegisterAsDslToolsEditor]
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[DslShell::ProvideBindingPath]
	[DslShell::ProvideXmlEditorChooserBlockSxSWithXmlEditor(@"smartHome", typeof(smartHomeEditorFactory))]
	internal abstract partial class smartHomePackageBase : DslShell::ModelingPackage
	{
		protected global::Unican.smartHome.smartHomeToolboxHelper toolboxHelper;	
		
		/// <summary>
		/// Initialization method called by the package base class when this package is loaded.
		/// </summary>
		protected override void Initialize()
		{
			base.Initialize();

			// Register the editor factory used to create the DSL editor.
			this.RegisterEditorFactory(new smartHomeEditorFactory(this));
			
			// Initialize the toolbox helper
			toolboxHelper = new global::Unican.smartHome.smartHomeToolboxHelper(this);

			// Create the command set that handles menu commands provided by this package.
			smartHomeCommandSet commandSet = new smartHomeCommandSet(this);
			commandSet.Initialize();
			
			// Create the command set that handles cut/copy/paste commands provided by this package.
			smartHomeClipboardCommandSet clipboardCommandSet = new smartHomeClipboardCommandSet(this);
			clipboardCommandSet.Initialize();
			
			// Register the model explorer tool window for this DSL.
			this.AddToolWindow(typeof(smartHomeExplorerToolWindow));

			// Initialize Extension Registars
			// this is a partial method call
			this.InitializeExtensions();

			// Add dynamic toolbox items
			this.SetupDynamicToolbox();
		}

		/// <summary>
		/// Partial method to initialize ExtensionRegistrars (if any) in the DslPackage
		/// </summary>
		partial void InitializeExtensions();
		
		/// <summary>
		/// Returns any dynamic tool items for the designer
		/// </summary>
		/// <remarks>The default implementation is to return the list of items from the generated toolbox helper.</remarks>
		protected override global::System.Collections.Generic.IList<DslDesign::ModelingToolboxItem> CreateToolboxItems()
		{
			try
			{
				Debug.Assert(toolboxHelper != null, "Toolbox helper is not initialized");
				return toolboxHelper.CreateToolboxItems();
			}
			catch(global::System.Exception e)
			{
				global::System.Diagnostics.Debug.Fail("Exception thrown during toolbox item creation.  This may result in Package Load Failure:\r\n\r\n" + e);
				throw;
			}
		}
		
		
		/// <summary>
		/// Given a toolbox item "unique ID" and a data format identifier, returns the content of
		/// the data format. 
		/// </summary>
		/// <param name="itemId">The unique ToolboxItem to retrieve data for</param>
		/// <param name="format">The desired format of the resulting data</param>
		protected override object GetToolboxItemData(string itemId, DataFormats.Format format)
		{
			Debug.Assert(toolboxHelper != null, "Toolbox helper is not initialized");
		
			// Retrieve the specified ToolboxItem from the DSL
			return toolboxHelper.GetToolboxItemData(itemId, format);
		}
	}

}

//
// Package attributes which may need to change are placed on the partial class below, rather than in the main include file.
//
namespace Unican.smartHome
{
	/// <summary>
	/// Double-derived class to allow easier code customization.
	/// </summary>
	[VSShell::ProvideMenuResource("1000.ctmenu", 1)]
	[VSShell::ProvideToolboxItems(1)]
	[VSTextTemplatingHost::ProvideDirectiveProcessor(typeof(global::Unican.smartHome.smartHomeDirectiveProcessor), global::Unican.smartHome.smartHomeDirectiveProcessor.smartHomeDirectiveProcessorName, "A directive processor that provides access to smartHome files")]
	[global::System.Runtime.InteropServices.Guid(Constants.smartHomePackageId)]
	internal sealed partial class smartHomePackage : smartHomePackageBase
	{
	}
}