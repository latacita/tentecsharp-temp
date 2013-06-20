////////////////////////////////////////////////////////////
//
// Author: Patricia Abascal Fernández
// Version: 1.1
// Last modification: 20/06/2013 
// Description: Create the window to show messages
////////////////////////////////////////////////////////////
package pluginCreateMessageWindow;
  
import org.eclipse.jface.dialogs.MessageDialog;
import org.eclipse.swt.graphics.Rectangle;
import org.eclipse.swt.widgets.Display;
import org.eclipse.swt.widgets.Monitor;
import org.eclipse.swt.widgets.Shell; 
 

public class CreateMessageWindow {
	// Create a message window
	public void createMessageWindow(String message){ 
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
		MessageDialog.openWarning(shell, "Warning", message); 
	}
	public void createErrorWindow(String message){ 
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
		MessageDialog.openError(shell, "Error", message);  
	}
	public static void main(String[] args) {
		CreateMessageWindow e= new CreateMessageWindow();
		e.createMessageWindow("Test");
	}
}
 
