package net.ample.wp2.tente.plugin.widgets;

import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;
import org.eclipse.core.resources.IProject;
import org.eclipse.jface.dialogs.Dialog;
import org.eclipse.jface.dialogs.IDialogConstants;
import org.eclipse.swt.SWT;
import org.eclipse.swt.custom.StyleRange;
import org.eclipse.swt.custom.StyledText;
import org.eclipse.swt.events.SelectionEvent;
import org.eclipse.swt.events.SelectionListener;
import org.eclipse.swt.layout.GridData;
import org.eclipse.swt.layout.GridLayout;
import org.eclipse.swt.widgets.Button;
import org.eclipse.swt.widgets.Composite;
import org.eclipse.swt.widgets.Control;
import org.eclipse.swt.widgets.Group;
import org.eclipse.swt.widgets.Label;
import org.eclipse.swt.widgets.Shell;

public class ProjectDialog  extends Dialog implements SelectionListener{


	private final String CONNECT = "Ok";
    private final String CANCEL  = "Cancel";
   
    
    public static final int CONNECT_ID = IDialogConstants.OK_ID;	
	public static final int CANCEL_ID  = IDialogConstants.CANCEL_ID;

	private String title = "Projects";
	private ArrayList<IProject> projectsCJ;
	private List<Button> buttons;

	private int position=0;
	public int getPosition() {
		return position;
	}

	private Composite parent;
	
	private Button	okButton;
	
	
	public ProjectDialog(Shell parent,ArrayList<IProject> projects)
	{
		super(parent);		
		projectsCJ=projects;
		buttons = new ArrayList<Button>();		

	}
	
   // 2nd method called
    protected void configureShell(Shell shell) {
        super.configureShell(shell);
        if (title != null){        	
        		shell.setText(title);
        	}
        	
        shell.setBackgroundMode(SWT.INHERIT_DEFAULT);
      
    }

    /*
     * (non-Javadoc) Method declared on Dialog.
     */
    // 3rd method called
    protected Control createDialogArea(Composite parent)
    {
    	
    	
    	
    	this.parent=parent;
    	GridLayout grid = new GridLayout();
		grid.numColumns = 1;
		
		parent.setLayout(grid);
				
		
		
		for (Iterator<IProject> itProjects=projectsCJ.iterator();itProjects.hasNext();){
			IProject project=itProjects.next();
			addTestCase(project.getName());
		}
		addTestCase("Create a new CeaserJ Project");
	
		


        return null;
    }
    
    
    private void addTestCase(String textoArriba)
	{
		Group testCase = new Group(parent, SWT.NONE);
		testCase.setText("Project CeaserJ");
		
		GridData data = new GridData();
		data.grabExcessHorizontalSpace = true;
		data.horizontalAlignment = SWT.FILL;
		data.horizontalSpan = 3;
		
		GridLayout grid = new GridLayout();
		grid.numColumns = 3;
		testCase.setLayout(grid);
		testCase.setLayoutData(data);
		
		
		
		//Display display = Display.getCurrent();
		//display.getSystemColor(SWT.COLOR_DARK_BLUE);
	//	testCase.setBackground(display.getSystemColor(SWT.COLOR_DARK_BLUE));
		
		Button button = new Button(testCase, SWT.CHECK);
		buttons.add(button);
		button.addSelectionListener(this);
	
		/*
		data = new GridData();
		data.verticalAlignment = SWT.FILL;
		data.horizontalAlignment=SWT.FILL;
		button.setLayoutData(data);
		*/
	

	
		
		data = new GridData();
		data.verticalAlignment = SWT.FILL;
		data.horizontalAlignment=SWT.FILL;
		button.setLayoutData(data);
		
	
		//button.setImage(image);
		
		
		Label label = new Label(testCase, SWT.SEPARATOR);
		
		data = new GridData();
		//data.grabExcessVerticalSpace = true;
		data.verticalAlignment = SWT.FILL;
		label.setLayoutData(data);
		
		Composite texto = new Composite(testCase, SWT.NONE);
		data = new GridData();
		data.grabExcessHorizontalSpace = true;
		data.horizontalAlignment = SWT.FILL;
		data.grabExcessVerticalSpace = true;
		data.verticalAlignment = SWT.FILL;
		grid = new GridLayout();
		grid.numColumns = 1;
		texto.setLayout(grid);
		texto.setLayoutData(data);
		
		//UP		
		StyledText text = new StyledText (texto, SWT.NONE);
		text.setText(textoArriba);		
		int lenght=text.getText().length();
		text.setEditable(false);		
		StyleRange style1 = new StyleRange();
		style1.start = 0;
		style1.length = lenght;
		style1.fontStyle = SWT.BOLD;			
		text.setLineAlignment(0, 1, SWT.CENTER);		
		text.setStyleRange(style1);
		text.setBackground(texto.getBackground());
		
		data = new GridData();
		data.horizontalAlignment = SWT.CENTER;
		data.verticalAlignment = SWT.CENTER;
		data.grabExcessHorizontalSpace = true;
		data.grabExcessVerticalSpace=true;
		text.setLayoutData(data);

		
	
		
	}

    /*
     * (non-Javadoc)
     * 
     * @see
org.eclipse.jface.dialogs.Dialog#createButtonsForButtonBar(org.eclipse.swt.widgets.Composite)
     */
    // 4th method called
    protected void createButtonsForButtonBar(Composite parent) {

        okButton = createButton(parent, CONNECT_ID /*IDialogConstants.OK_ID*/,
                		CONNECT /*IDialogConstants.OK_LABEL*/, true);		
        // Connect button
        okButton.setEnabled(false);
       
        
        //Cancel button
        createButton(parent, CANCEL_ID /*IDialogConstants.CANCEL_ID*/,
                CANCEL /*IDialogConstants.CANCEL_LABEL*/, false);	
    
    }
    

    
    public void widgetSelected(SelectionEvent e)
	{
		if(e.widget instanceof Button){
			Button button=(Button) e.widget;
			
			
			okButton.setEnabled(true);
		
			
			for (int i=0;i<buttons.size();i++){
				buttons.get(i).setSelection(false);
				if (buttons.get(i).equals(button)){
					buttons.get(i).setSelection(true);
					position=i;
					
					
				}
			}
			
			
			
		}
	}

	@Override
	public void widgetDefaultSelected(SelectionEvent e) {
		// TODO Auto-generated method stub
		
	}
	
}
