import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.io.LineNumberReader;
import java.io.PrintWriter;
 
public class UMLAdaptador {
	
	private LineNumberReader numberOfLines;
	 
	/**
	 * This method adapts the UML MagicDraw model to be able to reproduce it in the code generation
	 * @param in - File including the uml model
	 * @param name - name of the file
	 * @throws IOException
	 */
	public String replace(File in, String name) throws IOException {  
			File out= new File(in.getParentFile()+"\\"+name);
		    BufferedReader reader = new BufferedReader(new FileReader(in));
		    PrintWriter writer = new PrintWriter(new FileWriter(out));
		    String line = null;
		    int i=1;
		    numberOfLines = new LineNumberReader(new FileReader(in));
		    numberOfLines.skip(Long.MAX_VALUE);
		    int lineToDelete=numberOfLines.getLineNumber()-1;
		    while ((line = reader.readLine()) != null) {
		    	// Deletes the penultimate line from the UML which is a MagicDrawProfile declaration
		    	if(i!=lineToDelete){ 
		    		// Deletes the xmlns:MagicDrawProfile declaration
		    		if(line.contains("xmlns:MagicDrawProfile")){ 
		    			String[] l=line.split("\\s+");
		    			String finalLine="";
		    			for (int ii=0; ii<l.length; ii++){
		    				if (!l[ii].contains("xmlns:MagicDrawProfile")){
		    					// Modifies the UML version
		    					
		    					if (l[ii].contains("3.0.0/UML")){ 
		    						l[ii]=l[ii].replaceAll("3.0.0/UML","4.0.0/UML");
		    					}
		    					finalLine=finalLine+" "+l[ii];  
		    				} 
		    			}
		    			writer.println(finalLine);
		    		}else{
		    			writer.println(line);
		    		}
		    		i++;
		    	}else{
		    		if(!line.contains("MagicDrawProfile")){ 
		    			writer.println(line);
		    		} 
		    	}
			}
		    
		    reader.close();
		    writer.close(); 
		    return out.getAbsolutePath();
		} 
}