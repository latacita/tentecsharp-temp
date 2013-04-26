////////////////////////////////////////////////////////////
//
// Author: Patricia Abascal Fernández
// Version: 1.1 
// Last modification: 01/03/2013 
// Description: Create the empty directories for the model and
//				packages inside them.
////////////////////////////////////////////////////////////
package pluginCreateDirectories;

import java.io.*;
public class CreateDirectory {
	// Creating the empty directory
	public void creation (String nameDirectory){
		File dir = new File(nameDirectory);  
		dir.mkdirs();  
	}  
} 