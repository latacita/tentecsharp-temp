//------------------------------------------------------------------------------------------//
// Author: Pablo Sánchez (pablo@lcc.uma.es)			//
//         Carlos Nebrera							//
// Date: 04/06/2009	                Version: 0.2    //
//--------------------------------------------------//

package net.ample.wp2.tente.plugin.actions;

// Imports from the own project
import net.ample.wp2.tente.plugin.properties.TentePropertyPage;
import net.ample.wp2.tente.plugin.widgets.ErrorTargetProjectDomain;
import org.eclipse.core.resources.IFile;
import org.eclipse.core.runtime.CoreException;
import org.eclipse.core.runtime.QualifiedName;
import org.eclipse.jface.action.IAction;
import org.eclipse.jface.viewers.ISelection;
import org.eclipse.jface.viewers.IStructuredSelection;
import org.eclipse.swt.widgets.MessageBox;
import org.eclipse.swt.widgets.Shell;
import org.eclipse.ui.IActionDelegate;
import util.PageHelp;


public class SkeletonPopup implements IActionDelegate {

	// This is the workflow we must execute
	private static final String WORKFLOW_LOCATION_NO_TRACEABILITY = "platform:/plugin/net.ample.wp2.tente.plugin/src/skeletonTemplates/generateSkeletons.oaw";
	private static final String WORKFLOW_LOCATION_TRACEABILITY = "platform:/plugin/net.ample.wp2.tente.plugin/src/skeletonTemplates/generateSkeletonswithTraceability.oaw";
	private TenteActionHelper helper;
	private ISelection selection;
	
/*	SkeletonPopup () {
		this.helper = new TenteActionHelper();
		helper.setWorkflow(this.WORKFLOW_LOCATION);
	} */

	/**
	 * Selection in the workbench has changed.
	 * 
	 * @see IActionDelegate#selectionChanged
	 */
	public void selectionChanged(IAction action, ISelection selection) {
		this.selection = selection;
	}

	
	/**
	 * Called when the action was selected. 
	 * We check that:
	 *  	- Only one file has been selected.
	 *  	- the file satisfies all the applicable constraints
	 *  	- is actually a file
	 */
	public void run(IAction action) {
		
		MessageBox box=new MessageBox(new Shell());
	
		
		Object file = ((IStructuredSelection)selection).getFirstElement();
		if (file instanceof IFile){

			

			this.helper = new TenteActionHelper();
			helper.setSelection(this.selection);

			//IPreferenceStore store = PlatformUI.getPreferenceStore();
			//boolean valueTraceability=store.getBoolean(PreferenceConstants.P_BOOLEAN_TRACEABILITY);
			boolean valueTraceability = false;
			try {
				
				
				String value=(String) ((IFile)file).getProject().getPersistentProperties().get(new QualifiedName("",TentePropertyPage.TRACEABILITY_ENABLED));
				valueTraceability=Boolean.parseBoolean(value);
			} catch (CoreException e) {
				
				e.printStackTrace();
			}

		
			
			helper.setTraceabilityEnabled(valueTraceability);
			if (valueTraceability) {
				helper.setWorkflow(SkeletonPopup.WORKFLOW_LOCATION_TRACEABILITY);
			} else {
				helper.setWorkflow(SkeletonPopup.WORKFLOW_LOCATION_NO_TRACEABILITY);
			} // if	

			// new File(openDir+"\\src-skeleton-trace").mkdir();
			//TraceableFileExtension.setDestinationFile("src//traceability.xml");

			boolean ok=checkTargetProjectDomain(file);
			if (ok){
			
				helper.run(action);
			}
			else{
				String message = "It´s not found a CeaserJ project target, please select a CeaserJ project in the properties page of this project";
				 ErrorTargetProjectDomain dialog=new ErrorTargetProjectDomain(new Shell(),message,PageHelp.TARGET_PROJECT_DOMAIN);
				 dialog.open();
			}
		}
	} //run 


// Esto es lo original que tenía Carlos	
	
	
////	/**
////	 * @see IActionDelegate#run(IAction)
////	 */
////	public void run(IAction action) {
////		
///			
////		File workflowFile=null;
////		FileWriter fstream;
////		BufferedWriter out;
////			    
////		MessageBox traceabilityMessage=new MessageBox(shell,SWT.YES|SWT.NO);
////		traceabilityMessage.setMessage("Do you want to generate traceability information?");
////		int selection=traceabilityMessage.open();
////		boolean trace;
////		if(selection==SWT.YES){
////			trace=true;
///				new File(openDir+"\\src-skeleton-trace").mkdir();
////			TraceableFileExtension.setDestinationFile(openDir+"\\src-skeleton-trace\\traceability.xml");
////		}else{
////			trace=false;
////		}
////		
////		try{
////			workflowFile=new File(openDir+"/workflow.oaw");
////			fstream = new FileWriter(workflowFile);
////			out = new BufferedWriter(fstream);
////			out.write(WorkflowCreator.generateSkeletonWorkflow(openFile,openDir,trace));
////			out.close();
////		}catch(Exception e){
////			System.err.println("Error opening workflow file: " + e.getMessage());
////		}
////		
////		String wfFile = openDir+"/workflow.oaw";
////		Map <String,String> properties = new HashMap();
////		Map <String,String> slotContents = new HashMap();
////		new WorkflowRunner().run(wfFile ,
////			new NullProgressMonitor(), properties, slotContents);		
////		
////		if(workflowFile!=null){
////			workflowFile.delete();
////		}
////		
////		MessageBox finalMessage=new MessageBox(shell);
////		finalMessage.setMessage("Family Model Skeleton Generated");
////		finalMessage.open();	
////	}

	private boolean checkTargetProjectDomain(Object file) {
		
		boolean result=false;
		
		String value=null;
		try {
			value = (String)((IFile) file).getProject().getPersistentProperties().get(new QualifiedName("",TentePropertyPage.DOMAIN_TARGET_PROJECT));
		} catch (CoreException e) {
			
		}
		if ((value!=null)&& (!value.equals(""))){
			result=true;
		}
		return result;
	} //
}