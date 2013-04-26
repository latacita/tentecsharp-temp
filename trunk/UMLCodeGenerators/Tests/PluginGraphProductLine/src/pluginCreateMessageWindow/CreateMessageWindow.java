////////////////////////////////////////////////////////////
//
// Author: Patricia Abascal Fernández
// Version: 1.0 
// Last modification: 16/03/2013 
// Description: Create the window to show messages
////////////////////////////////////////////////////////////
package pluginCreateMessageWindow;

import javax.swing.JFrame;
import javax.swing.JOptionPane;

public class CreateMessageWindow {
	// Create a message window
	public void createMessageWindow(String message){
		JOptionPane.showMessageDialog(new JFrame(), message, "Warning", JOptionPane.WARNING_MESSAGE);
	}
	public void createErrorWindow(String message){
		JOptionPane.showMessageDialog(new JFrame(), message, "Error", JOptionPane.ERROR_MESSAGE);
	}
}
