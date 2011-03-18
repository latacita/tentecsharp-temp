using System;
using SmartHome;
using System.Collections.Generic;

namespace SmartHome.LightMng
{
    public class Test
    {
        protected const int MAX_LIGHTS = 3;

        public static int testLightMng(Gateway gtw,int nextId) {
            
            List<LightCtrl> lights = new List<LightCtrl>();
            
            for (int i = 0; i < MAX_LIGHTS; i++) {
                LightCtrl light = new LightCtrl(i+nextId);
                gtw.addLightCtrl(light);
                lights.Add(light);
            } // for

            System.Console.Out.WriteLine("Lights created. Cheking status is OFF");

            List<LightCtrl>.Enumerator it = lights.GetEnumerator();

            while (it.MoveNext()) {
                it.Current.sayHello();
            } // while

            it.Dispose();

            gtw.switchLight(0 + nextId);
            gtw.switchLight(MAX_LIGHTS + nextId - 1);

            System.Console.Out.WriteLine("");
            System.Console.Out.WriteLine("First and last light should be ON");

            it = lights.GetEnumerator();
            
            while (it.MoveNext())
            {
                it.Current.sayHello();
            } // while

            return nextId + MAX_LIGHTS;
        } // testLightMng

    } // Test
} // namespace SmartHome.LightMng
