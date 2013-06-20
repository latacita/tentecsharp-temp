import org.eclipse.swt.SWT;
import org.eclipse.swt.graphics.Rectangle;
import org.eclipse.swt.widgets.Display;
import org.eclipse.swt.widgets.FileDialog; 
import org.eclipse.swt.widgets.Monitor;
import org.eclipse.swt.widgets.Shell;

public class SelectFile {  
	public String selectFileWindow() {
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
		FileDialog fd = new FileDialog(shell, SWT.OPEN);
	    fd.setText("Select the UML model file to transform");
	    fd.setFilterPath("C:/");
	    String[] filterExt = { "*.uml" };
	    fd.setFilterExtensions(filterExt);
	    String selected = fd.open();   
	    display.dispose();  
	    return selected;
	  }

	  public static void main(String[] argv) {
	    new SelectFile().selectFileWindow();
	  }

	}
