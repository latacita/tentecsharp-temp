//=====================================================================================================//
// Author: Pablo Sánchez (p.sanchez@unican.es) http://personales.unican.es/sanchezbp                   //
// Author: Elio López                                                                                  //
// Project: SmartHome Implementation using C# partial classes                                          // 
// File: GeneralTest
//=====================================================================================================// 

using System;
using SmartHome;


namespace SmartHome
{
    public class GeneralTest
    {
                
        static int Main(string[] args) {

            int id = 0;
            int windowInit; 
            int windowEnd;

            System.Console.Out.WriteLine("Testing the InitialModel feature");
            System.Console.Out.WriteLine("================================");
            Gateway gtw = SmartHome.InitialModel.Test.testInitialModel();
            System.Console.Out.WriteLine("");

            System.Console.Out.WriteLine("Testing the LightMng feature");
            System.Console.Out.WriteLine("============================");
            id = SmartHome.LightMng.Test.testLightMng(gtw, id);
            System.Console.Out.WriteLine("");

            System.Console.Out.WriteLine("Testing the WindowMng feature");
            System.Console.Out.WriteLine("=============================");
            windowInit = id;
            id = SmartHome.WindowMng.Test.testWindowMng(gtw, id);
            windowEnd  = id;
            System.Console.Out.WriteLine("");

            System.Console.Out.WriteLine("Testing the HeaterMng feature");
            System.Console.Out.WriteLine("=============================");
            id = SmartHome.HeaterMng.Test.testHeaterMng(gtw, id);
            System.Console.Out.WriteLine("");

            System.Console.Out.WriteLine("Testing the SmartEnergyMng feature");
            System.Console.Out.WriteLine("==================================");
            SmartHome.SmartEnergyMng.Test.testSmartEnergyMng(gtw, id-1, windowInit, windowEnd);
            System.Console.Out.WriteLine("");
            
            System.Console.In.ReadLine();
            
            return 0;
        } // Main
 
    } // GeneralTest
} // nameSpace SmartHome
