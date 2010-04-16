/**
 * 
 */
package net.ample.wp2.tente.plugin.actions;

import java.io.FileOutputStream;
import java.io.IOException;
import java.util.Enumeration;
import java.util.jar.Attributes;
import java.util.jar.Manifest;

import org.eclipse.core.resources.IFile;
import org.eclipse.core.resources.IProject;
import org.eclipse.core.resources.ResourcesPlugin;
import org.eclipse.core.runtime.CoreException;
import org.eclipse.core.runtime.SubMonitor;
import org.eclipse.core.runtime.jobs.Job;
import org.eclipse.osgi.util.ManifestElement;
import org.osgi.framework.BundleException;

/**
 * A utility class with functions for extending plugin descriptors.
 * 
 * @author zschaler
 * 
 */
public class PluginHelper {

	/**
	 * Descriptor for one line of required plugins.
	 * 
	 * @author zschaler
	 */
	public static final class PluginDescriptor {
		private String pluginName;
		private String pluginVersion;
		private boolean reexport;

		public PluginDescriptor(String pluginName) {
			this(pluginName, null);
		}

		public PluginDescriptor(String pluginName, String pluginVersion) {
			this(pluginName, pluginVersion, false);
		}

		public PluginDescriptor(String pluginName, String pluginVersion,
				boolean reexport) {
			this.pluginName = pluginName;
			this.pluginVersion = pluginVersion;
			this.reexport = reexport;
		}

		public String getPluginName() {
			return pluginName;
		}

		public String getPluginVersion() {
			return pluginVersion;
		}

		public boolean isReexport() {
			return reexport;
		}

		public String toString() {
			// Just to be on the safe side in case I missed on mention of it in
			// my refactorings below...
			return getPluginName();
		}
	}

	/**
	 * Add the specified plugins as dependencies to the project indicated.
	 * 
	 * @param project
	 * @param overwrite
	 * @param plugins
	 * @throws IOException
	 * @throws CoreException
	 * @throws BundleException
	 */
	public static void addPluginDependencies(IProject project,
			boolean overwrite, SubMonitor progress, PluginDescriptor... plugins)
			throws IOException, CoreException, BundleException {

		IFile manifestFile = project.getFile("META-INF/MANIFEST.MF");
		if (!manifestFile.exists()) {
			throw new IOException("MANIFEST.MF does not yet exist...");
		}
		Manifest mf = new Manifest(manifestFile.getContents());

		for (PluginDescriptor pdCurrent : plugins) {
			addPluginDependency(mf, pdCurrent, overwrite);
		}

		// Make sure any build jobs have stopped, as they can get mightily
		// confused if we change manifest under them...
		Job[] autoBuildJobs;
		Job[] manBuildJobs;
		do {
			autoBuildJobs = Job.getJobManager().find(
					ResourcesPlugin.FAMILY_AUTO_BUILD);
			manBuildJobs = Job.getJobManager().find(
					ResourcesPlugin.FAMILY_MANUAL_BUILD);
		} while (autoBuildJobs.length > 0 || manBuildJobs.length > 0);

		FileOutputStream fos = new FileOutputStream(manifestFile.getLocation()
				.toOSString());
		mf.write(fos);
		fos.close();
		manifestFile.refreshLocal(1, progress.newChild(2));
	}

	/**
	 * Code below copied and adjusted from
	 * http://www.eclipsezone.com/eclipse/forums/t116172.html
	 * 
	 * @param manifest
	 * @param plugin
	 * @param overwrite
	 * @throws BundleException
	 */
	public static void addPluginDependency(Manifest manifest,
			PluginDescriptor plugin, boolean overwrite) throws BundleException {
		/*
		 * Notice that I had to remove any attempts at formatting the
		 * MANIFEST.MF nicely below. Manifest will relayout the text itself (in
		 * a very very stupid way that I would almost consider a bug!) and will
		 * get confused by any '\n' that have been introduced as part of a
		 * value.
		 */
		String requireBundleHeader = "Require-Bundle";
		String bundleVersionAttr = "bundle-version";
		String rexportDirective = "visibility";

		if (plugin == null)
			return;

		boolean foundHeader = false;
		boolean hasValuesForPlugin = false;
		StringBuilder strBuilder = new StringBuilder();

		Attributes mainAttrs = manifest.getMainAttributes();
		for (Object entryName : mainAttrs.keySet()) {
			String values;
			String header;

			// Get the values safely
			if (entryName instanceof String) {
				header = (String) entryName;
				values = mainAttrs.getValue(header);
			} else if (entryName instanceof Attributes.Name) {
				header = (String) ((Attributes.Name) entryName).toString();
				values = mainAttrs.getValue((Attributes.Name) entryName);
			} else {
				throw new BundleException("Unknown Main Attribute Key type: "
						+ entryName.getClass() + " (" + entryName + ")");
			}

			// loop to the next header if we don't find ours
			if (!requireBundleHeader.equals(header))
				continue;

			// found it
			foundHeader = true;

			// process the components of the value for this element see
			// ManifestElement javadocs for spec
			if (values != null) {
				ManifestElement[] elements = ManifestElement.parseHeader(
						header, values);
				for (int i = 0; i < elements.length; i++) {
					ManifestElement manifestElement = elements[i];

					Enumeration<?> keys = manifestElement.getKeys();
					Enumeration<?> directiveKeys = manifestElement
							.getDirectiveKeys();

					StringBuilder valueComponents = new StringBuilder();
					boolean lastElement = i >= elements.length - 1;
					boolean firstElement = i == 0;
					boolean elementIsRequiredPlugin = false;

					for (String pureValue : manifestElement
							.getValueComponents()) {
						if (plugin.getPluginName().equalsIgnoreCase(pureValue)) {
							hasValuesForPlugin = true;
							elementIsRequiredPlugin = true;

							// if its already in the header element components
							// and we are not overwriting quit now
							if (!overwrite)
								return;
						}
						// ALWAYS WRITE THE LAST ; -> if we don't have any keys
						// or directives now - we will have if this is not the
						// required element we will just write the line in one
						// go using manifestElement.getValue()
						valueComponents.append(pureValue + ";");
					}

					if (!elementIsRequiredPlugin) {
						// we haven't got a component THIS TIME which is equal
						// to the component we are looking to change so just
						// write out the whole of this component without editing
						// it, and carry on looking
						strBuilder.append((firstElement ? "" : " "));
						strBuilder.append(manifestElement.getValue());
						if (keys != null) {
							while (keys.hasMoreElements()) {
								String key = (String) keys.nextElement();
								String value = manifestElement
										.getAttribute(key);
								strBuilder.append(";" + key + "=" + value);
							}
						}
						if (directiveKeys != null) {
							while (directiveKeys.hasMoreElements()) {
								String key = (String) directiveKeys
										.nextElement();
								String value = manifestElement
										.getDirective(key);
								strBuilder.append(";" + key + ":=" + value);
							}
						}
						// strBuilder.append((lastElement ? "" : ",\n"));
						strBuilder.append((lastElement ? "" : ","));
						continue;
					} else {
						// write out the value components found so far - we may
						// wish to edit bits of it
						strBuilder.append((firstElement ? "" : " ")
								+ valueComponents);
					}

					boolean foundVersionAttr = false;
					if (keys != null) {
						while (keys.hasMoreElements()) {
							String key = (String) keys.nextElement();
							String value = manifestElement.getAttribute(key);
							if (bundleVersionAttr.equalsIgnoreCase(key)) {
								// always write the last ; if we are editing the
								// values - we will be writing the export
								// directive
								if (plugin.getPluginVersion() != null) {
									strBuilder
											.append(key + "=\""
													+ plugin.getPluginVersion()
													+ "\";");
								}
								foundVersionAttr = true;
							} else {
								// always write the last ; if we are editing the
								// values - we will be writing the export
								// directive
								strBuilder.append(key + "=\"" + value + "\";");
							}
						}
					}

					if (!foundVersionAttr) {
						// always write the last ; if we are editing the values
						// - we will be writing the export directive
						if (plugin.getPluginVersion() != null) {
							strBuilder.append(bundleVersionAttr + "="
									+ plugin.getPluginVersion() + ";");
						}
					}

					boolean foundDirective = false;
					if (directiveKeys != null) {
						while (directiveKeys.hasMoreElements()) {
							String key = (String) directiveKeys.nextElement();
							boolean lastDirective = !directiveKeys
									.hasMoreElements();

							if (rexportDirective.equalsIgnoreCase(key)) {
								foundDirective = true;
								strBuilder.append(key + ":=");
								String dirValues[] = manifestElement
										.getDirectives(key);
								for (int j = 0; j < dirValues.length; j++) {
									String string = dirValues[j];

									boolean lastDirectiveValue = j >= dirValues.length - 1;

									if ("reexport".equalsIgnoreCase(string)
											&& !plugin.isReexport()) {
										string = "private";
									} else if ("private"
											.equalsIgnoreCase(string)
											&& plugin.isReexport()) {
										string = "reexport";
									}

									strBuilder.append(string
											+ (lastDirectiveValue ? "" : ","));
								}
							} else {
								strBuilder.append(key + ":="
										+ manifestElement.getDirective(key));
							}

							if (!lastDirective) {
								strBuilder.append(";");
							}
						}
					}

					if (!foundDirective) {
						strBuilder
								.append(rexportDirective
										+ ":="
										+ (plugin.isReexport() ? "rexport"
												: "private"));
					}

					if (!lastElement) {
						// strBuilder.append(",\n");
						strBuilder.append(",");
					}
				}
			}

			break;
		}

		if (!foundHeader) {
			// Add a new one
			manifest
					.getMainAttributes()
					.putValue(
							requireBundleHeader,
							plugin.getPluginName()
									+ ";"
									+ ((plugin.getPluginVersion() != null) ? bundleVersionAttr
											+ "="
											+ plugin.getPluginVersion()
											+ ";"
											: "")
									+ rexportDirective
									+ ":="
									+ (plugin.isReexport() ? "rexport"
											: "private"));
		} else if (overwrite) {
			// found it and wish to edit it...
			if (hasValuesForPlugin) {
				// we have already edited the values for the plugin we wish to
				// add
				manifest.getMainAttributes().putValue(requireBundleHeader,
						strBuilder.toString());
			} else {
				// There are no values for the plugin we wish to add ... create
				// a fresh entry
				String existingValues = strBuilder.toString();
				boolean areExistingValues = existingValues.trim().length() != 0;
				String newValue = plugin.getPluginName()
						+ ";"
						+ ((plugin.getPluginVersion() != null) ? bundleVersionAttr
								+ "=" + plugin.getPluginVersion() + ";"
								: "") + rexportDirective + ":="
						+ (plugin.isReexport() ? "rexport" : "private");
				// newValue = (areExistingValues) ? (existingValues + ",\n " +
				// newValue)
				newValue = (areExistingValues) ? (existingValues + "," + newValue)
						: newValue;
				manifest.getMainAttributes().putValue(requireBundleHeader,
						newValue);
			}
		}
	}
}