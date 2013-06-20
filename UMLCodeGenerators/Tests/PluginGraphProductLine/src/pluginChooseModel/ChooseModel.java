////////////////////////////////////////////////////////////
//
// Author: Patricia Abascal Fernández
// Version: 1.2
// Last modification: 26/04/2013 
// Description: Choose element from an option box
////////////////////////////////////////////////////////////
package pluginChooseModel;
 
import java.util.List;

import org.eclipse.jface.viewers.ArrayContentProvider;
import org.eclipse.jface.viewers.LabelProvider;
import org.eclipse.swt.widgets.Display;
import org.eclipse.swt.widgets.Shell;
import org.eclipse.ui.dialogs.ListDialog; 

public class ChooseModel  {   
	public String windowChooseModel (List<String> list){  
		Display display = new Display();
		Shell shell = new Shell(display); 
		shell.setText("Choose the model");
		ListDialog ld = new ListDialog(shell); 
		ld.setAddCancelButton(true); 
		ld.setContentProvider(new ArrayContentProvider()); 
		ld.setLabelProvider(new LabelProvider()); 
		ld.setInput(list); 
		ld.setInitialSelections(list.toArray());  
		ld.setTitle("Select the name of the model you want to generate."); 
		ld.open();  
		return ld.getResult()[0].toString();
	}  
}