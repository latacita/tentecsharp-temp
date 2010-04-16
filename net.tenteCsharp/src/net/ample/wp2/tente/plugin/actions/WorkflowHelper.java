//----------------------------------------------------------------------------//
// Author: Pablo Sánchez (pablo@lcc.uma.es)									  //
// Date  : 2009/06/04														  //	 
// Description: A helper class containing methods to easily					  //	 
// trigger an oAW workflow from an Eclipse setting.  						  //
// NOTE: This a modified version of the WorkflowUtil, copied from the project //
//    org.ample.vmlstar.util, authored by Steffen Zschaler					  //
//----------------------------------------------------------------------------//

package net.ample.wp2.tente.plugin.actions;

// Imports from the Java library
import org.eclipse.core.resources.IFile;
import org.eclipse.core.resources.ResourcesPlugin;
import org.eclipse.core.runtime.CoreException;
import org.eclipse.core.runtime.jobs.IJobChangeEvent;
import org.eclipse.core.runtime.jobs.IJobChangeListener;
import org.eclipse.core.runtime.jobs.Job;
import org.eclipse.core.runtime.jobs.JobChangeAdapter;
import org.eclipse.debug.core.DebugPlugin;
import org.eclipse.debug.core.ILaunchConfigurationType;
import org.eclipse.debug.core.ILaunchConfigurationWorkingCopy;
import org.eclipse.debug.ui.DebugUITools;
import org.eclipse.jdt.launching.IJavaLaunchConfigurationConstants;
import org.eclipse.ui.PlatformUI;
import org.openarchitectureware.eclipse.launch.IWfLaunchConfigurationConstants;

public class WorkflowHelper {

	/**
	 * Execute the given workflow. This waits until execution of the workflow
	 * has finished. Unfortunately, I haven't yet figured out how to find out if
	 * the workflow was successful.
	 * 
	 * @param sLaunchName
	 *            a name to be used internally to identify this workflow. Used
	 *            mostly for debugging purposes at the moment.
	 * @param fWorkflow
	 *            an oAW file. Must be in a oAW project in the current
	 *            workspace.
	 * @throws CoreException
	 *             if something goes wrong
	 */
	public static void executeWorkflow(String sLaunchName, IFile fWorkflow)
			throws CoreException {
		/*
		 * Need to do this from a launch configuration rather than invoking
		 * WorkflowRunner directly to make sure that working directories etc.
		 * are set correctly. The attributes set in the launch configuration
		 * below seem to be the minimum required. In particular, we need to set
		 * the java project name to allow the classpath manager to figure out
		 * the correct classpath from the plugin dependencies of the project.
		 * This is necessary so that WorkflowRunner.class will actually be in
		 * that classpath available to be called...
		 */
		ILaunchConfigurationType configType = DebugPlugin
				.getDefault()
				.getLaunchManager()
				.getLaunchConfigurationType(
						IWfLaunchConfigurationConstants.WORKFLOW_LAUNCH_CONFIGURATION_TYPE_ID);
		final ILaunchConfigurationWorkingCopy launchConfig = configType
				.newInstance(null, sLaunchName);
		launchConfig.setAttribute(
				IWfLaunchConfigurationConstants.ATTR_OAW_WORKFLOW_FILE,
				fWorkflow.getFullPath().toString());
		launchConfig.setAttribute(
				IJavaLaunchConfigurationConstants.ATTR_PROJECT_NAME, fWorkflow
						.getProject().getName());

		/*
		 * Wait for build jobs here. For some reason, whenever I am not
		 * debugging this code, DebugUITools run into a NullPointerException
		 * when trying to do the waiting themselves
		 * 
		 * This workaround code was copied from WorkflowLaunchDelegate.launch()
		 * TODO: It still doesn't seem to work always. Maybe this is related to
		 * DebugUITools.launch requesting that it be called from the UI
		 * thread...
		 */
		Job[] autoBuildJobs;
		Job[] manBuildJobs;
		do {
			autoBuildJobs = Job.getJobManager().find(
					ResourcesPlugin.FAMILY_AUTO_BUILD);
			manBuildJobs = Job.getJobManager().find(
					ResourcesPlugin.FAMILY_MANUAL_BUILD);
		} while (autoBuildJobs.length > 0 || manBuildJobs.length > 0);

		// MOVED down to ensure that we will always be able to identify its
		// end...
		// DebugUITools.launch(launchConfig, "run");

		/*
		 * Wait for the triggered jobs to finish. After a number of unsuccessful
		 * tries the hack below seems to work best. Ideally, oAW would place
		 * there refresh job (or all of their jobs for that matter) into a
		 * specific family. Then we could simply join the jobs of that family.
		 * As they don't, we must rely on oAW implementer not changing the name
		 * of the refresh job. 
		 */

		// HACK: Wait for the refresh resources job to finish as this seems to
		// be the last thing happening in a workflow run.
		final boolean fLaunchFinished[] = { false };
		IJobChangeListener listener = new JobChangeAdapter() {
			@Override
			public void done(IJobChangeEvent event) {
				if (event.getJob().getName().equals("refresh resources")) {
					synchronized (this) {
						fLaunchFinished[0] = true;
						this.notify();
					}
				}
			}
		};
		Job.getJobManager().addJobChangeListener(listener);

		/*
		 * We only trigger the launch here so that the listener has already been
		 * installed. This way, even for very quick workflows we should be able
		 * to be informed of the end of the refresh job.
		 * 
		 * Also, we defer to the UI thread to do the launch, as DebugUITools
		 * tells us to...
		 */
		// Display.getDefault()
		PlatformUI.getWorkbench().getDisplay().asyncExec(new Runnable() {
			public void run() {
				DebugUITools.launch(launchConfig, "run");
			}
		});

		synchronized (listener) {
			while (!fLaunchFinished[0]) {
				try {
					listener.wait();
				} catch (InterruptedException e) {
				}
			}
		}
		Job.getJobManager().removeJobChangeListener(listener);
	} 

}