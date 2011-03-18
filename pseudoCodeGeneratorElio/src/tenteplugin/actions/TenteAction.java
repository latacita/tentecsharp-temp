package tenteplugin.actions;

import org.eclipse.jface.action.IAction;
import org.eclipse.jface.viewers.ISelection;
import org.eclipse.ui.IWorkbenchWindow;
import org.eclipse.ui.IWorkbenchWindowActionDelegate;
import org.eclipse.jface.dialogs.MessageDialog;
import java.io.*;
import java.util.*;
import org.eclipse.swt.widgets.*;
import org.eclipse.swt.*;

import java.util.*;
import org.openarchitectureware.workflow.monitor.*;
import org.openarchitectureware.workflow.*;
import javaSkeletonExtensions.TraceableFileExtension;


/**
 * Our sample action implements workbench action delegate.
 * The action proxy will be created by the workbench and
 * shown in the UI. When the user tries to use the action,
 * this delegate will be created and execution will be 
 * delegated to it.
 * @see IWorkbenchWindowActionDelegate
 */
public class TenteAction implements IWorkbenchWindowActionDelegate {
	private IWorkbenchWindow window;
	/**
	 * The constructor.
	 */
	public TenteAction() {
	}

	/**
	 * The action has been activated. The argument of the
	 * method represents the 'real' action sitting
	 * in the workbench UI.
	 * @see IWorkbenchWindowActionDelegate#run
	 */
	public void run(IAction action) {
		
		Shell shell= new Shell();
		FileDialog openDialog = new FileDialog(shell,SWT.OPEN|SWT.PRIMARY_MODAL);
		String[] filterExt = { "*.uml"};
	    openDialog.setFilterExtensions(filterExt);
		String openFile = openDialog.open();
	    
		if(openFile!=null){
			DirectoryDialog openDirDialog = new DirectoryDialog(shell,SWT.OPEN|SWT.PRIMARY_MODAL);
			openDirDialog.setMessage("Select the output directory");
			String openDirDirectory = openDirDialog.open();
			
			if(openDirDirectory!=null){
				
				File workflowFile=null;
				FileWriter fstream;
				BufferedWriter out;
			    
				MessageBox traceabilityMessage=new MessageBox(shell,SWT.YES|SWT.NO);
				traceabilityMessage.setMessage("Do you want to generate traceability information?");
				int selection=traceabilityMessage.open();
				boolean trace;
				if(selection==SWT.YES){
					trace=true;
					new File(openDirDirectory+"\\src-skeleton-trace").mkdir();
					TraceableFileExtension.setDestinationFile(openDirDirectory+"\\src-skeleton-trace\\traceability.xml");
				}else{
					trace=false;
				}
				
				try{
					workflowFile=new File(openDirDirectory+"/workflow.oaw");
					fstream = new FileWriter(workflowFile);
					out = new BufferedWriter(fstream);
					out.write(WorkflowCreator.generateSkeletonWorkflow(openFile,openDirDirectory,trace));
					out.close();
				}catch(Exception e){
					System.err.println("Error opening workflow file: " + e.getMessage());
				}
				
				String wfFile = openDirDirectory+"/workflow.oaw";
				Map <String,String> properties = new HashMap();
				Map <String,String> slotContents = new HashMap();
//				new WorkflowRunner().run(wfFile ,
//					new NullProgressMonitor(), properties, slotContents);		
//				
				if(workflowFile!=null){
					workflowFile.delete();
				}
				
				MessageBox finalMessage=new MessageBox(shell);
				finalMessage.setMessage("Family Model Skeleton Generated");
				finalMessage.open();
			}
		}
			
	}

	/**
	 * Selection in the workbench has been changed. We 
	 * can change the state of the 'real' action here
	 * if we want, but this can only happen after 
	 * the delegate has been created.
	 * @see IWorkbenchWindowActionDelegate#selectionChanged
	 */
	public void selectionChanged(IAction action, ISelection selection) {
	}

	/**
	 * We can use this method to dispose of any system
	 * resources we previously allocated.
	 * @see IWorkbenchWindowActionDelegate#dispose
	 */
	public void dispose() {
	}

	/**
	 * We will cache window object in order to
	 * be able to provide parent shell for the message dialog.
	 * @see IWorkbenchWindowActionDelegate#init
	 */
	public void init(IWorkbenchWindow window) {
		this.window = window;
	}
}