#region Using directives

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.ConstrainedExecution;

#endregion

//
// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
//
[assembly: AssemblyTitle(@"")]
[assembly: AssemblyDescription(@"")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany(@"Unican")]
[assembly: AssemblyProduct(@"smartHome")]
[assembly: AssemblyCopyright("")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: System.Resources.NeutralResourcesLanguage("en")]

//
// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Revision and Build Numbers 
// by using the '*' as shown below:

[assembly: AssemblyVersion(@"1.0.0.0")]
[assembly: ComVisible(false)]
[assembly: CLSCompliant(true)]
[assembly: ReliabilityContract(Consistency.MayCorruptProcess, Cer.None)]

//
// Make the Dsl project internally visible to the DslPackage assembly
//
[assembly: InternalsVisibleTo(@"Unican.smartHome.DslPackage, PublicKey=002400000480000094000000060200000024000052534131000400000100010007C6F8B4DF336FF24F54EFE852E8E5CAA3B08ECD83DB9DD9518E733A2A69F4C1E8C0CEFA640A3BB50AD723CB6B9BC6BDE6FC85957F07444AEAE6756687DA0F777ADE557EA51BC0BF1123F7F7BC36BEA98E1A069909F75974E0CBE771FF3010CFDD0EA826EE246A3642AAD18D6519ACDA84656F5A108B2EF5D1211B619D7FD9B9")]