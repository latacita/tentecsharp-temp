////////////////////////////////////////////////////////////
//
// Author: Patricia Abascal Fernández
// Version: 1.2
// Last modification: 26/04/2013 
// Description: Manipulates files
////////////////////////////////////////////////////////////
package pluginWriteInFile;

import java.io.BufferedWriter;
import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
/**
 * Class which manipulates files 
 * @author Patricia
 *
 */
public class WriteInFile {
	// Write message in a file
	public void writeInFile(String path, String message){
		try {
			
			File file = new File(path);
 
			// If file doesn't exists, then create it
			if (!file.exists()) {
				file.createNewFile();
			}
 
			FileWriter fw = new FileWriter(file.getAbsoluteFile(), true);
			BufferedWriter bw = new BufferedWriter(fw);
			bw.write(message);
			bw.close(); 
 
		} catch (IOException e) {
			e.printStackTrace();
		}
	}
	// Delete a file
	public void deleteFile(String path, String name){
		File file = new File(path+"\\"+name);
		file.delete();
	}
	// Checks if a file exists
	public boolean fileExists(String path){
		boolean exists;
		File file = new File(path);
		// If file doesn't exists, then create it
		if (file.exists()) {
			exists=true;
		}else{
			exists=false;
		}
		return exists;
	}
}
