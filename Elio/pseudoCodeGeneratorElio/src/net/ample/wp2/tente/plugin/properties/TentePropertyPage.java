package net.ample.wp2.tente.plugin.properties;

import org.eclipse.core.resources.IProject;
import org.eclipse.core.resources.IResource;
import org.eclipse.core.runtime.CoreException;
import org.eclipse.core.runtime.IAdaptable;
import org.eclipse.core.runtime.IPath;
import org.eclipse.core.runtime.QualifiedName;
import org.eclipse.swt.SWT;
import org.eclipse.swt.layout.GridData;
import org.eclipse.swt.layout.GridLayout;
import org.eclipse.swt.widgets.Button;
import org.eclipse.swt.widgets.Composite;
import org.eclipse.swt.widgets.Control;
import org.eclipse.swt.widgets.DirectoryDialog;
import org.eclipse.swt.widgets.Event;
import org.eclipse.swt.widgets.Group;
import org.eclipse.swt.widgets.Label;
import org.eclipse.swt.widgets.Listener;
import org.eclipse.swt.widgets.Shell;
import org.eclipse.swt.widgets.Text;
import org.eclipse.ui.dialogs.PropertyPage;

public class TentePropertyPage extends PropertyPage {

	private static final String TEXT_TRACEABILITY 		   = "Traceability enabled";
	private static final String TEXT_DOMAIN_TARGET 		   = "Target Project";
	private static final String TEXT_APPLICATION_TARGET    = "Target Project";
	private static final String TEXT_APPLICATION_REFERENCE = "Reference implementation";
	private static final String TEXT_REPOSITORY 		   = "ATF Repository";
	
	
	public static final String TRACEABILITY_ENABLED          = "TRACEABILITY_ENABLED";
	public static final String DOMAIN_TARGET_PROJECT         = "DOMAIN_TARGET_PROJECT";
	public static final String APPLICATION_TARGET_PROJECT    = "APPLICATION_TARGET_PROJECT";
	public static final String APPLICATION_REFERENCE_PROJECT = "APPLICATION_REFERENCE_PROJECT";
	public static final String DEFAULT_TRACEABILITY          = "FALSE";
	public static final String REPOSITORY          			 = "REPOSITORY";
	
	
	private static final String DEFAULT_OWNER = "";

	private static final int TEXT_FIELD_WIDTH = 50;

	private Text domainTargetProject;
	private Text applicationTargetProject;
	private Text applicationReferenceProject;
	private String traceabilityEnabled="FALSE";
	private Text repository;
	

	/**
	 * Constructor for SamplePropertyPage.
	 */
	public TentePropertyPage() {
		super();
	}

	private void addFirstSection(Composite parent) {
		Composite composite = createDefaultComposite(parent);

		final Button button=new Button(composite,SWT.CHECK);
		
		
		
//		button.setText("Target");
		GridData data=new GridData();
		button.setLayoutData(data);
		button.addListener(SWT.Selection, new Listener(){
			@Override
			public void handleEvent(Event event) {
				
				if (button.getSelection()){
					traceabilityEnabled="TRUE";
				}
				else{
					traceabilityEnabled="FALSE";
				}
				
			}
			
		});
		
		//Label for path field
		Label pathLabel = new Label(composite, SWT.NONE);
		pathLabel.setText(TEXT_TRACEABILITY);

		// Path text field
		//Text pathValueText = new Text(composite, SWT.WRAP | SWT.READ_ONLY);
		//pathValueText.setText(((IResource) getElement()).getFullPath().toString());
		
		
		// Populate owner text field
		try {
			String owner =((IResource) getElement()).getPersistentProperty(
					new QualifiedName("", TRACEABILITY_ENABLED));
			
			//traceabilityEnabled.setText((owner != null) ? owner : DEFAULT_TRACEABILITY);
			if (owner==null){
				//button.setEnabled(false);
				button.setSelection(false);
			}
			else{
				if (owner.equals("TRUE")){
					button.setSelection(true);
				}
				else{
					button.setSelection(false);
				}
			}
			
			
		} catch (CoreException e) {
			//traceabilityEnabled.setText(DEFAULT_TRACEABILITY);
			button.setSelection(false);
		}
		
	}

	private void addSeparator(Composite parent) {
		Label separator = new Label(parent, SWT.SEPARATOR | SWT.HORIZONTAL);
		GridData gridData = new GridData();
		gridData.horizontalAlignment = GridData.FILL;
		gridData.grabExcessHorizontalSpace = true;
		separator.setLayoutData(gridData);
	}

	private void addSecondSection(Composite parent) {
		//Composite composite = createDefaultComposite(parent);

		GridLayout layout=new GridLayout();
		layout.numColumns=3;
		
		
		GridData data = new GridData();
		data.grabExcessHorizontalSpace = true;
		data.horizontalAlignment = SWT.FILL;
		data.horizontalSpan = 3;
	   

		Group group=new Group(parent,SWT.NONE);
		group.setText("Domain Engineering");
		group.setLayoutData(data);
		group.setLayout(layout);
		
		
	
		// Label for owner field
		Label ownerLabel = new Label(group, SWT.NONE);
		ownerLabel.setText(TEXT_DOMAIN_TARGET);
		data=new GridData();
		ownerLabel.setLayoutData(data);
		

		// Owner text field
		domainTargetProject = new Text(group, SWT.SINGLE | SWT.BORDER);
		GridData gd = new GridData();
		gd.widthHint = convertWidthInCharsToPixels(TEXT_FIELD_WIDTH);		
		gd.grabExcessHorizontalSpace=true;		
		gd.horizontalAlignment=SWT.FILL;
		domainTargetProject.setLayoutData(gd);
		domainTargetProject.setEditable(false);
		
		
		
		Button button=new Button(group,SWT.PUSH);
		button.setText("Browse");
		data=new GridData();
		button.setLayoutData(data);
		button.addListener(SWT.Selection, new Listener(){

			@Override
			public void handleEvent(Event event) {
				DirectoryDialog dialog=new DirectoryDialog(new Shell());
				dialog.setMessage("Select a CaesarJ project");
				
				IAdaptable element=getElement();
				IProject p=(IProject)element;
				IPath p2=p.getLocation();
			
			
				dialog.setFilterPath(p2.toString());
				
				String stringDirectory=dialog.open();
				if (stringDirectory!=null){
					domainTargetProject.setText(stringDirectory);
				}
				
				
			}
			
		});
		
		
		// Populate owner text field
		try {
			String owner =((IResource) getElement()).getPersistentProperty(
					new QualifiedName("", DOMAIN_TARGET_PROJECT));
			
			domainTargetProject.setText((owner != null) ? owner : DEFAULT_OWNER);
			
		} catch (CoreException e) {
			domainTargetProject.setText(DEFAULT_OWNER);
		}
	}

	private void addThirdSection(Composite parent) {
		//Composite composite = createDefaultComposite(parent);

		GridLayout layout=new GridLayout();
		layout.numColumns=3;
		
		
		GridData data = new GridData();
		data.grabExcessHorizontalSpace = true;
		data.horizontalAlignment = SWT.FILL;
		data.horizontalSpan = 3;
	   

		Group group=new Group(parent,SWT.NONE);
		group.setText("Application Engineering");
		group.setLayoutData(data);
		group.setLayout(layout);
		
		
	
		// Label for owner field
		Label ownerLabel = new Label(group, SWT.NONE);
		ownerLabel.setText(TEXT_APPLICATION_REFERENCE);
		data=new GridData();
		ownerLabel.setLayoutData(data);
		

		// Owner text field
		applicationReferenceProject = new Text(group, SWT.SINGLE | SWT.BORDER);
		GridData gd = new GridData();
		gd.widthHint = convertWidthInCharsToPixels(TEXT_FIELD_WIDTH);		
		gd.grabExcessHorizontalSpace=true;		
		gd.horizontalAlignment=SWT.FILL;
		applicationReferenceProject.setLayoutData(gd);
		applicationReferenceProject.setEditable(false);
		
		
		
		Button button=new Button(group,SWT.PUSH);
		button.setText("Browse");
		data=new GridData();
		button.setLayoutData(data);
		button.addListener(SWT.Selection, new Listener(){

			@Override
			public void handleEvent(Event event) {
				DirectoryDialog dialog=new DirectoryDialog(new Shell());
				dialog.setMessage("Select a CaesarJ project");
				
				IAdaptable element=getElement();
				IProject p=(IProject)element;
				IPath p2=p.getLocation();
			
			
				dialog.setFilterPath(p2.toString());
				
				String stringDirectory=dialog.open();
				if (stringDirectory!=null){
					applicationReferenceProject.setText(stringDirectory);
				}
				
				
			}
			
		});
		
		
		// Label for owner field
		Label ownerLabel2 = new Label(group, SWT.NONE);
		ownerLabel2.setText(TEXT_APPLICATION_TARGET);
		data=new GridData();
		ownerLabel2.setLayoutData(data);
		
		// Owner text field
		applicationTargetProject = new Text(group, SWT.SINGLE | SWT.BORDER);
		GridData gd2 = new GridData();
		gd2.widthHint = convertWidthInCharsToPixels(TEXT_FIELD_WIDTH);		
		gd2.grabExcessHorizontalSpace=true;		
		gd2.horizontalAlignment=SWT.FILL;
		applicationTargetProject.setLayoutData(gd);
		applicationTargetProject.setEditable(false);
		
		
		
		
		
		
		Button button2=new Button(group,SWT.PUSH);
		button2.setText("Browse");
		data=new GridData();
		button2.setLayoutData(data);
		button2.addListener(SWT.Selection, new Listener(){

			@Override
			public void handleEvent(Event event) {
				DirectoryDialog dialog=new DirectoryDialog(new Shell());
				dialog.setMessage("Select a CaesarJ project");
				
				IAdaptable element=getElement();
				IProject p=(IProject)element;
				IPath p2=p.getLocation();
			
			
				dialog.setFilterPath(p2.toString());
				
				String stringDirectory=dialog.open();
				if (stringDirectory!=null){
					applicationTargetProject.setText(stringDirectory);
				}
				
				
			}
			
		});
		
	
		
		// Populate owner text field
		try {
			String owner =
				((IResource) getElement()).getPersistentProperty(
					new QualifiedName("", APPLICATION_REFERENCE_PROJECT));
			applicationReferenceProject.setText((owner != null) ? owner : DEFAULT_OWNER);
				
			
			
		} catch (CoreException e) {
			applicationReferenceProject.setText(DEFAULT_OWNER);
						
		}
		
		
		
		try {
			String owner2 =
				((IResource) getElement()).getPersistentProperty(
					new QualifiedName("", APPLICATION_TARGET_PROJECT));
			applicationTargetProject.setText(((owner2 != null) ? owner2 : DEFAULT_OWNER));
				
			
			
		} catch (CoreException e) {
			applicationTargetProject.setText(DEFAULT_OWNER);
						
		}
		
		
	}
	
	private void addFourthSection(Composite parent) {
		Composite composite = createDefaultComposite(parent);

		
		//Label for path field
		Label pathLabel = new Label(composite, SWT.NONE);
		pathLabel.setText(TEXT_REPOSITORY);

		// Path text field
		repository = new Text(composite, SWT.BORDER|SWT.SIMPLE);
		GridData gd2 = new GridData();
		gd2.widthHint = convertWidthInCharsToPixels(TEXT_FIELD_WIDTH);		
		gd2.grabExcessHorizontalSpace=true;		
		gd2.horizontalAlignment=SWT.FILL;
		repository.setLayoutData(gd2);
		
		//pathValueText.setText(((IResource) getElement()).getFullPath().toString());
		
		
		// Populate owner text field
		try {
			String owner =
				((IResource) getElement()).getPersistentProperty(
					new QualifiedName("", REPOSITORY));
			repository.setText((owner != null) ? owner : DEFAULT_OWNER);
			
			// Path text field
			//repository = new Text(composite, SWT.BORDER);
			//repository.setText(((IResource) getElement()).getFullPath().toString());
			
		} catch (CoreException e) {
			repository.setText(REPOSITORY);
			
		}
		
	}
	
	
	
	/**
	 * @see PreferencePage#createContents(Composite)
	 */
	protected Control createContents(Composite parent) {
		Composite composite = new Composite(parent, SWT.NONE);
		GridLayout layout = new GridLayout();
		composite.setLayout(layout);
		GridData data = new GridData(GridData.FILL);
		data.grabExcessHorizontalSpace = true;
		composite.setLayoutData(data);

		addFirstSection(composite);
		addSeparator(composite);
		addSecondSection(composite);
		addThirdSection(composite);
		addSeparator(composite);
		addFourthSection(composite);
		return composite;
	}

	private Composite createDefaultComposite(Composite parent) {
		Composite composite = new Composite(parent, SWT.NULL);
		GridLayout layout = new GridLayout();
		layout.numColumns = 2;
		composite.setLayout(layout);

		GridData data = new GridData();
		data.verticalAlignment = GridData.FILL;
		data.horizontalAlignment = GridData.FILL;
		composite.setLayoutData(data);

		return composite;
	}

	protected void performDefaults() {
		// Populate the owner text field with the default value
		domainTargetProject.setText(DEFAULT_OWNER);
		applicationReferenceProject.setText(DEFAULT_OWNER);
		applicationTargetProject.setText(DEFAULT_OWNER);
		traceabilityEnabled="FALSE";
		repository.setText(DEFAULT_OWNER);
	}
	
	public boolean performOk() {
		// store the value in the owner text field
		try {
			((IResource) getElement()).setPersistentProperty(
				new QualifiedName("", DOMAIN_TARGET_PROJECT),
				domainTargetProject.getText());
				
			
			((IResource) getElement()).setPersistentProperty(
					new QualifiedName("", APPLICATION_REFERENCE_PROJECT),
					applicationReferenceProject.getText());
			
			((IResource) getElement()).setPersistentProperty(
					new QualifiedName("", APPLICATION_TARGET_PROJECT),
					applicationTargetProject.getText());
					
			((IResource) getElement()).setPersistentProperty(
					new QualifiedName("", TRACEABILITY_ENABLED),
					traceabilityEnabled);
			
			((IResource) getElement()).setPersistentProperty(
					new QualifiedName("", REPOSITORY),
					repository.getText());
			
			
		} catch (CoreException e) {
			return false;
		}
		return true;
	}

}