package tenteplugin.actions;

public class WorkflowCreator {

	public static String generateSkeletonWorkflow(String umlPath,String outDirPath,boolean trace){
		String result=new String("");
		result=result+="<?xml version=\"1.0\"?>\n"+
		"<workflow>\n"+"<bean class=\"oaw.uml2.Setup\" standardUML2Setup=\"true\"/>\n"+
		"<component class=\"oaw.emf.XmiReader\">\n"+
		"<modelFile value=\""+umlPath+"\"/>\n"+
		"<outputSlot value=\"model\"/>\n"+
		"</component>\n"+
		"<component id=\"dirCleaner\"\n"+
		"class=\"oaw.workflow.common.DirectoryCleaner\"\n"+
		"directories=\""+outDirPath+"\\src-skeleton-gen"+"\"/>\n"+
		"<component id=\"generator\" class=\"oaw.xpand2.Generator\"\n"+
		"skipOnErrors=\"true\">\n"+
		"<metaModel class=\"oaw.type.emf.EmfMetaModel\">\n"+
		"<metaModelPackage value=\"org.eclipse.emf.ecore.EcorePackage\"/>\n"+
		"</metaModel>\n"+
		"<metaModel class=\"oaw.uml2.UML2MetaModel\"/>\n"+
		"<expand value=\"skeletonTemplates::SkeletonRoot::SkeletonRoot FOR model\"/>\n"+
		"<outlet path=\""+outDirPath+"\\src-skeleton-gen"+"\">\n"+
		"</outlet>\n"+
		"</component>\n";
		if(trace){ //Add the traceability template code
		result=result+="<component adviceTarget=\"generator\"\n"+
		"id=\"reflectionAdvice\"\n"+
		"class=\"oaw.xpand2.GeneratorAdvice\">\n"+
		"<advices value=\"traceability::TraceabilityFile\"/>\n"+
		"</component>\n";
		}
		result=result+"</workflow>";
		return result;
	}
	
	public static String generateApplicationWorkflow(String umlPath,String outDirPath){
		String result=new String("");
		result=result+="<?xml version=\"1.0\"?>\n"+
		"<workflow>\n"+"<bean class=\"oaw.uml2.Setup\" standardUML2Setup=\"true\"/>\n"+
		"<component class=\"oaw.emf.XmiReader\">\n"+
		"<modelFile value=\""+umlPath+"\"/>\n"+
		"<outputSlot value=\"model\"/>\n"+
		"</component>\n"+
		"<component id=\"dirCleaner\"\n"+
		"class=\"oaw.workflow.common.DirectoryCleaner\"\n"+
		"directories=\""+outDirPath+"\\src-application-gen"+"\"/>\n"+
		"<component id=\"generator\" class=\"oaw.xpand2.Generator\"\n"+
		"skipOnErrors=\"true\">\n"+
		"<metaModel class=\"oaw.type.emf.EmfMetaModel\">\n"+
		"<metaModelPackage value=\"org.eclipse.emf.ecore.EcorePackage\"/>\n"+
		"</metaModel>\n"+
		"<metaModel class=\"oaw.uml2.UML2MetaModel\"/>\n"+
		"<expand value=\"applicationTemplates::ApplicationRoot::ApplicationRoot FOR model\"/>\n"+
		"<outlet path=\""+outDirPath+"\\src-application-gen"+"\">\n"+
		"</outlet>\n"+
		"</component>\n"+
		"</workflow>\n";
		return result;
	}
}
