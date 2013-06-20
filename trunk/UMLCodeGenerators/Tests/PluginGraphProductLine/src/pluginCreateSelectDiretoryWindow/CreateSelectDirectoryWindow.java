////////////////////////////////////////////////////////////
//
// Author: Patricia Abascal Fernández
// Version: 1.1 
// Last modification: 20/06/2013 
// Description: Create the window to select directory
////////////////////////////////////////////////////////////
package pluginCreateSelectDiretoryWindow; 

import org.eclipse.swt.graphics.Rectangle;
import org.eclipse.swt.widgets.DirectoryDialog;
import org.eclipse.swt.widgets.Display;
import org.eclipse.swt.widgets.Monitor;
import org.eclipse.swt.widgets.Shell; 

public class CreateSelectDirectoryWindow { 
	public static void main(String[] args) {
		CreateSelectDirectoryWindow e= new CreateSelectDirectoryWindow();
		System.out.println(e.createSelectDirectoryWindow());
	}
	// Create a browse window to save the project
	public String createSelectDirectoryWindow(){
		 Display display = new Display();
		 Shell shell = new Shell(display); 
		 Monitor primary = display.getPrimaryMonitor();
	     Rectangle bounds = primary.getBounds();
	     Rectangle rect = shell.getBounds();
	    
	     int x = bounds.x + (bounds.width - rect.width) / 2;
	     int y = bounds.y + (bounds.height - rect.height) / 2;
	    
	     shell.setLocation(x, y);
	     shell.open(); 
		 shell.setVisible(false); 
		 DirectoryDialog dialog = new DirectoryDialog(shell); 
		 dialog.setText("Specify a directory to save the project");
		 dialog.setMessage("Select a directory");
		 dialog.setFilterPath("c:\\"); // Windows specific 
		 String path=dialog.open();
		 while (!shell.isDisposed() & path==null) {
			 if (!display.readAndDispatch())
				 display.sleep();
		 }
		 display.dispose();
		 return path; 
	}
}