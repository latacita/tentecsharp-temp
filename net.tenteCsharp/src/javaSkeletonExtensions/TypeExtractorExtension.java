package javaSkeletonExtensions;
import java.util.*;

//This class extracts the type name from a primitive type using the uri of the type
//If the type is String or Integert they are converted to show it correctly
public class TypeExtractorExtension {
	public static String extractType(String input){
		StringTokenizer st = new StringTokenizer(input,"#");
		String aux="";
		while(st.hasMoreTokens()){
			aux=st.nextToken();
		}
		st = new StringTokenizer(aux,")");
		aux=st.nextToken();
		aux=aux.toLowerCase();
		if(aux.equals("string")){
			return "String";
		}else if(aux.equals("integer")){
			return "int";
		}
		return aux;
	}
	
	public static String extractTypePlugin(String input){
		if(input.equals("Integer")){
			return "int";
		}else if(input.equals("Boolean")){
			return "boolean";
		}
		else{ 
			return input;
		}
	}
	
	public final static void writeErrorConsole(String text){
		System.err.println(text);
	}
}
