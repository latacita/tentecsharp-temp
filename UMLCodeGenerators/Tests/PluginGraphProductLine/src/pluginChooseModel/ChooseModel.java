////////////////////////////////////////////////////////////
//
// Author: Patricia Abascal Fernández
// Version: 1.2
// Last modification: 26/04/2013 
// Description: Choose element from an option box
////////////////////////////////////////////////////////////
package pluginChooseModel;
 
import java.util.List;
import javax.swing.JFrame;
import javax.swing.JOptionPane;

public class ChooseModel extends JFrame{ 
	private static final long serialVersionUID = -2285558681904665221L; 
	public String windowChooseModel (List<Object> m){  
		Object models[] = (Object[]) m.toArray();  
		JFrame frame = new JFrame();
	    String name= (String) JOptionPane.showInputDialog(frame, 
	        "Select the name of the model you want to generate.",
	        "Choose the model",
	        JOptionPane.QUESTION_MESSAGE, 
	        null, 
	        models, 
	        models[0]); 
	    return name; 
	}
}