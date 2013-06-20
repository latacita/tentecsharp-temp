import java.io.File;
import java.util.ArrayList;
import java.util.List;   

import javax.swing.JFileChooser;
import javax.swing.JFrame;
 
import org.eclipse.emf.ecore.EPackage;
import org.eclipse.epsilon.egl.EglFileGeneratingTemplateFactory; 
import org.eclipse.epsilon.egl.EglTemplateFactoryModuleAdapter;
import org.eclipse.epsilon.eol.IEolExecutableModule;
import org.eclipse.epsilon.eol.models.IModel;
import org.eclipse.uml2.uml.UMLPackage;  
 

public class EglStandalone extends EpsilonStandalone {
	
	public static void main(String[] args) throws Exception {  
		new EglStandalone().execute(); 
	}
	
	@Override
	public IEolExecutableModule createModule() { 
		return new EglTemplateFactoryModuleAdapter(new EglFileGeneratingTemplateFactory()); 
	}

	@Override
	public List<IModel> getModels() throws Exception {
		List<IModel> models = new ArrayList<IModel>(); 
		EPackage.Registry.INSTANCE.put(UMLPackage.eINSTANCE.getNsURI(), UMLPackage.eINSTANCE); 
		// Window dialog to choose the uml file
		//String pathFile=new SelectFile().selectFileWindow();  
		File fileToSave = null;
		JFrame parentFrame = new JFrame();		 
		JFileChooser fileChooser = new JFileChooser();
		boolean compatibleFile=false;
		while (!compatibleFile){
			fileChooser.setDialogTitle("Select the UML model file to transform"); 		 
			int userSelection = fileChooser.showSaveDialog(parentFrame);		 
			if (userSelection == JFileChooser.APPROVE_OPTION) {
				fileToSave = fileChooser.getSelectedFile();
				if (fileToSave.getName().endsWith(".uml")) { 
					compatibleFile=true;
				}		      
			}
		}
		String[] newName= fileToSave.getAbsolutePath().split("\\\\");	
		 		   
		//String[] newName= pathFile.split("\\\\");		
		
		String pathFromOriginalFile=newName[0];
		for (int i=1; i<newName.length-1;i++){
			pathFromOriginalFile=pathFromOriginalFile+"\\"+newName[i];
		} 
		String path=new UMLAdaptador().replace(new File(pathFromOriginalFile+"\\"+newName[newName.length-1]), newName[newName.length-1].split(".uml")[0]+"_compatible.uml");
		models.add(createUmlModelByURI("M", path, UMLPackage.eNS_URI, true, true));    
		return models;
	}

	@Override
	public String getSource() throws Exception {
		return "Templates/ProjectCreation.egl";
	}

	@Override
	public void postProcess() { 
		System.out.println(result);
	} 
}
