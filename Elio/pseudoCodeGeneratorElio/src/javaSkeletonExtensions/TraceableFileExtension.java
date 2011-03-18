package javaSkeletonExtensions;
import java.io.*;
import java.util.*;

// Reescribir todo esto para que vaya con IFile


//This class has an internall structure to not generate repited artefacts
public class TraceableFileExtension {
	
	static FileWriter fstream;
	static BufferedWriter out;
	static int id=0;
	//Hashtable that is used internally
	//This is used to store the artifacts that are generated using the name+path as key and storing the id
	//This is done to not generate twice the same element
	static Hashtable <String,Integer> table=new Hashtable <String,Integer>();
	static String path="src-gen/traceability.xml";
	
	//Opens the traceability file
	public static void open(){
		try{
			fstream = new FileWriter("src-gen/traceability.xml");
			out = new BufferedWriter(fstream);
			out.write("<repository>\n");
		}catch(Exception e){
			System.err.println("Error opening traceability file: " + e.getMessage());
		}
	}
	
	public final static void close(){
		try{
			out.write("</repository>");
			out.close();
		}catch(Exception e){
			System.err.println("Error closing traceability file: " + e.getMessage());
		}
	}
	
	//Method to write information about traceability on the file, the params are:
	//sourceType: Metamodel element type for the model element
	//sourceName: Name of the element of the model
	//sourceRoute: Complete route to the model element
	//targetType: CaesarJ type element generated
	//targetName: Name of the element
	public final static void write(String sourceType,String sourceName,String sourceRoute,String targetType,String targetName,String targetRoute){
		try{
			int idSource;
			int idTarget;
			Integer aux;
			
			//Check if the source element has been already stored before
			aux=(Integer)table.get(""+sourceName+sourceRoute);
			if(aux==null){ //The artifact has not been added before
				idSource=generateId(); //generate the new id
				table.put(""+sourceName+sourceRoute,new Integer(idSource)); //Add it to the hashtable
				out.write("<artefact id=\""+Integer.toString(idSource)+"\" ");
				out.write("name=\""+sourceName+"\" ");
				out.write("artefactType=\""+sourceType+"\" ");
				out.write("path=\""+sourceRoute+"\" />\n");
			}else{ //The artifact exists already
				idSource=aux.intValue();
			}
			
			//Check if the target element has been already stored before
			aux=(Integer)table.get(""+targetName+targetRoute);
			if(aux==null){ //The artifact has not been added before
				idTarget=generateId(); //generate the new id
				table.put(""+targetName+targetRoute,new Integer(idTarget)); //Add it to the hashtable
				out.write("<artefact id=\""+Integer.toString(idTarget)+"\" ");
				out.write("name=\""+targetName+"\" ");
				out.write("artefactType=\""+targetType+"\" ");
				out.write("path=\""+targetRoute+"\" />\n");
			}else{ //The artifact exists already
				idTarget=aux.intValue();
			}
			
			//Adding the new link using the id's
			out.write("<link linkType=\"Generated\" source=\"");
			out.write(""+Integer.toString(idSource)+"\" target=\""+Integer.toString(idTarget)+"\"/>\n");
			
			
		}catch(Exception e){
			System.err.println("Error writing traceability file: " + e.getMessage());
		}
	}
	
	public final static void writeErrorConsole(String text){
		System.err.println(text);
	}
	
	public final static void setDestinationFile(String newPath){
		path=newPath;
	}
	
	public static int generateId() {
		id++;
		return id;
	}
}
