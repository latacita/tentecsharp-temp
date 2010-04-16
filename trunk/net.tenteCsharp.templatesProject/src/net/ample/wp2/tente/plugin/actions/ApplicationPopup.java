package net.ample.wp2.tente.plugin.actions;


import java.io.BufferedWriter;
import java.io.File;
import java.io.FileWriter;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.Map;
import net.ample.wp2.tente.plugin.properties.TentePropertyPage;
import net.ample.wp2.tente.plugin.widgets.ErrorTargetProjectDomain;
import org.eclipse.core.resources.IFile;
import org.eclipse.core.runtime.CoreException;
import org.eclipse.core.runtime.IPath;
import org.eclipse.core.runtime.QualifiedName;
import org.eclipse.jdt.core.ICompilationUnit;
import org.eclipse.jface.action.IAction;
import org.eclipse.jface.viewers.ISelection;
import org.eclipse.jface.viewers.IStructuredSelection;
import org.eclipse.swt.widgets.MessageBox;
import org.eclipse.swt.widgets.Shell;
import org.eclipse.ui.IObjectActionDelegate;
import org.eclipse.ui.IWorkbenchPart;
import tenteplugin.actions.WorkflowCreator;
import util.PageHelp;

public class ApplicationPopup implements IObjectActionDelegate {

	private IWorkbenchPart part;
	private Shell shell;
	//private ArrayList<ICompilationUnit> selection;
	private IPath path;
	private static final String WORKFLOW_LOCATION_NO_TRACEABILITY = "platform:/plugin/net.ample.wp2.tente.plugin/src/applicationTemplates/generateProduct.oaw";
	private static final String WORKFLOW_LOCATION_TRACEABILITY = "platform:/plugin/net.ample.wp2.tente.plugin/src/applicationTemplates/generateProductwithTraceability.oaw";
	
	
	private ISelection selection;
	
	private TenteActionHelperApplication helper;
	/**
	 * Constructor for Action1.
	 */
	public ApplicationPopup() {
		super();
	}

	/**
	 * @see IObjectActionDelegate#setActivePart(IAction, IWorkbenchPart)
	 */
	public void setActivePart(IAction action, IWorkbenchPart targetPart) {
		shell = targetPart.getSite().getShell();
		this.part = targetPart;
	}

	/**
	 * @see IActionDelegate#run(IAction)
	 */
	public void run(IAction action) {
//		String openFile = path.toString();
//		String openDir= path.removeLastSegments(1).toString();
//			
//		File workflowFile=null;
//		FileWriter fstream;
//		BufferedWriter out;
//		
//		try{
//			workflowFile=new File(openDir+"/workflow.oaw");
//			fstream = new FileWriter(workflowFile);
//			out = new BufferedWriter(fstream);
//			out.write(WorkflowCreator.generateApplicationWorkflow(openFile,openDir));
//			out.close();
//		}catch(Exception e){
//			System.err.println("Error opening workflow file: " + e.getMessage());
//		}
//		
//		String wfFile = openDir+"/workflow.oaw";
//		Map <String,String> properties = new HashMap();
//		Map <String,String> slotContents = new HashMap();
////		new WorkflowRunner().run(wfFile ,
////			new NullProgressMonitor(), properties, slotContents);		
//		
//		if(workflowFile!=null){
//			workflowFile.delete();
//		}
//		
//		MessageBox finalMessage=new MessageBox(shell);
//		finalMessage.setMessage("Application Model Skeleton Generated");
//		finalMessage.open();	
		
		

		Object file = ((IStructuredSelection)selection).getFirstElement();
		if (file instanceof IFile){



			this.helper = new TenteActionHelperApplication();
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
				helper.setWorkflow(ApplicationPopup.WORKFLOW_LOCATION_TRACEABILITY);
			} else {
				helper.setWorkflow(ApplicationPopup.WORKFLOW_LOCATION_NO_TRACEABILITY);
			} // if	

			// new File(openDir+"\\src-skeleton-trace").mkdir();
			//TraceableFileExtension.setDestinationFile("src//traceability.xml");

			boolean ok=checkTargetProjectApplication(file);
			if (ok){
				ok=checkReferenceApplication(file);
				if (ok){
					helper.run(action);
					//
					
					//DependencyHelper dependency=new DependencyHelper();
					//dependency.addEntryToClasspath(project, null, entry, 2);
				}
				else{
					String message = "It´s not found a CeaserJ project reference, please select a CeaserJ project in the properties page of this project";
					 ErrorTargetProjectDomain dialog=new ErrorTargetProjectDomain(new Shell(),message,PageHelp.REFERENCE_PROJECT_APPLICATION);
					 dialog.open();
				}
				//helper.run(action);
				//
				
				//DependencyHelper dependency=new DependencyHelper();
				//dependency.addEntryToClasspath(project, null, entry, 2);
			}
			else{
				String message = "It´s not found a CeaserJ project target, please select a CeaserJ project in the properties page of this project";
				 ErrorTargetProjectDomain dialog=new ErrorTargetProjectDomain(new Shell(),message,PageHelp.TARGET_PROJECT_APPLICATION);
				 dialog.open();
			}
			
		
		}
		
		
		
	}
	
	/**
	 * @see IActionDelegate#selectionChanged(IAction, ISelection)
	 */
	public void selectionChanged(IAction action, ISelection selection) {
//		// Lets remember the selection
//		this.selection = new ArrayList<ICompilationUnit>();
//		if (! (selection instanceof IStructuredSelection))  {
//			System.out.println("NOT a structured selection");
//			return;
//		}
//		IStructuredSelection strucSelection = (IStructuredSelection) selection;
//		Object object = strucSelection.getFirstElement();
//		if (object instanceof IFile) {
//			path=((IFile)object).getLocation();
//		}	
		this.selection = selection;
	}

	
	private boolean checkTargetProjectApplication(Object file) {
		
		boolean result=false;
		
		String value=null;
		try {
			value = (String)((IFile) file).getProject().getPersistentProperties().get(new QualifiedName("",TentePropertyPage.APPLICATION_TARGET_PROJECT));
		} catch (CoreException e) {
			
		}
		if ((value!=null)&& (!value.equals(""))){
			result=true;
		}
		return result;
	} //
	
	private boolean checkReferenceApplication(Object file) {
		
		boolean result=false;
		
		String value=null;
		try {
			value = (String)((IFile) file).getProject().getPersistentProperties().get(new QualifiedName("",TentePropertyPage.APPLICATION_REFERENCE_PROJECT));
		} catch (CoreException e) {
			
		}
		if ((value!=null)&& (!value.equals(""))){
			result=true;
		}
		return result;
	} //
	
}