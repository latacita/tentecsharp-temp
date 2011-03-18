using System;
using System.Collections.Generic;

namespace SmartHome.InitialModel
{
    public class Test
    {
        public static Gateway testInitialModel()
        {
            Gateway gtw = new Gateway();
            gtw.sayHello();
            return gtw;
        } // testInitialModel
    } // Test
} // namespace SmartHome.InitialModel
