using System;
using SmartHome;
using System.Collections.Generic;

namespace SmartHome.HeaterMng
{
    public class Test
    {
        protected const int MAX_HEATERS = 2;

        public static int testHeaterMng(Gateway gtw,int nextId) {

            List<HeaterCtrl> heaters = new List<HeaterCtrl>();

            for (int i = 0; i < MAX_HEATERS; i++)
            {
                HeaterCtrl window = new HeaterCtrl(i + nextId);
                gtw.addHeaterCtrl(window);
                heaters.Add(window);
            } // for

            System.Console.Out.WriteLine("Heaters created. Checking current temperature is 25º");
            
            List<HeaterCtrl>.Enumerator it = heaters.GetEnumerator();

            while (it.MoveNext()) {
                it.Current.sayHello();
            } // while

            it.Dispose();

            gtw.heaterAdjustTemparature(nextId + 1,20.0);
            
            it = heaters.GetEnumerator();

            System.Console.Out.WriteLine("");
            System.Console.Out.WriteLine("Last heater current temperature should be 25º");
            
            while (it.MoveNext())
            {
                it.Current.sayHello();
            } // while

            return nextId + MAX_HEATERS;
        } // testWindowMng

    } // Test
} // namespace SmartHome.WindowMng
