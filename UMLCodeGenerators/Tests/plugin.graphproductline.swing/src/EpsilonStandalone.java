import java.io.File;
import java.io.IOException;
import java.net.MalformedURLException;
import java.net.URI;
import java.net.URISyntaxException; 
import java.util.List;

import org.eclipse.core.runtime.FileLocator;
import org.eclipse.epsilon.common.parse.problem.ParseProblem;
import org.eclipse.epsilon.common.util.StringProperties;
import org.eclipse.epsilon.emc.uml.UmlModel; 
import org.eclipse.epsilon.eol.IEolExecutableModule;
import org.eclipse.epsilon.eol.dt.ExtensionPointToolNativeTypeDelegate;
import org.eclipse.epsilon.eol.exceptions.EolRuntimeException;
import org.eclipse.epsilon.eol.exceptions.models.EolModelLoadingException; 
import org.eclipse.epsilon.eol.models.IModel; 

public abstract class EpsilonStandalone {
	
	protected IEolExecutableModule module;
	
	protected Object result;
	
	public abstract IEolExecutableModule createModule();
	
	public abstract String getSource() throws Exception;
	
	public abstract List<IModel> getModels() throws Exception;
	
	public void postProcess() {};
	
	public void preProcess() {};
	
	public void execute() throws Exception { 
		module = createModule(); 
		module.getContext().getNativeTypeDelegates().add(new ExtensionPointToolNativeTypeDelegate());
		module.parse(getFile(getSource()));
		
		if (module.getParseProblems().size() > 0) {
			System.err.println("Parse errors occured...");
			for (ParseProblem problem : module.getParseProblems()) {
				System.err.println(problem.toString());
			}
			System.exit(-1);
		}
		
		for (IModel model : getModels()) {
			module.getContext().getModelRepository().addModel(model);
		}
		
		preProcess();
		result = execute(module);
		postProcess(); 
		module.getContext().getModelRepository().dispose();
	}
	
	protected Object execute(IEolExecutableModule module) 
			throws EolRuntimeException {
		return module.execute();
	} 

	protected UmlModel createUmlModelByURI(String name, String model, 
			String metamodel, boolean readOnLoad, boolean storeOnDisposal) 
					throws EolModelLoadingException, URISyntaxException {
		UmlModel umlModel = new UmlModel();
		StringProperties properties = new StringProperties();
		properties.put(UmlModel.PROPERTY_NAME, name);
		properties.put(UmlModel.PROPERTY_METAMODEL_URI, metamodel); 
		properties.put(UmlModel.PROPERTY_MODEL_URI, "file:/" + model);
		properties.put(UmlModel.PROPERTY_READONLOAD, readOnLoad + "");
		properties.put(UmlModel.PROPERTY_STOREONDISPOSAL, storeOnDisposal + "");
		umlModel.load(properties, null);
		return umlModel;
	}
	
	protected File getFile(String fileName) throws URISyntaxException, MalformedURLException, IOException { 
		URI binUri = EpsilonStandalone.class.getResource(fileName).toURI();
		URI uri = null;	
		if (binUri.toString().indexOf("bin") > -1) {
			uri = new URI(binUri.toString().replaceAll("bin", "src")); 
		}
		else { 
			uri = FileLocator.resolve(binUri.toURL()).toURI();
		} 
		return new File(uri);
	}
	
}

