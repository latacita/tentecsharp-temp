package javaApplicationExtensions;
import java.util.*;

//This class has an internall structure to not generate repited artefacts
public class Extensions {
	
	public static InstanceList instanceList=new InstanceList();
	
	
	public static String convertQualifiedName(String fullName){
		StringTokenizer st = new StringTokenizer(fullName,"::");
		st.nextToken();
		st.nextToken();
		st.nextToken();
		String result=new String("");
		while(st.hasMoreTokens()){
			result=result+st.nextToken();
			if(st.hasMoreTokens()){
				result=result+".";
			}
		}
		return result;
	}
	
	//Add a new element to the instance list
	public static void addInstanceElement(String name, String type, String parent){
		instanceList.addElement(name, type, parent);
	}
	
	//Get the instantation String for all the instances
	public static String getInstantationSentence(){
		return instanceList.createInitString();
	}
	
	public static void printConsole(String text){
		System.out.println(text);
	}
}