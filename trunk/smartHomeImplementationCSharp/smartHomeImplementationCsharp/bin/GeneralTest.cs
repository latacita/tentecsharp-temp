//=====================================================================================================//
// Author: Pablo Sánchez (p.sanchez@unican.es) http://personales.unican.es/sanchezbp                   //
// Author: Elio López                                                                                  //
// Project: SmartHome Implementation using C# partial classes                                          // 
// File: GeneralTest
// Papers: Fosd2010                                                                                    //
//=====================================================================================================// 

using System;
using SmartHome;


namespace SmartHome
{
    public class GeneralTest
    {
                
        static int Main(string[] args) {

            int id = 0;

            System.Console.Out.WriteLine("Testing the InitialModel feature");
            System.Console.Out.WriteLine("================================");
            Gateway gtw = SmartHome.InitialModel.Test.testInitialModel();
            System.Console.Out.WriteLine("");

            System.Console.Out.WriteLine("Testing the LightMng feature");
            System.Console.Out.WriteLine("================================");
            id = SmartHome.LightMng.Test.testLightMng(gtw, id);
            System.Console.Out.WriteLine("");

            System.Console.Out.WriteLine("Testing the WindowMng feature");
            System.Console.Out.WriteLine("================================");
            id = SmartHome.WindowMng.Test.testWindowMng(gtw, id);
            System.Console.Out.WriteLine("");

            System.Console.Out.WriteLine("Testing the HeaterMng feature");
            System.Console.Out.WriteLine("================================");
            id = SmartHome.HeaterMng.Test.testHeaterMng(gtw, id);
            System.Console.Out.WriteLine("");
            
            System.Console.In.ReadLine();
            return 0;
        } // Main
 
    } // GeneralTest
} // nameSpace SmartHome
