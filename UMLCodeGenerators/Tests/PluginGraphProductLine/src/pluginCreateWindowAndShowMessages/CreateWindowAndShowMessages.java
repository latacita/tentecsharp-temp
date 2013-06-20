////////////////////////////////////////////////////////////
//
// Author: Patricia Abascal Fernández
// Version: 1.2
// Last modification: 20/06/2013 
// Description: Window to show content of a file
////////////////////////////////////////////////////////////
package pluginCreateWindowAndShowMessages;
 
import java.io.BufferedReader; 
import java.io.FileReader;
import java.io.IOException;
  
import org.eclipse.jface.dialogs.MessageDialog;
import org.eclipse.swt.graphics.Rectangle;
import org.eclipse.swt.widgets.Display;
import org.eclipse.swt.widgets.Monitor;
import org.eclipse.swt.widgets.Shell; 

/**
 * Class to create a window and show a file's content on it
 * @author Patricia
 *
 */
public class CreateWindowAndShowMessages {
	public void createWindowAndShowMessages(String path){ 
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
		String text="";
		BufferedReader br = null; 
		try { 
			String sCurrentLine; 
			br = new BufferedReader(new FileReader(path));			
			while ((sCurrentLine = br.readLine()) != null) {
				text=text+"\n"+sCurrentLine;
			} 
		} catch (IOException e) {
			e.printStackTrace();
		} finally {
			try {
				if (br != null)br.close();
			} catch (IOException ex) {
				ex.printStackTrace();
			}
		}
		MessageDialog.openInformation(shell, "Information", text);  
	}
	public static void main(String[] args) {
		CreateWindowAndShowMessages ee= new CreateWindowAndShowMessages();   
		ee.createWindowAndShowMessages("C:\\Users\\Patricia\\Desktop\\log.txt");
	}
}
