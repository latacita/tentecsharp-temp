package net.ample.wp2.tente.plugin.actions;

import java.util.StringTokenizer;
import net.ample.wp2.tente.plugin.properties.TentePropertyPage;
import org.eclipse.core.resources.IFile;
import org.eclipse.core.resources.IProject;
import org.eclipse.core.resources.IWorkspace;
import org.eclipse.core.runtime.CoreException;
import org.eclipse.core.runtime.NullProgressMonitor;
import org.eclipse.core.runtime.QualifiedName;
import org.eclipse.jdt.core.JavaModelException;





public class TenteActionHelperApplication extends TenteActionHelper {

	
	
	protected IProject createCaesarjProject(IFile file){

		IProject result=null;
		IProject referenceProject=null;
		
		result = getProject(file,TentePropertyPage.APPLICATION_TARGET_PROJECT);
		
		
		
		try {
			Object object= file.getProject().getPersistentProperties().get(new QualifiedName("",TentePropertyPage.APPLICATION_REFERENCE_PROJECT));
			//fileReference = (IFile) file.getProject().getPersistentProperties().get(new QualifiedName("",TentePropertyPage.APPLICATION_REFERENCE_PROJECT));
			referenceProject=getProject(file,TentePropertyPage.APPLICATION_REFERENCE_PROJECT);
			
		} catch (CoreException e1) {
			// TODO Auto-generated catch block
			e1.printStackTrace();
		}
		//DependencyHelper dependency=new DependencyHelper();
		
			try {
			
				//IProgressMonitor monitor= new IProgressMonitor();
				DependencyHelper.addEntryToClasspath(result, new NullProgressMonitor(), referenceProject.getFullPath(),DependencyHelper.PROJECT);
			} catch (JavaModelException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
			// TODO Auto-generated catch block
	
		
		return result;
		


	}

	private IProject getProject(IFile file,String property) {
		IProject result=null;
		try {
			String value=(String) file.getProject().getPersistentProperties().get(new QualifiedName("",property));
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
		
		} catch (CoreException e) {
			
			e.printStackTrace();
		}
		return result;
	}
	
	
	
	
	
	
	
}
