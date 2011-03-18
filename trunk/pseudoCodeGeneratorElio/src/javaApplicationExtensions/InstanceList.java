package javaApplicationExtensions;
import java.util.*;

//This is an auxiliar class to retrieve the information of all the instances in a list
public class InstanceList {

	public ArrayList <Node> list;
	public String initString;
	
	public InstanceList(){
		list=new ArrayList <Node>();
		initString=new String();
	}
	
	public void addElement(String name, String type, String parent){
		list.add(new Node(name,type,parent));
	}
	
	//Method that creates the inicialization string with all the new lines and getInstance lines
	//based on the instance list that has been created previously
	public String createInitString(){
		for(int i=0;i<list.size();i++){
			createInitString(list.get(i));
		}
		return initString;
	}
	
	public void createInitString(Node node){
		//The node has not been created yet
		if(node.created==false){
			if(node.parent==null){//If it has no parent it could be created directly
				node.created=true;
				initString=initString+"		"+node.name+"=new "+node.type+"(\""+node.name+"\");\n";
			}else{//It is necessary to create the parent first
				createParent(node.parent);
				node.created=true;
				initString=initString+"		"+node.name+"="+node.parent+".get"+node.type+"Instance();\n";
			}
		}
	}
	
	//Method used to create a parent node
	public void createParent(String parent){
		//First check if the parent has been created already
		Node aux=searchNode(parent);
		if(aux.created==false){//If the parent has not been created
			//The parent could have another parent or not
			if(aux.parent!=null){//The node has another parent, it has to be created first
				createParent(aux.parent);
				aux.created=true;
				initString=initString+aux.name+"="+aux.parent+".get"+aux.type+"Instance();\n";
			}else{//The node has no parent, it could be created directly
				aux.created=true;
				initString=initString+aux.name+"=new "+aux.type+"(\""+aux.name+"\");\n";
			}
		}
	}
	
	public Node searchNode(String name){
		Node aux;
		for(int i=0;i<list.size();i++){
			aux=list.get(i);
			if(aux.name.equals(name)){
				return aux;
			}
		}
		return null;
	}
	
	public class Node{
		public String name;
		public String type;
		public String parent;
		public boolean created;
		
		public Node(String name, String type,String parent){
			this.name=name;
			this.type=type;
			this.parent=parent;
			this.created=false;
		}
	}
}
