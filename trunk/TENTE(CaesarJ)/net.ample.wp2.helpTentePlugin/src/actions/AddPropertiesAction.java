package actions;

import helptenteplugin.Activator;

import org.eclipse.jface.action.Action;
import org.eclipse.jface.viewers.ISelection;
import org.eclipse.jface.viewers.IStructuredSelection;
import org.eclipse.ui.PlatformUI;
import org.eclipse.jdt.ui.JavaUI;


public class AddPropertiesAction extends Action {

	public void run(){
		
		ISelection selection=PlatformUI.getWorkbench().getActiveWorkbenchWindow().getActivePage().getSelection(JavaUI.ID_PACKAGES);
		ISelection selection2=PlatformUI.getWorkbench().getActiveWorkbenchWindow().getActivePage().getSelection("org.eclipse.ui.project.properties");
	
		//selection2.toString();
		if (selection instanceof IStructuredSelection){
			//Object obj=((IStructuredSelection) selection).getFirstElement();
		}
	}
	
	
	
}
