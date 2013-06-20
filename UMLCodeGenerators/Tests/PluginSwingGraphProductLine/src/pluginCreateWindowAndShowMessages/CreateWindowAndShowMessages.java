////////////////////////////////////////////////////////////
//
// Author: Patricia Abascal Fernández
// Version: 1.2
// Last modification: 26/04/2013 
// Description: Window to show content of a file
////////////////////////////////////////////////////////////
package pluginCreateWindowAndShowMessages;

import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;

import javax.swing.JFrame;
import javax.swing.JOptionPane;
import javax.swing.JScrollPane;
import javax.swing.JTextArea;
/**
 * Class to create a window and show a file's content on it
 * @author Patricia
 *
 */
public class CreateWindowAndShowMessages {
	public void createWindowAndShowMessages(String path) throws FileNotFoundException, IOException{
		try {
			JTextArea ta = new JTextArea(20, 60);  
			ta.read(new FileReader(path), null);  
			ta.setEditable(false);   
			JOptionPane.showMessageDialog(new JFrame(), new JScrollPane(ta), "Log Messages", JOptionPane.WARNING_MESSAGE);
		}catch (IOException ioe) {  
			ioe.printStackTrace();  
		}  
	} 
}
