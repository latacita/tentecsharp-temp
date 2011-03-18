package net.ample.wp2.tente.plugin.actions;

import java.io.FileOutputStream;
import java.io.IOException;
import java.io.StringBufferInputStream;
import java.util.ArrayList;
import java.util.List;
import java.util.jar.Manifest;

import net.ample.wp2.tente.plugin.actions.PluginHelper.PluginDescriptor;

import org.eclipse.core.resources.ICommand;
import org.eclipse.core.resources.IFile;
import org.eclipse.core.resources.IFolder;
import org.eclipse.core.resources.IProject;
import org.eclipse.core.resources.IProjectDescription;
import org.eclipse.core.resources.ResourcesPlugin;
import org.eclipse.core.runtime.CoreException;
import org.eclipse.core.runtime.IPath;
import org.eclipse.core.runtime.IProgressMonitor;
import org.eclipse.core.runtime.Path;
import org.eclipse.core.runtime.SubMonitor;
import org.eclipse.core.runtime.SubProgressMonitor;
import org.eclipse.core.runtime.jobs.Job;
import org.eclipse.jdt.core.IClasspathEntry;
import org.eclipse.jdt.core.IJavaProject;
import org.eclipse.jdt.core.JavaCore;
import org.eclipse.jdt.core.JavaModelException;
import org.eclipse.jface.dialogs.MessageDialog;
import org.eclipse.swt.widgets.Display;
import org.eclipse.swt.widgets.Shell;
import org.openarchitectureware.core.builder.OawBuilder;
import org.openarchitectureware.core.builder.OawNature;
import org.osgi.framework.BundleException;

public class DependencyHelper {

	// Private constants definition
	public final static int SOURCE  = 0;
	public final static int LIBRARY = 1;
	public final static int PROJECT = 2; 

	/* It ensures that all the constraints are required for running successfully the workflow
	 * for generating the code skeletons are satisfied. If not, they are enforced.
	 * 
	 * These constraints are:
	 * 		(1) The project must be a plug-in project.
	 * 		(2) The project must be a Java project 
	 * 		(3) The project must have the following dependencies:
	 * 			- org.openarchitectureware.dependencies
	 * 			- org.openarchitectureware.uml2.adapter
	 * 			- org.openarchitectureware.uml2.adapter.plugin
	 * 			- net.ample.wp2.tente.plugin       
	 * 
	 * @ project
	 * @ shell
	 * @ monitor 
	 * 
	 * */
	public static void  ensureProjectSettingIsOk(final IProject project, IProgressMonitor monitor, IFolder folder) 
		throws CoreException {
		
		try {
			// Check that the project has the proper natures and builders 
			checkNatures(project,monitor);
			// Check that the MANIFEST exist and it is right
			checkManisfest(project,monitor);
			// Check that all the required plugins are included in the dependencies
			checkDependencies(project, monitor);
			// Check that the required  
			checkFolder(project, monitor, project.getFolder("/src-gen"));
			checkFolder(project, monitor, folder);
			// Check that the build.properties exist and it is right
			checkBuild(project,monitor);
		} catch (Exception exception) {
			exception.printStackTrace();
		} finally {
			monitor.done();
		} // try 
	} // ensureProjectSettingIsOk

	// This method basically check that the project is a plugin project and a Java project.
	// If no, it add the corresponding natures, builders and libraries
	private static void checkNatures(final IProject project, IProgressMonitor monitor) throws CoreException {
		
		// Get a description of the project
		IProjectDescription projectDescription = project.getDescription();
		
		// Check that the project is a Java project 
		if (addNature(projectDescription,JavaCore.NATURE_ID)) {
			// if the nature has been added, add also the nature
			setBuilder(projectDescription,JavaCore.BUILDER_ID);
			// We need to record the Java nature before proceeding
			project.setDescription(projectDescription, new SubProgressMonitor(monitor, 1));
			addEntryToClasspath(project, monitor, new Path("org.eclipse.jdt.launching.JRE_CONTAINER/org.eclipse.jdt.internal.debug.ui.launcher.StandardVMType/JavaSE-1.6"),LIBRARY);
		} //if 
		
		// and a plug-in project
		if (addNature(projectDescription,"org.eclipse.pde.PluginNature")) {
			setBuilder(projectDescription,"org.eclipse.pde.ManifestBuilder");
			setBuilder(projectDescription,"org.eclipse.pde.SchemaBuilder");
			addEntryToClasspath(project, monitor, new Path("org.eclipse.pde.core.requiredPlugins"),	LIBRARY);
		} // if

		// Save the project description
		project.setDescription(projectDescription, new SubProgressMonitor(monitor, 1));

	} //checkNatures
	
	/*
	 *  Checks if a nature has been already set to a project. If so, returns false. Otherwise, the nature is 
	 *  added and it returns false
	 *  
	 *  @project The Eclipse project
	 *  @nature  the nature to be checked
	 */
	private static boolean addNature(IProjectDescription project, String nature) {

		boolean result = false; 
		
		// Has the project the proper nature ?   
		if (!project.hasNature(nature)) {
			// If no, then set it
			int length = project.getNatureIds().length;
			String[] newNatures = new String[length+1];
			System.arraycopy(project.getNatureIds(), 0, newNatures, 0, length);
			newNatures[length] = nature;
			project.setNatureIds(newNatures);
			result = true;
		} else {
			result = false;
		} //if
		return result;
	} // addNature
	
	private static void setBuilder(IProjectDescription project, String builder) {

		int length =  project.getBuildSpec().length;
		ICommand[] newBuilders = new ICommand[length+1];
		System.arraycopy(project.getBuildSpec(), 0, newBuilders, 0, length);
		newBuilders[length] = project.newCommand();
		newBuilders[length].setBuilderName(builder);
		project.setBuildSpec(newBuilders);
	} // setBuilder
	
	private static void checkManisfest(IProject project, IProgressMonitor monitor) throws CoreException {
		// check that the manifest has the right dependencies
		IFile manifest = project.getFile("META-INF/MANIFEST.MF");
		if (!manifest.exists()) {
			// If the MANIFEST does not exists, then create it  
			createManifest(project.getName(), monitor, project);
		} //file
		
	} // chackManifest
	
	@SuppressWarnings("deprecation")
	private static void createManifest(String projectName, IProgressMonitor monitor, IProject project)
	throws CoreException {
		final StringBuilder maniContent = new StringBuilder("Manifest-Version: 1.0\n");
		maniContent.append("Bundle-ManifestVersion: 2\n");
		maniContent.append("Bundle-Name: " + projectName + "\n");
		maniContent.append("Bundle-SymbolicName: " + projectName + "; singleton:=true\n");
		maniContent.append("Bundle-Version: 1.0.0\n");
		maniContent.append("Bundle-RequiredExecutionEnvironment: JavaSE-1.6\r\n");

		final IFolder metaInf = project.getFolder("META-INF");
		metaInf.create(false, true, new SubProgressMonitor(monitor, 1));
		IFile manifest = metaInf.getFile("MANIFEST.MF");
		manifest.create(new StringBufferInputStream(maniContent.toString()), true, new SubProgressMonitor(monitor, 1));
	}
	
	@SuppressWarnings("deprecation")
	private static void checkBuild(IProject project, IProgressMonitor monitor) throws CoreException {
		IFile buildFile = project.getFile("build.properties");
		if (!buildFile.exists()) {
			final StringBuilder maniContent = new StringBuilder("source.. = src/\n");
			maniContent.append("bin.includes = META-INF/,\\\n");
			maniContent.append("\t.,\\\n");
			maniContent.append("src/\n");

			buildFile.create(new StringBufferInputStream(maniContent.toString()), true, new SubProgressMonitor(monitor, 1));
		} //if
	}
	
	private static boolean isInClasspath(IClasspathEntry[] classpathEntries, IPath entry) {
		
		int i = 0;
		while ((i<classpathEntries.length) && (!classpathEntries[i].getPath().equals(entry))) {
			System.out.println(entry.toString() + " is already in the classpath");
			i++;
		} //while
		
		return !(i == classpathEntries.length); 
	} // 
	
	public static void addEntryToClasspath (IProject project, IProgressMonitor monitor, IPath entry, int kind) throws JavaModelException {
	
		// Fix up class path and source folders
		IJavaProject javaProject = JavaCore.create(project);
		IClasspathEntry[] newClasspath;
		int length;
		
		if (!isInClasspath(javaProject.getRawClasspath(),entry)) {
			System.out.println("Añadiendo su puta madre = " + entry.toString());
			if (javaProject.getRawClasspath() == null) {
				length = 0;
			} else {
				length = javaProject.getRawClasspath().length;
			} // if
			newClasspath = new IClasspathEntry[length+1];
			System.arraycopy(javaProject.getRawClasspath(), 0, newClasspath, 0, length);
			if (kind == SOURCE) {
				newClasspath[length] = JavaCore.newSourceEntry(entry);
			} else if (kind == LIBRARY) {
				newClasspath[length] = JavaCore.newContainerEntry(entry);
			} else if (kind == PROJECT) {
				newClasspath[length] = JavaCore.newProjectEntry(entry);
			} // if	
			javaProject.setRawClasspath(newClasspath,new SubProgressMonitor(monitor, 1));
		} // if
	} // addEntryToClasspath
	
	private static int isRootOnClasspath(IProject project) throws JavaModelException {
		
		IJavaProject javaProject = JavaCore.create(project);
		IClasspathEntry currentClasspath [] = javaProject.getRawClasspath();
		
		// This is the entry we need to remove
		IClasspathEntry badEntry = JavaCore.newSourceEntry(project.getFullPath());
		
		int length = currentClasspath.length;
		int i = 0;
		
		// We try to detect the bad entry   
		while ((i < length) && (!currentClasspath[i].equals(badEntry))) {
			i = i + 1;
		} //while
		
		if (i == length) {
			i = -1;
		} // 
		return i;
	}
	
	private static void cleanRootFolderFromClasspath(IProject project, IProgressMonitor monitor, int badEntryIndex) throws JavaModelException {
		
		// We get the new classpath and twe create the new classpath
		IJavaProject javaProject = JavaCore.create(project);
		IClasspathEntry currentClasspath [] = javaProject.getRawClasspath();
		int length =  currentClasspath.length;
		IClasspathEntry newClasspath[] = new IClasspathEntry[length-1];
		
		int i = 0;
		
		// we copy the first part of the array
		while (i < badEntryIndex) {
			newClasspath[i] = currentClasspath[i];
			i = i + 1;
		} // while
		
		while (i < length-1) {
			newClasspath[i] = currentClasspath[i+1];
			i = i + 1;
		} //while
			
		// 	System.arraycopy(currentClasspath, 0, newClasspath, 0, length-1);
		javaProject.setRawClasspath(newClasspath,new SubProgressMonitor(monitor, 1));
		
	} // addEntryToClasspath
	
	public static void checkFolder(IProject project, IProgressMonitor monitor, IFolder folder) throws CoreException {
		
		// Check that both folder exist
		addFolder(project, monitor, folder);
		
		int classpathDirty = isRootOnClasspath(project);
		
		if (classpathDirty != -1) {
			cleanRootFolderFromClasspath(project,monitor,classpathDirty);
		} //if
		
		addEntryToClasspath(project, monitor, folder.getFullPath(),SOURCE);
	}

	/* 
	 * Check if a folder already exist in the project, if it does not, the folder is created
	 */
	private static void addFolder(IProject project, IProgressMonitor monitor, IFolder theFolder)
			throws CoreException {
		if (!theFolder.exists()) {
			theFolder.create(false, true,new SubProgressMonitor(monitor, 1));
		} // if
	} // addFolder
	
	/**
	 * @param file
	 * @param monitor
	 * @throws IOException
	 * @throws CoreException
	 */
	@SuppressWarnings("unused")
	private static void checkDependencies(IProject project, IProgressMonitor monitor) throws IOException, CoreException {
		SubMonitor progress = SubMonitor.convert(monitor, 6);
		try {
			PluginHelper.addPluginDependencies(project, true,progress, 
					new PluginHelper.PluginDescriptor("org.openarchitectureware.dependencies"),
					new PluginHelper.PluginDescriptor("org.openarchitectureware.uml2.adapter"), 
					new PluginHelper.PluginDescriptor("org.openarchitectureware.uml2.adapter.plugin"),
					new PluginHelper.PluginDescriptor("net.ample.wp2.tente.plugin"));
		} catch (BundleException e) {
			e.printStackTrace();
		} // try
	} // checkDependencies
	
	public static IFile checkTraceabilityFile(IProject project, IProgressMonitor monitor) throws CoreException {
		IFile file = project.getFile("/src-gen/traceability.xml");
		if (file.exists()) {
		    file.delete(false, monitor);
			
			// TODO: Check this
			// file.create(source, force, monitor)
			// El parámetro false no tengo ni pitda idea de si es lo que quiero
			// El primer parámetro a null tampoco se si va o no va 
		} // if
		file.create(null, false , monitor);
		return file;
	} // checkTraceabilityFile
	

			
}
