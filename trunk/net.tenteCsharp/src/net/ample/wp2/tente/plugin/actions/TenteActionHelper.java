package net.ample.wp2.tente.plugin.actions;

import java.io.IOException;
import java.io.StringBufferInputStream;
import java.lang.reflect.InvocationTargetException;
import java.net.MalformedURLException;
import java.net.URL;
import java.util.StringTokenizer;
import net.ample.wp2.tente.plugin.properties.TentePropertyPage;
import org.eclipse.core.resources.IFile;
import org.eclipse.core.resources.IFolder;
import org.eclipse.core.resources.IProject;
import org.eclipse.core.resources.IWorkspace;
import org.eclipse.core.runtime.CoreException;
import org.eclipse.core.runtime.FileLocator;
import org.eclipse.core.runtime.IProgressMonitor;
import org.eclipse.core.runtime.QualifiedName;
import org.eclipse.core.runtime.SubProgressMonitor;
import org.eclipse.jface.action.IAction;
import org.eclipse.jface.operation.IRunnableWithProgress;
import org.eclipse.jface.viewers.ISelection;
import org.eclipse.jface.viewers.IStructuredSelection;
import org.eclipse.ui.IActionDelegate;
import org.eclipse.ui.PlatformUI;

// public abstract class ActionsHelper {
public class TenteActionHelper {	
	

	protected String workflow;
	private ISelection selection = null;
	private boolean traceabilityEnabled = false;
	

	public boolean isTraceabilityEnabled() {
		return traceabilityEnabled;
	}

	public void setTraceabilityEnabled(boolean traceabilityEnabled) {
		this.traceabilityEnabled = traceabilityEnabled;
	}

	public String getWorkflow() {
		return workflow;
	}

	public void setWorkflow(String workflow) {
		this.workflow = workflow;
	}
	
	public ISelection getSelection() {
		return selection;
	}

	public void setSelection(ISelection selection) {
		this.selection = selection;
	}

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
		if (selection instanceof IStructuredSelection) {
			if (((IStructuredSelection) selection).size() != 1) {
				// TENTE does not support multiple files selection
				// TODO: Change this for a more proper dialog box	
			} else { 
				// We extract the object corresponding to the first element of the collection
				Object obj = ((IStructuredSelection)selection).getFirstElement();
				// This object must be a file and it must be a uml file
				if ((obj instanceof IFile)) {
					if (isFileOk((IFile) obj)) {
						process((IFile) obj);
					} else {
						// TODO: Change this for a more proper dialog box	
						System.out.println("ERROR: The file does not satisfy the constraints.");
						System.out.println("In: tenteplugin.popup.actions.SkeletonPopup.run");
					} // if
				} else {
					// TODO: Change this for a more proper dialog box	
					System.out.println("ERROR: A file has not been selected. You must select a file.");
					System.out.println("In: tenteplugin.popup.actions.SkeletonPopup.run");
				} //if
			} // if
		} else {
			// TODO: Change this for a more proper dialog box
			System.out.println("ERROR: Selection is not a structured selection.");
			System.out.println("In: tenteplugin.popup.actions.SkeletonPopup.run");
		} // if 
	} // run
	
	
	
	
	
	/**
	 * Invoked for every file containing a reference architecture for which the TENTE code  
	 * generator must be applied. Triggers a separate job to get us out of the UI 
	 * thread as quickly as possible. Also, this gives us a progress monitor to 
	 * use for reporting any progress we might be making.
	 * 
	 * @param file
	 */
	private void process(final IFile file) {

		final IProject newProject = createCaesarjProject(file);

		if (newProject!=null){

			try {
				final String targetDir    = newProject.getFolder("/src").getLocation().toString();
				// We try to inform the user about the progress of the operation 
				IRunnableWithProgress runnable = new IRunnableWithProgress() {
					public void run(IProgressMonitor monitor)
					throws InvocationTargetException, InterruptedException {
						try {
							executeCodeGenerator(file, monitor, workflow, targetDir);
						} catch (IOException ioe) {
							ioe.printStackTrace();
						} catch (CoreException e) {
							e.printStackTrace();
						}
					}
				};
				// We execute the runnable element 
				PlatformUI.getWorkbench().getProgressService().busyCursorWhile(runnable);		
				// Catching of multiple exceptions for making Java happy. :-). 
			} catch (InvocationTargetException e) {
				e.getTargetException().printStackTrace();
			} catch (InterruptedException e) {
				e.printStackTrace();
			} // try 
		}
//		else{
//			String message = "It´s not found a CeaserJ project target, please select a CeaserJ project in the properties page of this project";
//			//Status status = new Status(IStatus.ERROR, PlatformUI.PLUGIN_ID, 0,"Status Error Message", null);
//		    //ErrorDialog errorDialog=new ErrorDialog(new Shell(), "ERROR", message,status, 0);
//			//errorDialog.open();  
//			// ErrorDialog.openError(new Shell(),      "Error",message, status);
//		
//			 ErrorTargetProjectDomain dialog=new ErrorTargetProjectDomain(new Shell(),message);
//			 dialog.open();
//			//PlatformUI.getWorkbench().getHelpSystem().displayHelpResource("/helptenteplugin.Activator/html/targetProjectDomain.html");
//			
//		}
	} // process

	
	
	protected IProject createCaesarjProject(IFile file){

		
		IProject result=null;
		
		try {
			String value=(String) file.getProject().getPersistentProperties().get(new QualifiedName("",TentePropertyPage.DOMAIN_TARGET_PROJECT));
			if (value!=null){
				//Search project
				IWorkspace workspace=file.getProject().getWorkspace();
			
				 IProject[] projectsWorkspace=workspace.getRoot().getProjects();

				 String nameProject=null;
				 StringTokenizer st = new StringTokenizer(value,"\\");
				 while (st.hasMoreTokens()) {
					 nameProject=st.nextToken();
				 }

				 for (int i=0;i<projectsWorkspace.length;i++){
					 String name=projectsWorkspace[i].getName();
					 if (name.equals(nameProject)){
						 result=projectsWorkspace[i];
					 }

				 }
			}
			//
//					 			//  try {
//					 			//	  String[] name=projectsWorkspace[i].getDescription().getNatureIds();
//				  ArrayList<IProject> projectsCJ=new ArrayList<IProject>();
				
			
			
		} catch (CoreException e) {
			
			e.printStackTrace();
		}
		
		
		
		
		return result;
		


	}
	
	
	
	
	
	public void getAndCopyWorkflow(IProject project, IProgressMonitor monitor, String workflowLocation) 
		throws IOException, MalformedURLException, CoreException {
	
		IFolder srcGenFolder;
	
		// Obtain the URL of the workflow we are going to use. This is in the
		// 	generator project.
		URL urlToWf = FileLocator.toFileURL(new URL(workflowLocation));
		if (urlToWf == null) {
			// TODO: Put this in a more proper window 
			System.out.println("The TENTE plugin is not able to find the workflow for generating implementation skeletons.");
			System.out.println("Contact pablo@lcc.uma.es and report about the bug 'generateSkeletons.oaw' could not be found'.");
			System.out.println("In: net.ample.wp2.tente.plugin.actions.skeletonPopup");
		} else {
			// Copy workflow
			srcGenFolder = project.getFolder("/src-gen");
			if (!srcGenFolder.exists()) {
				DependencyHelper.checkFolder(project, monitor,srcGenFolder);
				srcGenFolder.create(false, true, new SubProgressMonitor(monitor, 1));
				// TODO: Change this, if the folder does not exist, simply created it, 
				// 		 it should not be so dramatic	
				// 	throw new IOException(
				//		"Folder /src-gen/ does not exist. This is unexpected!");
			} // if
			IFile fTarget = srcGenFolder.getFile("generateSkeletons.oaw");
			if (fTarget.exists()) {
				// If the file already exists, delete it 
				fTarget.delete(true, monitor);
			} // if
			// 	Copy the workflow into the workspace. 
			// TODO: Change this, I really dislike this solution
			fTarget.create(urlToWf.openStream(), true, monitor);
		} // if	
	} // getAndCopyWorkflow
	
	public boolean executeCodeGenerator(IFile file, IProgressMonitor monitor, String workflow, String targetDir) throws CoreException, MalformedURLException, IOException {		
	
		IProject srcProject = file.getProject();
	
		//First ensure the target project is indeed an oAW project
		// NOTE (Pablo): Theorically, the project does not need to be an oAW project
		//               but I am going to leave here because probably we need it
		DependencyHelper.ensureProjectSettingIsOk(file.getProject(), monitor, srcProject.getFolder(file.getProjectRelativePath().removeLastSegments(1)));
	
		// Get the workflow and copy it into the workspace
		// TODO: I do not like this, I would prefer to execute the workflow directly from the plugin
		getAndCopyWorkflow(srcProject, monitor, workflow);

		// Generate properties file
		StringBuffer sbProperties = new StringBuffer();
		sbProperties.append("umlModel  = ").append(file.getLocation()).append('\n');
		// Aquí es donde hay que tocar
		sbProperties.append("targetDir = ").append(targetDir).append('\n');
	
		// Get the properties file
		IFolder srcGenFolder = srcProject.getFolder("/src-gen");
		IFile propFile = srcGenFolder.getFile("skeleton.properties");
	
		// In case this file already exist, delete it
		if (propFile.exists()) {
			propFile.delete(true, monitor);
		} // if
	
		// Create it again
		// TODO: Change this, I do not like this solution
		propFile.create(new StringBufferInputStream(sbProperties.toString()), true, monitor);
	
		// Invoke workflow 
		IFile fWorkflow = srcGenFolder.getFile("generateSkeletons.oaw");
		WorkflowHelper.executeWorkflow("Executing " + file.getName(), fWorkflow);
		return true; 
	
	} // executeCodeGenerator	
	
	// This method check that the file satisfies the following constraints 
	private boolean isFileOk(IFile obj) {
		// TODO: Check some constraints, such as for instance that the file has 
		// 		 the proper extension
		return true;
	} // isFileOk
	

}
