using System;
using SmartHome;
using System.Collections.Generic;

namespace SmartHome.WindowMng
{
    public class Test
    {
        protected const int MAX_WINDOWS = 4;

        public static int testWindowMng(Gateway gtw,int nextId) {

            List<WindowCtrl> windows = new List<WindowCtrl>();

            for (int i = 0; i < MAX_WINDOWS; i++)
            {
                WindowCtrl window = new WindowCtrl(i + nextId);
                gtw.addWindowCtrl(window);
                windows.Add(window);
            } // for

            System.Console.Out.WriteLine("Lights created. Checking al them are closed.");

            List<WindowCtrl>.Enumerator it = windows.GetEnumerator();

            while (it.MoveNext()) {
                it.Current.sayHello();
            } // while

            it.Dispose();

            gtw.windowOpenWindow(nextId);
            gtw.windowCloseWindow(nextId + 1);
            gtw.windowOpenPartiallyWindow(nextId + MAX_WINDOWS-1, 10.0);

            System.Console.Out.WriteLine("");
            System.Console.Out.WriteLine("First window should be open, second one close and last one 10% open.");

            List<WindowCtrl>.Enumerator it2 = windows.GetEnumerator();
            
            while (it2.MoveNext())
            {
                it2.Current.sayHello();
            } // while

            return nextId + MAX_WINDOWS;
        } // testWindowMng

    } // Test
} // namespace SmartHome.WindowMng
