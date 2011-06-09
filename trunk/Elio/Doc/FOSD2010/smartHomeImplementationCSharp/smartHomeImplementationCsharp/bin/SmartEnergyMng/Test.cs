//=====================================================================================================//
// Author: Pablo Sánchez (p.sanchez@unican.es) http://personales.unican.es/sanchezbp                   //
// Author: Elio López                                                                                  //
// Project: SmartHome Implementation using C# partial classes                                          //
// File: SmartEnergyMng/Gateway.cs                                                                     //
//=====================================================================================================//     

using System;
using System.Collections.Generic;

namespace SmartHome.SmartEnergyMng
{
    class Test
    {

        protected static void showAllWindows(Gateway gtw, int init, int end) {

            for (int i = init; i < end; i++) {
                gtw.windowSayHello(i);
            } //for

        } // showAllWindows

        public static void testSmartEnergyMng(Gateway gtw, int heaterId, int initWindow, int endWindow)
        {

            System.Console.Out.WriteLine("SmartEnergy Mode On.");

            System.Console.Out.WriteLine("");
            System.Console.Out.WriteLine("Current Status of the Windows.");
            System.Console.Out.WriteLine("");
            gtw.setIndoorTemperature(25.0);
            gtw.setOutdoorTemperature(20.0);
            showAllWindows(gtw, initWindow, endWindow);

            System.Console.Out.WriteLine("");
            System.Console.Out.WriteLine("Current Status of the Heater " + heaterId + ".");
            System.Console.Out.WriteLine("");
            gtw.heaterSayHello(heaterId);
            
            // temperature == indoorTemperature
            System.Console.Out.WriteLine("");
            System.Console.Out.WriteLine("Indoor Temperature = 25º :: OutdoorTemperature = 20º.");
            gtw.setIndoorTemperature(25.0);
            gtw.setOutdoorTemperature(20.0);

            System.Console.Out.WriteLine("");
            System.Console.Out.WriteLine("We try to set the heater " + heaterId + " to 25º" );
            gtw.adjustTemparature(heaterId,25);
            System.Console.Out.WriteLine("Windows should be closed. Heater should remain at 20º.");
            System.Console.Out.WriteLine("");
            showAllWindows(gtw,initWindow,endWindow);
            System.Console.Out.WriteLine("");
            gtw.heaterSayHello(heaterId);

            // temperature == outdoorTemperature
            System.Console.Out.WriteLine("");
            System.Console.Out.WriteLine("Indoor Temperature = 25º :: OutdoorTemperature = 30º");
            gtw.setIndoorTemperature(25.0);
            gtw.setOutdoorTemperature(30.0);
    
            System.Console.Out.WriteLine("");
            System.Console.Out.WriteLine("We try to set the heater " + heaterId + " to 30º");
            gtw.adjustTemparature(heaterId, 30);
            System.Console.Out.WriteLine("Windows should be opened. Heater should should remain at 20º.");
            System.Console.Out.WriteLine("");
            showAllWindows(gtw, initWindow, endWindow);
            System.Console.Out.WriteLine("");
            gtw.heaterSayHello(heaterId);

            // Cool the house, outside is warn
            System.Console.Out.WriteLine("");
            System.Console.Out.WriteLine("Indoor Temperature = 25º :: OutdoorTemperature = 30º");
            gtw.setIndoorTemperature(25.0);
            gtw.setOutdoorTemperature(30.0);

            System.Console.Out.WriteLine("");
            System.Console.Out.WriteLine("We try to set the heater " + heaterId + " to 15º");
            gtw.adjustTemparature(heaterId, 15);
            System.Console.Out.WriteLine("Windows should be closed. Heater should be at 15º.");
            System.Console.Out.WriteLine("");
            showAllWindows(gtw, initWindow, endWindow);
            System.Console.Out.WriteLine("");
            gtw.heaterSayHello(heaterId);

            // Cool the house, outside is colder
            System.Console.Out.WriteLine("");
            System.Console.Out.WriteLine("Indoor Temperature = 25º :: OutdoorTemperature = 15º");
            gtw.setIndoorTemperature(25.0);
            gtw.setOutdoorTemperature(15.0);

            System.Console.Out.WriteLine("");
            System.Console.Out.WriteLine("We try to set the heater " + heaterId + " to 20º");
            gtw.adjustTemparature(heaterId, 20);
            System.Console.Out.WriteLine("Windows should be opened. Heater should remain at 15º ");
            System.Console.Out.WriteLine("");
            showAllWindows(gtw, initWindow, endWindow);
            System.Console.Out.WriteLine("");
            gtw.heaterSayHello(heaterId);

            // Heat the house, outside is colder
            System.Console.Out.WriteLine("");
            System.Console.Out.WriteLine("Indoor Temperature = 25º :: OutdoorTemperature = 15º");
            gtw.setIndoorTemperature(25.0);
            gtw.setOutdoorTemperature(15.0);

            System.Console.Out.WriteLine("");
            System.Console.Out.WriteLine("We try to set the heater " + heaterId + " to 30º");
            gtw.adjustTemparature(heaterId, 30);
            System.Console.Out.WriteLine("Windows should be closed. Heater should remain at 30º ");
            System.Console.Out.WriteLine("");
            showAllWindows(gtw, initWindow, endWindow);
            System.Console.Out.WriteLine("");
            gtw.heaterSayHello(heaterId);

            // Heat the house, outside is warmer
            System.Console.Out.WriteLine("");
            System.Console.Out.WriteLine("Indoor Temperature = 25º :: OutdoorTemperature = 45º");
            gtw.setIndoorTemperature(25.0);
            gtw.setOutdoorTemperature(45.0);

            System.Console.Out.WriteLine("");
            System.Console.Out.WriteLine("We try to set the heater " + heaterId + " to 35º");
            gtw.adjustTemparature(heaterId, 35);
            System.Console.Out.WriteLine("Windows should be opened. Heater should remain at 30º ");
            System.Console.Out.WriteLine("");
            showAllWindows(gtw, initWindow, endWindow);
            System.Console.Out.WriteLine("");
            gtw.heaterSayHello(heaterId);
        
        } // testWindowMng
    } 
}
