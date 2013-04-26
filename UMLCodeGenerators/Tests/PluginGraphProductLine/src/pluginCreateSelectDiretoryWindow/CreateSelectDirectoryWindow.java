////////////////////////////////////////////////////////////
//
// Author: Patricia Abascal Fernández
// Version: 1.0 
// Last modification: 17/03/2013 
// Description: Create the window to select directory
////////////////////////////////////////////////////////////
package pluginCreateSelectDiretoryWindow;

import javax.swing.JFileChooser;
import javax.swing.JFrame;  
import java.io.File; 

public class CreateSelectDirectoryWindow { 
	// Create a browse window to save the project
	public String createSelectDirectoryWindow(){
		String path=""; 
		// Parent component of the dialog
		JFrame parentFrame = new JFrame();
		 
		JFileChooser fileChooser = new JFileChooser();
		fileChooser.setDialogTitle("Specify a directory to save the project");    
		 
		int userSelection = fileChooser.showSaveDialog(parentFrame);
		 
		if (userSelection == JFileChooser.APPROVE_OPTION) {
		    File fileToSave = fileChooser.getSelectedFile();
		    path=fileToSave.getAbsolutePath();  
		}
		return path;
	}
}