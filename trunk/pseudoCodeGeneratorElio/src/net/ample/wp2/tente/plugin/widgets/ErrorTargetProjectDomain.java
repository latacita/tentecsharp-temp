package net.ample.wp2.tente.plugin.widgets;

import org.eclipse.jface.dialogs.IDialogConstants;
import org.eclipse.jface.dialogs.IconAndMessageDialog;
import org.eclipse.swt.SWT;
import org.eclipse.swt.graphics.Image;
import org.eclipse.swt.layout.FillLayout;
import org.eclipse.swt.layout.GridData;
import org.eclipse.swt.widgets.Composite;
import org.eclipse.swt.widgets.Control;
import org.eclipse.swt.widgets.Shell;
import org.eclipse.ui.PlatformUI;



public class ErrorTargetProjectDomain extends IconAndMessageDialog {



	  // The image
	  private Image image;
	  private String helpPage=null;
	

	  /**
	   * DumbMessageDialog constructor
	   * 
	   * @param parent the parent shell
	   */
	  public ErrorTargetProjectDomain(Shell parent,String message,String helpPage) {
	    super(parent);
	   
	    //message;
	    this.message=message;
	    image=this.getErrorImage();
	    this.helpPage=helpPage;
	    
	 
	    	
	  }

	  
	  protected void configureShell(Shell shell){
		  super.configureShell(shell);
		  shell.setText("ERROR");
		  //shell.setImage(image); New image in the dialog
		  
	  }
	  /**
	   * Sets the message
	   * 
	   * @param message the message
	   */
	  public void setMessage(String message) {
	    this.message = message;
	  }

	  /**
	   * Closes the dialog
	   * 
	   * @return boolean
	   */
	  public boolean close() {
	    //if (image != null) image.dispose();
	    return super.close();
	  }

	  /**
	   * Creates the dialog area
	   * 
	   * @param parent the parent composite
	   * @return Control
	   */
	  protected Control createDialogArea(Composite parent) {
		  
		  
	    createMessageArea(parent);

	    // Create a composite to hold the label
	    Composite composite = new Composite(parent, SWT.NONE);
	    GridData data = new GridData(GridData.FILL_BOTH);
	    data.horizontalSpan = 2;
	    composite.setLayoutData(data);
	    composite.setLayout(new FillLayout());


	    return composite;
	  }

	  /**
	   * Creates the buttons
	   * 
	   * @param parent the parent composite
	   */
	  protected void createButtonsForButtonBar(Composite parent) {
	    createButton(parent, IDialogConstants.HELP_ID, "Help", true);
	    createButton(parent, IDialogConstants.CLOSE_ID, IDialogConstants.CANCEL_LABEL, false);
	
	  }

	  /**
	   * Handles a button press
	   * 
	   * @param buttonId the ID of the pressed button
	   */
	  protected void buttonPressed(int buttonId) {

		  if (buttonId == IDialogConstants.HELP_ID) {
			  PlatformUI.getWorkbench().getHelpSystem().displayHelpResource(helpPage);
			  close();
		  } else {
			  close();
		  }
	  }

	  /**
	   * Gets the image to use
	   */
	  protected Image getImage() {
	    return image;
	  }

}
